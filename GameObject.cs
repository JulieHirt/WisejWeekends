namespace Game
{
	/// <summary>
	/// An object that exists in a square of a GameGrid
	/// </summary>
	public class GameObject
	{
		/// <summary>
		/// The x coordinate of the object within the GameGrid
		/// </summary>
		public int x;

		/// <summary>
		/// The y coordinate of the object within the GameGrid
		/// </summary>
		public int y;

		public GameObject(int xCoord, int yCoord)
		{
			x = xCoord;
			y = yCoord;
		}
	}
}
