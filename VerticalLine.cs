using System;

namespace Snake
{
	public class VerticalLane : Figure
    {   
		public VerticalLane( int y1, int y2, int x, char sym)
        {
			for (int y = y1; y <= y2; y++) {
				pointsList.Add(new Point(x, y, '#'));
            }
        }
    }
}
