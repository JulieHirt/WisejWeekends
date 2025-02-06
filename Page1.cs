using System.Drawing;
using Wisej.Web;

namespace Game
{
    public partial class Page1 : Page
    {

		// dimension of game canvas
		private const int NUMBER_OF_FIELDS_X = 40;
		private const int NUMBER_OF_FIELDS_Y = 30;

		// size of one square in the grid (16x16 pixels)
		private const int FIELD_DIMENSION = 16;

		// stores info about object positions which we then render to the canvas
		GameGrid grid;

		//player position in X and Y- used for calculating if pleyer can move, ie if they will crash into a wall
		//Location should always match the "player" string in GameGrid
		int playerX = 1;
		int playerY = 1;

		public Page1()
        {
            InitializeComponent();

			// set the game canvas to a size specified by the constants above
			GameCanvas.Size = new Size(NUMBER_OF_FIELDS_X * FIELD_DIMENSION, NUMBER_OF_FIELDS_Y * FIELD_DIMENSION);

			//set the game grid size (stores info about object positions which we then render to the canvas)
			grid = new GameGrid(NUMBER_OF_FIELDS_X, NUMBER_OF_FIELDS_Y);

			//initial set up of player and walls
			grid.WriteToGrid("player", playerX, playerY);
			grid.WriteToGrid("wall", 20, 10);
			grid.WriteToGrid("wall", 10, 20);
			grid.WriteToGrid("wall", 5, 15);
		}

		private void buttonUp_Click(object sender, System.EventArgs e)
		{
			grid.MovementAttemptWriteToGrid("player", 1, 1, 1, 0);
			//redraw
			GameCanvas.Invalidate();
		}

		private void GameCanvas_Paint(object sender, PaintEventArgs e)
		{
			var image = Properties.Resources.grass;//set image to grass by default

			//Loop through each square in the grid and paint it
			for (int x = 0; x < grid.xDimension; x++)
			{
				for (int y = 0; y < grid.yDimension; y++)
				{
					var val = grid.ReadFromGrid(x,y);
					if (val != null)
					{
						Point point = new Point(x * FIELD_DIMENSION, y * FIELD_DIMENSION);
						if (val == "player")
						{
							image = Properties.Resources.player;
						}
						else
							if (val == "wall")
						{
							image = Properties.Resources.wall;
						}
						e.Graphics.DrawImage(image, point);
					}
				}
		}
		}

	}
}
