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

		}

		
	}
}
