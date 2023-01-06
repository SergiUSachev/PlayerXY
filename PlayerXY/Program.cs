namespace PlayerXY
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
		}
	}
	public class Player
	{
		private int _x;
		private int _y;

		public int X { get { return _x; } private set { _x = value; } }
		public int Y { get { return _y; } private set { _y = value; } }

		public Player(int x, int y) 
		{
			x = _x;
			y = _y;

		}

	}

	public class Renderer
	{

	}
}