namespace Game
{
	public class Bullet:GameObject
	{
		/// <summary>
		/// Either +1 -1 or 0 depending if the bullet is going to the right, left, or not moving along x axis
		/// </summary>
		public int xVelocity;

		/// <summary>
		/// Either +1 -1 or 0 depending if the bullet is going down, up or not moving along y axis
		/// </summary>
		public int yVelocity;

		/// <summary>
		/// when true, bullet is marked for deletion
		/// Used to prevent bullet from deleting while a list is being iterated through.
		/// see MoveBullets function in GameGrid
		/// </summary>
		public bool delete;
		public Bullet(int x, int y, int xvelocity, int yvelocity) : base(x, y)
		{
			xVelocity = xvelocity;
			yVelocity = yvelocity;
			delete = false;
		}

	}
}
