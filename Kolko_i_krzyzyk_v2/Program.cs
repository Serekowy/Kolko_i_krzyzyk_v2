using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Kolko_i_krzyzyk_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ver = "0.0.2";

            Console.Title = $"Kółko i krzyżyk by Adiks, wersja {ver}";

            while (true)
            {
                Class1.Menu();

                char select = Console.ReadKey().KeyChar;

                Console.Clear();

                switch (select)
                {
                    case '1':
                        Console.WriteLine("Ustalcie kto gra jako kółko, a kto jako krzyżyk. ");
                        Console.WriteLine("Kolejność zostanie wybrana losowo. ");
                        Console.WriteLine("Po podjęciu decyzji proszę wcisnąć dowolny przycisk.");
                        Console.ReadKey();
                        Console.Clear();

                        Random random = new Random();

                        int order = random.Next(1, 3);

                        char player = 'X';

                        if (order == 1)
                        {
                            player = 'O';
                        }

                        bool game = true;

                        Class2.FillBoard();

                        while (game)
                        {
                            Console.WriteLine("Teraz kolej: {0}", player);

                            Class1.DisplayBoard();

                            Console.WriteLine("Wybierz numer w które pole chcesz wstawić swój znak.");
                            Console.Write("Wybór: ");

                            char readKey = Console.ReadKey().KeyChar;
                            int selected = readKey - '0';

                            if (readKey < 49 || readKey > 57)
                            {
                                Console.Clear();
                                Console.WriteLine("Błędny wybór, pole musi być liczbą od 1 do 9");
                                continue;
                            }

                            if (Class2.Tab[selected] == readKey)
                            {
                                Class2.Tab[selected] = player;

                                bool result = Class2.CheckWin(player);

                                if (result == true)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Gracz {0} wygrywa!", player);
                                    Class1.DisplayBoard();
                                    Console.WriteLine("Aby wrócić do menu naciśnij dowolny przycisk.");

                                    Console.ReadKey();
                                    game = false;
                                }

                                bool draw = Class2.CheckDraw();
                                
                                if (draw == true && game == true)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Remis! Koniec gry, nikt nie wygrywa.");
                                    Class1.DisplayBoard();
                                    Console.WriteLine("Aby wrócić do menu naciśnij dowolny przycisk.");

                                    Console.ReadKey();
                                    game = false;
                                }

                                player = Class2.ChangePlayer(player);
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("To pole jest już zajęte, wybierz inne.");
                                Console.WriteLine("Kliknij dowolny przycisk, aby kontynuować...");
                                Console.ReadKey();
                            }

                            Console.Clear();
                        }

                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Błędny wybór, wybierz numer który jest w menu.");
                        Console.WriteLine("Kliknij dowolny przycisk, aby kontynuować...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
