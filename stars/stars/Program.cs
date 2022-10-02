using System;

public class AppStars
{
	public static void Main()
	{
		Console.ForegroundColor = ConsoleColor.DarkCyan;
		Console.WriteLine("Create a box with *");
		Console.WriteLine("");
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("Choose language, where you want to continue:");

		Console.WriteLine("E --> English");
		Console.WriteLine("P --> Polish");
		Console.WriteLine("I --> Italiano");

		ConsoleKey choice = Console.ReadKey().Key;

		Console.Clear();

		switch (choice)
		{
			case ConsoleKey.E:
				{
					Console.Write("Enter the width: ");
					string xs = Console.ReadLine();

					Console.Write("Enter height: ");
					string ys = Console.ReadLine();

					// CORRECTNESS VERIFICATION:
					//Console.WriteLine(xs + " " + ys);
					//Console.ReadKey();

					int x = int.Parse(xs);
					int y = int.Parse(ys);


					for (int i = 0; i < y; i++)
					{
						for (int w = 0; w < x; w++)
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
					Console.Write("Podaj szerokość: ");
					string xs = Console.ReadLine();

					Console.Write("Podaj wysokość: ");
					string ys = Console.ReadLine();

					// WERYFIKACJA POPRAWNOŚCI:
					//Console.WriteLine(xs + " " + ys);
					//Console.ReadKey();

					int x = int.Parse(xs);
					int y = int.Parse(ys);


					for (int i = 0; i < y; i++)
					{
						for (int w = 0; w < x; w++)
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
					Console.Write("Inserisci la larghezza: ");
					string xs = Console.ReadLine();

					Console.Write("Inserisci l'altezza: ");
					string ys = Console.ReadLine();

					// VERIFICA DELLA CORRETTEZZA:
					//Console.WriteLine(xs + " " + ys);
					//Console.ReadKey();

					int x = int.Parse(xs);
					int y = int.Parse(ys);


					for (int i = 0; i < y; i++)
					{
						for (int w = 0; w < x; w++)
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