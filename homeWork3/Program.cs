using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork3
{
	class Program
	{
		static void Main(string[] args)
		{
			// 4.5
			float maxPrice = 1000;
			float minPrice = 900;
			Console.Write("Input the price: ");
			float nowPrice = float.Parse(Console.ReadLine());
			//if (nowPrice > maxPrice || nowPrice < minPrice)
			//{
			//	if (nowPrice > maxPrice) Console.WriteLine($"Price is bigger than {maxPrice}!");
			//	if (nowPrice < minPrice) Console.WriteLine($"Price is less than {minPrice}!");
			//}
			//else Console.WriteLine("Price is still OK.");
			if (nowPrice > maxPrice) Console.WriteLine($"Price is bigger than {maxPrice}!");
			if (nowPrice < minPrice) Console.WriteLine($"Price is less than {minPrice}!");
			if (nowPrice < maxPrice && nowPrice > minPrice) Console.WriteLine("Price is still OK.");
			Console.ReadKey();

			// 4.6
			float a, b;
			float res;
			char act;
			Console.Write("Input 1st number: ");
			a = float.Parse(Console.ReadLine());
			Console.Write("Input action (+, - , *, /, %): ");
			act = char.Parse(Console.ReadLine());

			while (!(act == '+' || act == '-' || act == '*' || act == '/' || act == '%'))
			{
				Console.Write("Wrong action! Input another action (+, - , *, /, %): ");
				act = char.Parse(Console.ReadLine());
			}

			Console.Write("Input 2nd number: ");
			b = float.Parse(Console.ReadLine());
			Console.WriteLine();

			switch (act)
			{
				case '+':
					res = a + b;
					Console.WriteLine($"{a} + {b} = {res}");
					break;

				case '-':
					res = a - b;
					Console.WriteLine($"{a} - {b} = {res}");
					break;

				case '*':
					res = a * b;
					Console.WriteLine($"{a} * {b} = {res}");
					break;

				case '/':
					res = a / b;
					Console.WriteLine($"{a} / {b} = {res}");
					break;

				case '%':
					res = a % b;
					Console.WriteLine($"{a} % {b} = {res}");
					break;


			}
			Console.ReadKey();

			// 4.7
			string fCar = "First car";
			string sCar = "Second car";
			Console.Write("Input name of 1st car: ");
			string nameFirstCar = Console.ReadLine();
			Console.Write("Input max speed of 1st car: ");
			float maxSpeedFirstCar = float.Parse(Console.ReadLine());
			Console.Write("Input petrol consumtion of 1st car: ");
			float petrolConsumptionFirstCar = float.Parse(Console.ReadLine());
			Console.Write("Input name of 2nd car: ");
			string nameSecondCar = Console.ReadLine();
			Console.Write("Input max speed of 2nd car: ");
			float maxSpeedSecondCar = float.Parse(Console.ReadLine());
			Console.Write("Input petrol consumption of 2nd car: ");
			float petrolConsumptionSecondCar = float.Parse(Console.ReadLine());
			char speed, petrol;

			if (maxSpeedFirstCar > maxSpeedSecondCar) speed = '>';
			if (maxSpeedFirstCar < maxSpeedSecondCar) speed = '<';
			else speed = '=';

			if (petrolConsumptionFirstCar > petrolConsumptionSecondCar) petrol = '>';
			if (petrolConsumptionFirstCar < petrolConsumptionSecondCar) petrol = '<';
			else petrol = '=';


			//Console.WriteLine($"\n{fCar,40}{sCar,30}");
			//Console.WriteLine($"Model: {nameFirstCar,33}{nameSecondCar,30}");
			//Console.WriteLine($"Max Speed: {maxSpeedFirstCar,29}{speed,15}{maxSpeedSecondCar,15}");
			//Console.WriteLine($"Petrol Consumption: {petrolConsumptionFirstCar,20}{petrol,15}{petrolConsumptionSecondCar,15}");

			Console.SetCursorPosition(25, 10);
			Console.WriteLine($"{fCar}");
			Console.SetCursorPosition(60, 10);
			Console.WriteLine($"{sCar}");

			Console.SetCursorPosition(0, 11);
			Console.WriteLine("Model:");
			Console.SetCursorPosition(0, 12);
			Console.WriteLine("Max Speed:");
			Console.SetCursorPosition(0,13);
			Console.WriteLine("Petrol Consumption:");

			Console.SetCursorPosition(25, 11);
			Console.WriteLine($"{nameFirstCar}");
			Console.SetCursorPosition(25, 12);
			Console.WriteLine($"{maxSpeedFirstCar}");
			Console.SetCursorPosition(25, 13);
			Console.WriteLine($"{petrolConsumptionFirstCar}");

			Console.SetCursorPosition(43, 12);
			Console.WriteLine($"{speed}");
			Console.SetCursorPosition(43, 13);
			Console.WriteLine($"{petrol}");

			Console.SetCursorPosition(60, 11);
			Console.WriteLine($"{nameSecondCar}");
			Console.SetCursorPosition(60, 12);
			Console.WriteLine($"{maxSpeedSecondCar}");
			Console.SetCursorPosition(60, 13);
			Console.WriteLine($"{petrolConsumptionSecondCar}");


			Console.ReadKey();
		}
	}
}
