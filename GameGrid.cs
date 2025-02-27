using Game;
using System;

public class GameGrid
{
	private GameObject[,] grid;

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
	}

	/// <summary>
	/// Write to a grid square
	/// </summary>
	/// <param name="g">GameObject to be written to the grid</param>
	public void WriteToGrid(GameObject g)
	{
		if (CheckValidCoordinates(g.x, g.y))
		{
				grid[g.x, g.y] = g;
		}
	}

	/// <summary>
	/// Attempts to move an object in the grid. May fail if collision happens (ie player running into wall)
	/// </summary>
	/// <param name="g">GameObject to be moved</param>
	/// <param name="xPrevious">Previous x coordinate of the object before attempting to move</param>
	/// <param name="yPrevious">Previous y coordinate of the object before attempting to move</param>
	/// <param name="xNew">Potential new x coordinate of the object if movement is sucessful</param>
	/// <param name="yNew">Potential new y coordinate of the object if movement is sucessful</param>
	/// <returns>The new location of the object if it sucessfully moved; The old location if it did not move.</returns>
	public int[] MovementAttemptWriteToGrid(GameObject g, int xPrevious, int yPrevious, int xNew, int yNew)
	{
		if (CheckValidCoordinates(xNew, yNew))
		{
			//can move into empty space
			if (grid[xNew, yNew] == null)
			{
				grid[xNew, yNew] = g;
				grid[xPrevious, yPrevious] = null;

				int[] point = { xNew, yNew };
				return point;
			}
			else //something is moving into the same space as something else- collision code
			//TODO: Add more collisions here eg, bullet and player
			{
				//if player tries to occupy the same space as a wall
				if(grid[xPrevious, yPrevious].GetType() == typeof(Player) && grid[xNew, yNew].GetType() == typeof(Wall))
				{
					int[] point = { xPrevious, yPrevious };
					return point;
				}
				else
				{
					//something is moving into the same space as something else- stop it
					int[] point = { xPrevious, yPrevious };
					return point;
				}
			}
		}
		else
		{
			//new coordinates are not valid- object would go off the grid
			int[] point = { xPrevious, yPrevious };
			return point;
		}
		
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
}
