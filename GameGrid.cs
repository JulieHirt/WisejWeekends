using System;

public class GameGrid
{
	private string[,] grid;
	/// <summary>
	/// Class that contains a 2D array of strings which represents all objects in the game
	/// </summary>
	/// <param name="XDimension">Number of squares the grid has horizontally</param>
	/// <param name="YDimension">Number of squares the grid has vertically</param>
	public GameGrid(int XDimension, int YDimension)
	{
		grid = new string[XDimension, YDimension];
	}

	/// <summary>
	/// Write to a grid square
	/// </summary>
	/// <param name="s">String that represents the object to be written to the grid</param>
	/// <param name="x">x coordinate of the object</param>
	/// <param name="y">y coordinate of the object</param>
	public void WriteToGrid(string s, int x, int y)
	{
		if (CheckValidCoordinates(x, y))
		{
			//TODO: Add code here to check for collisions when attempting to write over an object
				grid[x, y] = s;
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
	public string ReadFromGrid(int x, int y)
	{
		if (CheckValidCoordinates(x, y))
		{
			return grid[x, y];
		}
		else
		{
			return "error";
		}
	}
}
