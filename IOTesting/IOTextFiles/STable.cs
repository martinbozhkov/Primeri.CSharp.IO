using System;
namespace IOTextFiles
{
	public class STable
	{
		public string[] stable = new string[4];

		public STable()
		{
			fillStable();
		}

		private void fillStable()
		{
			stable[0] = "1,2,3,4,5";
			stable[1] = "10,20,30,40,50";
			stable[2] = "100,200,300,400,500";
			stable[3] = "1000,2000,3000,4000,5000";

		}

	}
}
