using System;

public class Stars
{
    public static void Main()
    {
        Console.Title = "Stars";

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write("Welcome in stars!");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" What's your name? ");
        Console.Write("\nMy name is: ");
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
                    do
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Create a box of stars *\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Enter the width: ");
                        string xs = Console.ReadLine();
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Create a box of stars *\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Enter the height: ");
                        string ys = Console.ReadLine();
                        Console.Clear();

                        Console.WriteLine(name + ", it's your box of stars:\n");
                        double x = double.Parse(xs);
                        double y = double.Parse(ys);

                        for (double w = 0; w < y; w++)
                        {
                            for (double s = 0; s < x; s++)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\n\nClick i to view information ");

                        ConsoleKey choicee = Console.ReadKey().Key;

                        Console.SetCursorPosition(0, Console.CursorTop);
                        Console.Write(new string(' ', Console.WindowWidth));
                        Console.SetCursorPosition(0, Console.CursorTop);

                        switch (choicee)
                        {
                            case ConsoleKey.I:

                                Console.WriteLine("---------\nParameters");
                                Console.WriteLine("Width: " + xs);
                                Console.WriteLine("Height: " + ys);
                                Console.WriteLine("\nMenu");
                                Console.WriteLine("Create a new - ENTER");
                                Console.WriteLine("Exit - ESC");
                                //Console.ReadKey();
                                break;

                            default:
                                break;
                        }
                    } while (Console.ReadKey().Key == ConsoleKey.Enter);
                }

                break;

            case ConsoleKey.P:
                {
                    do
                    {
                        Console.Clear();
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
                        double x = double.Parse(xs);
                        double y = double.Parse(ys);

                        for (double w = 0; w < y; w++)
                        {
                            for (double s = 0; s < x; s++)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\n\nKliknij i aby wyświetlić informacje ");

                        ConsoleKey choicee = Console.ReadKey().Key;

                        Console.SetCursorPosition(0, Console.CursorTop);
                        Console.Write(new string(' ', Console.WindowWidth));
                        Console.SetCursorPosition(0, Console.CursorTop);

                        switch (choicee)
                        {
                            case ConsoleKey.I:

                                Console.WriteLine("---------\nParametry");
                                Console.WriteLine("Szerokość: " + xs);
                                Console.WriteLine("Wysokość: " + ys);
                                Console.WriteLine("\nMenu");
                                Console.WriteLine("Utwórz nowe - ENTER");
                                Console.WriteLine("Wyjście - ESC");
                                //Console.ReadKey();
                                break;

                            default:
                                break;
                        }
                    } while (Console.ReadKey().Key == ConsoleKey.Enter);
                }

                break;

            case ConsoleKey.I:
                {
                    do
                    {
                        Console.Clear();
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
                        double x = double.Parse(xs);
                        double y = double.Parse(ys);

                        for (double w = 0; w < y; w++)
                        {
                            for (double s = 0; s < x; s++)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\n\nFare clic su i per visualizzare le informazioni ");

                        ConsoleKey choicee = Console.ReadKey().Key;

                        Console.SetCursorPosition(0, Console.CursorTop);
                        Console.Write(new string(' ', Console.WindowWidth));
                        Console.SetCursorPosition(0, Console.CursorTop);

                        switch (choicee)
                        {
                            case ConsoleKey.I:

                                Console.WriteLine("---------\nParametri");
                                Console.WriteLine("Larghezza: " + xs);
                                Console.WriteLine("Altezza: " + ys);
                                Console.WriteLine("\nMenù");
                                Console.WriteLine("Creane nuovo - ENTER");
                                Console.WriteLine("Uscita - ESC");
                                //Console.ReadKey();
                                break;

                            default:
                                break;
                        }
                    } while (Console.ReadKey().Key == ConsoleKey.Enter);
                }

                break;

            default:
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("ERROR" + " " + "There is no such an option, try again");
                Console.ReadKey();
                break;
        }

        Console.WriteLine("");
        Console.Clear();
    }
}
