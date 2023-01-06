namespace PlayerXY
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Player playerOne = new Player(102, 50);
			Renderer renderer = new Renderer();

			renderer.DrawPlayer(playerOne.X, playerOne.Y, '$');





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
			X = x;
			Y = y;
		}
	}

	public class Renderer
	{
		public void DrawPlayer(int x, int y, char character)
		{
			Console.CursorVisible = false;
			Console.SetCursorPosition(x, y);
			Console.Write(character);
			Console.ReadKey(true);
		}
	}
}