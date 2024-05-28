

namespace Main
{
	using System;
	class Main
	{
		static void Main(string[] args)
		{
			
		}
	}

	// a class to manage multiple prints into one print.
	class Merger
	{
		public List<char> current_frame;
		public Merger() {
			List<char> current_frame = List<char>();
		}
		// higher layer, more priority.
		public void AddFrame(Frame frame)
		{
		}
		public void Draw()
		{

		}
	}

	class Frame
	{
		public int layer;
		public string frame;
		public Coordinate coords;
	}
	class Coordinate
	{
		public int x;
		public int y;
	}
}
