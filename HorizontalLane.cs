using System;

namespace Snake
{
	public class HorizontalLane : Figure
    {
		public HorizontalLane( int x1, int x2, int y, char sym)
        {
			for (int x = x1; x <= x2; x++) {
				pointsList.Add(new Point(x, y, '#'));
            }
        }
    }
}
