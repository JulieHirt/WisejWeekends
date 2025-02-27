namespace Game
{
	/// <summary>
	/// A player that can move by using the arrow keys
	/// </summary>
	public class Player:GameObject
	{
		/// <summary>
		/// An ID to indicate which player this is. Will be used when there are multiple players.
		/// </summary>
		public int ID;

		public Player(int id, int xCoord, int yCoord) : base(xCoord, yCoord)
		{
			ID = id;
		}
	}
}
