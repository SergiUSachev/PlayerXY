namespace PlayerXY
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Player playerOne = new Player(100, 250);
			Renderer renderer = new Renderer();

			renderer.DrawPlayer(playerOne.Xposition, playerOne.Yposition, '$');
		}
	}

	public class Player
	{
		public int Xposition { get; private set; }
		public int Yposition { get; private set; }

		public Player(int xPosition, int yPosition)
		{
			Xposition = xPosition;
			Yposition = yPosition;
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