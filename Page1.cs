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

		public Page1()
        {
            InitializeComponent();

			// set the game canvas to a size specified by the constants above
			GameCanvas.Size = new Size(NUMBER_OF_FIELDS_X * FIELD_DIMENSION, NUMBER_OF_FIELDS_Y * FIELD_DIMENSION);

			//set the game grid size (stores info about object positions which we then render to the canvas)
			grid = new GameGrid(NUMBER_OF_FIELDS_X, NUMBER_OF_FIELDS_Y);
		}

		private void buttonUp_Click(object sender, System.EventArgs e)
		{
            grid.WriteToGrid("player", 1, 4);
            AlertBox.Show(grid.ReadFromGrid(1,4));

			//redraw
			GameCanvas.Invalidate();

		}


		private void GameCanvas_Paint(object sender, PaintEventArgs e)
		{
			int FIELD_DIMENSION = 16;
			var image = Properties.Resources.player;
			Point point = new Point(1 * FIELD_DIMENSION, 4 * FIELD_DIMENSION);
			e.Graphics.DrawImage(image, point);

			//TODO: loop through each square in the grid and paint it
		}

	}
}
