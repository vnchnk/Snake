using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {         
			HorizontalLane hl1 = new HorizontalLane(0, 79, 0, '#');
			hl1.Draw();
			HorizontalLane hl2 = new HorizontalLane(0, 79, 24, '#');
            hl2.Draw();
			VerticalLane vl1 = new VerticalLane(0, 24, 79, '#');
			vl1.Draw();
			VerticalLane vl2 = new VerticalLane(0, 24, 0, '#');
            vl2.Draw();

			Snake snake = new Snake(new Point(4,5,'-'), 8, Direction.DOWN);			snake.Draw();
            
			Console.ReadLine();
        }
    }
}
