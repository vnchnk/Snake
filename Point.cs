using System;
namespace Snake
{
    public class Point
    {
		public int x { get; set; }
		public int y { get; set; }
		public char sym { get; set; }

		public Point( int x, int y, char sym)
        {
			this.x = x;
			this.y = y;
			this.sym = sym;
        }

		public Point(Point point){
			this.x = point.x;
			this.y = point.y;
			this.sym = point.sym; 
		}

		public void Move(int offset, Direction direction){
			if(direction == Direction.UP){
				this.y = y - offset;
			} else if (direction == Direction.DOWN) {
				this.y = y + offset;
			} else if (direction == Direction.RIGHT) {
				this.x = x + offset;
			} else if (direction == Direction.LEFT) {
				this.x = x - offset;
            }
		}
      
		public void Draw()
        {
			Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
