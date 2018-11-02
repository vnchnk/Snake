using System;
using System.Collections.Generic;

namespace Snake
{
    public class Figure
    {
		
		protected List<Point> pointsList = new List<Point>();

		public void Draw()
        {
			foreach (Point point in pointsList)
            {
				point.Draw();
            }
        }
    }
}
