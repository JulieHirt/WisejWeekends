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
		}
	}
}
