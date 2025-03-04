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
		public Bullet(int x, int y, int xvelocity, int yvelocity) : base(x, y)
		{
			xVelocity = xvelocity;
			yVelocity = yvelocity;
		}

	}
}
