using System;

namespace IOTextFiles
{
	class MainClass
	{

		public static void Main(string[] args)
		{
			STable _STable = new STable();
			IOSettings _io = new IOSettings(_STable);

			//Console.WriteLine(_STable.stable[0]);

			//	if (_io.save())
			//	{
			//		Console.WriteLine("\nТаблицата е запаметена успешно.\n");
			//	}
			//	else {
			//		Console.WriteLine("\nТаблицата НЕ е запаметена успешно.\n");

			//	}

			if (_io.open())
			{
				Console.WriteLine("\nТаблицата е прочетена успешно.\n");
			}
			else {
				Console.WriteLine("\nТаблицата НЕ е прочетена успешно.\n");

			}
		}
		}
		}