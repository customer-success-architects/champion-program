// class point that represents a point in 2D space and has x and y coordinates

class point
{
		public int x;
		public int y;

		// constructor that initializes the point with given x and y coordinates
		public point(int x, int y)
		{
				this.x = x;
				this.y = y;
		}

		// method to calculate the distance between two points
		public double distance(point p)
		{
				return Math.Sqrt(Math.Pow(this.x - p.x, 2) + Math.Pow(this.y - p.y, 2));
		}
}