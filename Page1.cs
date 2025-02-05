using System.Drawing;
using Wisej.Web;

namespace Game
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

		private void buttonUp_Click(object sender, System.EventArgs e)
		{
            AlertBox.Show("Clicked!");
            GameGrid grid = new GameGrid(5,5);
            grid.WriteToGrid("hello", 1, 4);
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
		}
	}
}
