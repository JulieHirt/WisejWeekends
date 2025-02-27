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

		//the player GameObject
		Player player;

		public Page1()
        {
            InitializeComponent();

			// set the game canvas to a size specified by the constants above
			GameCanvas.Size = new Size(NUMBER_OF_FIELDS_X * FIELD_DIMENSION, NUMBER_OF_FIELDS_Y * FIELD_DIMENSION);

			//set the game grid size (stores info about object positions which we then render to the canvas)
			grid = new GameGrid(NUMBER_OF_FIELDS_X, NUMBER_OF_FIELDS_Y);

			//create the player with ID of 1 and coordinates of (1,1)
			player = new Player(1, 1, 1);

			//initial set up of player and walls
			grid.WriteToGrid(player);
			grid.WriteToGrid(new Wall(20,10));
			grid.WriteToGrid(new Wall(10,20));
			grid.WriteToGrid(new Wall(5,15));
		}

		private void buttonUp_Click(object sender, System.EventArgs e)
		{
			//note that the upper left corner is 0,0 - thus to go up 1 square we subtract 1 from the y coordinate
			grid.MovementAttemptWriteToGrid(player, player.x, player.y-1);
			//redraw
			GameCanvas.Invalidate();
		}
		private void buttonDown_Click(object sender, System.EventArgs e)
		{
			//note that the upper left corner is 0,0 - thus to go down 1 square we add 1 to the y coordinate
			grid.MovementAttemptWriteToGrid(player, player.x, player.y + 1);
			//redraw
			GameCanvas.Invalidate();
		}
		private void buttonRight_Click(object sender, System.EventArgs e)
		{
			grid.MovementAttemptWriteToGrid(player, player.x+1, player.y);
			//redraw
			GameCanvas.Invalidate();
		}
		private void buttonLeft_Click(object sender, System.EventArgs e)
		{
			grid.MovementAttemptWriteToGrid(player, player.x-1, player.y);
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
						if (val.GetType() == typeof(Player))
						{
							image = Properties.Resources.player;
						}
						else
							if (val.GetType() == typeof(Wall))
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
