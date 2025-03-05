using Game;
using System;
using System.Collections.Generic;

public class GameGrid
{
	private GameObject[,] grid;

	private List<Bullet> bulletList;
	/// <summary>
	/// Number of squares the grid has along the x axis 
	/// </summary>
	public int xDimension;

	/// <summary>
	/// Number of squares the grid has along the y axis
	/// </summary>
	public int yDimension;

	/// <summary>
	/// Class that contains a 2D array of strings which represents all objects in the game
	/// </summary>
	/// <param name="XDimension">Number of squares the grid has horizontally</param>
	/// <param name="YDimension">Number of squares the grid has vertically</param>
	public GameGrid(int XDimension, int YDimension)
	{
		grid = new GameObject[XDimension, YDimension];
		xDimension = XDimension;
		yDimension = YDimension;

		bulletList = new List<Bullet>();

	}

	/// <summary>
	/// Write to a grid square
	/// </summary>
	/// <param name="g">GameObject to be written to the grid</param>
	public void AttemptWriteToGrid(GameObject g)
	{
		if (CheckValidCoordinates(g.x, g.y) && grid[g.x, g.y] == null)
		{
				grid[g.x, g.y] = g;
			if(g.GetType() == typeof(Bullet))
			{
				Bullet b = (Bullet)g;
				bulletList.Add(b);
			}
		}
	}

	/// <summary>
	/// Attempts to move an object in the grid. May fail if collision happens (ie player running into wall)
	/// </summary>
	/// <param name="g">GameObject to be moved</param>
	/// <param name="xNew">Potential new x coordinate of the object if movement is sucessful</param>
	/// <param name="yNew">Potential new y coordinate of the object if movement is sucessful</param>
	/// <returns>The new location of the object if it sucessfully moved; The old location if it did not move.</returns>
	public void MovementAttemptWriteToGrid(GameObject g, int xNew, int yNew)
	{
		int xPrevious = g.x;
		int yPrevious = g.y;
		if (CheckValidCoordinates(xNew, yNew))
		{
			//can move into empty space
			if (grid[xNew, yNew] == null)
			{
				grid[xNew, yNew] = g;
				grid[xPrevious, yPrevious] = null;

				//set the x and y coordinates of the GameObject to the new position
				//important so that they match the coordinates of the grid
				g.x = xNew;
				g.y = yNew;
			}
			//No need to run this code- nothing changes
			//else //something is moving into the same space as something else- collision code
			////TODO: Add more collisions here eg, bullet and player
			//{
			//	//if player tries to occupy the same space as a wall
			//	if(grid[xPrevious, yPrevious].GetType() == typeof(Player) && grid[xNew, yNew].GetType() == typeof(Wall))
			//	{
			//		g.x = xPrevious;
			//		g.y = yPrevious;
			//	}
			//	else
			//	{
			//		//something is moving into the same space as something else- stop it
			//		g.x = xPrevious;
			//		g.y = yPrevious;
			//	}
			//}
		}
		//No need to run this code- nothing changes
		//else
		//{
		//	//new coordinates are not valid- object would go off the grid
		//	g.x = xPrevious;
		//	g.y = yPrevious;
		//}
		
	}


	/// <summary>
	/// Check that the given coordinates correspond to a space inside the grid
	/// </summary>
	/// <param name="x">x coordinate to check</param>
	/// <param name="y">y coordinate to check</param>
	/// <returns>true if both coordinates are valid, false if either coordinate is not valid</returns>
	public bool CheckValidCoordinates(int x, int y)
	{
		//check that x and y are within the grid area
		if (x >= 0 && y >= 0 && x < grid.GetLength(0) && y < grid.GetLength(1))
		{
			return true;
		}
		else
		{
			return false;
		}
		//remember that arrays start counting from 0. If the Xdimension is 5, there are items at 0,1,2,3,4
		//so if we attempt to get an object with one of the coordinates equal to Xdimension that is out of bounds
		//thus we use x < grid.GetLength(0) as opposed to x <= grid.GetLength(0)
	}
	/// <summary>
	/// Get the value from a square in the grid
	/// </summary>
	/// <param name="x">X coordinate of the square to be read from</param>
	/// <param name="y">Y coordinate of the square to be read from</param>
	/// <returns></returns>
	public GameObject ReadFromGrid(int x, int y)
	{
		if (CheckValidCoordinates(x, y))
		{
			return grid[x, y];
		}
		else
		{
			return new GameObject(x, y);
		}
	}

	/// <summary>
	/// Move all bullets according to their velocity
	/// </summary>
	public void MoveBullets()
	{

		foreach (Bullet bullet in bulletList)
		{
			MovementAttemptWriteToGrid(bullet, bullet.x + bullet.xVelocity, bullet.y + bullet.yVelocity);
		}
	}
}
