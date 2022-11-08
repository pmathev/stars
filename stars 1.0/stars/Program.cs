using System;

public class Stars
{
	public static void Main()
	{
		Console.ForegroundColor = ConsoleColor.DarkCyan;
		Console.Write("Welcome in stars!");
		Console.ForegroundColor = ConsoleColor.White;
		Console.Write(" What's your name? ");
		string name = Console.ReadLine();
		Console.Clear();

		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine(name + " choose language, where you want to continue:\n");


		Console.ForegroundColor = ConsoleColor.DarkCyan;
		Console.Write("\tE ");
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("--> English");

		Console.ForegroundColor = ConsoleColor.DarkCyan;
		Console.Write("\tP ");
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("--> Polish");

		Console.ForegroundColor = ConsoleColor.DarkCyan;
		Console.Write("\tI ");
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("--> Italiano");
			

	ConsoleKey choice = Console.ReadKey().Key;

		Console.Clear();

		switch (choice)
		{
			case ConsoleKey.E:
				{
					Console.ForegroundColor = ConsoleColor.DarkCyan;
					Console.WriteLine("Create a box of stars *\n");
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("Enter the width: ");
					string xs = Console.ReadLine();
					Console.Clear();

					Console.ForegroundColor = ConsoleColor.DarkCyan;
					Console.WriteLine("Create a box of stars *\n");
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("Enter height: ");
					string ys = Console.ReadLine();
					Console.Clear();

					Console.WriteLine(name + ", it's your  box of stars:\n");
					int x = int.Parse(xs);
					int y = int.Parse(ys);

					for (int w = 0; w < y; w++)
					{
						for (int s = 0; s < x; s++)
						{
							Console.ForegroundColor = ConsoleColor.DarkCyan;
							Console.Write("*");
						}
						Console.WriteLine();
					}

					Console.ReadKey();
				}
				break;

			case ConsoleKey.P:
				{
					Console.ForegroundColor = ConsoleColor.DarkCyan;
					Console.WriteLine("Utwórz pudełko z gwiazd *\n");
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("Podaj szerokość: ");
					string xs = Console.ReadLine();
					Console.Clear();


					Console.ForegroundColor = ConsoleColor.DarkCyan;
					Console.WriteLine("Utwórz pudełko z gwiazd *\n");
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("Podaj wysokość: ");
					string ys = Console.ReadLine();
					Console.Clear();

					Console.WriteLine(name + ", to twoje pudełko z gwiazd:\n");
					int x = int.Parse(xs);
					int y = int.Parse(ys);

					for (int w = 0; w < y; w++)
					{
						for (int s = 0; s < x; s++)
						{
							Console.ForegroundColor = ConsoleColor.DarkCyan;
							Console.Write("*");
						}
						Console.WriteLine();
					}

					Console.ReadKey();
				}

				break;

			case ConsoleKey.I:
				{
					Console.ForegroundColor = ConsoleColor.DarkCyan;
					Console.WriteLine("Crea una scatola di stelle *\n");
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("Inserisci la larghezza: ");
					string xs = Console.ReadLine();
					Console.Clear();

					Console.ForegroundColor = ConsoleColor.DarkCyan;
					Console.WriteLine("Crea una scatola di stelle *\n");
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("Inserisci l'altezza: ");
					string ys = Console.ReadLine();
					Console.Clear();


					Console.WriteLine(name + ", è la tua scatola di stelle:\n");
					int x = int.Parse(xs);
					int y = int.Parse(ys);

					for (int w = 0; w < y; w++)
					{
						for (int s = 0; s < x; s++)
						{
							Console.ForegroundColor = ConsoleColor.DarkCyan;
							Console.Write("*");
						}
						Console.WriteLine();
					}

					Console.ReadKey();
				}

				break;

			default:
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.WriteLine("ERROR" + " " + "There is no such an option, try again");
				Console.ReadKey();
				break;
		}
	}
}
