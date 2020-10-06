using System;
using System.Threading;

namespace snakegame
{
    class Program
    {
        static void Main(string[] args)
        {
            int state = 0; // állapot
            char head = '@';
            char apple = 'A';
            int plusz = 0;
            Random random = new Random();          
            int appleX = random.Next(1,80);
            int appleY = random.Next(1, 25);

            Console.CursorVisible = false;
            int x = Console.WindowWidth / 2;
            int y = Console.WindowHeight / 2;
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.Write(head);
            bool bentvan = true;
            
            ConsoleKeyInfo k = new ConsoleKeyInfo();
            

            do
            {
                if (Console.KeyAvailable)
                    k = Console.ReadKey(true);
                switch (k.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (state != 0) state--;
                        y--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (state != 0) state--; ;
                        y++;
                        break;
                    case ConsoleKey.LeftArrow:
                        x--;
                        break;
                    case ConsoleKey.RightArrow:
                        x++;
                        break;
                }

                if (k.Key == ConsoleKey.UpArrow)
                   
                {
                    //Console.Write("Most felfele megyek");
                    Thread.Sleep(100);
                }
                if (k.Key == ConsoleKey.DownArrow)
                {
                    //Console.Write("Most lefele megyek");
                    Thread.Sleep(100);
                }
                if (k.Key == ConsoleKey.LeftArrow)
                {
                   // Console.Write("Most balra megyek");
                    Thread.Sleep(100);
                }
                if (k.Key == ConsoleKey.RightArrow)
                {
                    /*Console.Write("Most jobbra megyek"); */
                    Thread.Sleep(100);
                }

               /* SetApplePosOnScreen(random, out appleX, out appleY);
                paintApple(appleX, appleY); */

                /* akt  irány  számítás*/

                 /* switch (state)
                {
                    case 0: // fel
                        if (y > 0) y--;
                        break;              
                           case 1: //jobbra fel
                               y--; x++;
                               break;
                           case 2: //jobbra
                               x++;
                               break;
                           case 3: //jobbra le
                               x++; y++;
                               break;
                           case 4: // le
                               y++;
                               break;
                           case 5: //balra le
                               y++; x--;
                               break;
                           case 6: //bal
                               x--;
                               break;
                           case 7: //balra fel
                               x--; y--;
                               break;
                       } */
                        Console.Clear();
            

                if (x== appleX && y== appleY)
                {

                    appleX = random.Next(8, 71);
                    appleY = random.Next(9, 23);
                    plusz++;
                }



                Console.SetCursorPosition(appleX, appleY);
                Console.Write(apple);



                try
                {
                    Console.SetCursorPosition(x, y);
                }
                catch (ArgumentOutOfRangeException aute)
                {
                    if (y < 0) y = 0;
                    if (x < 0) x = 0;
                    if (y > 24) y = 24;
                    if (x > 79) x = 79;
                    Console.WriteLine(aute.Message + "GAME OVER");
                    bentvan = false;
                }

            

                catch (AppDomainUnloadedException)
                {
                    if (y < 0) y = 0;
                    if (x < 0) x = 0;
                    if (y > 24) y = 24;
                    if (x > 79) x = 79;
                }
                finally { /* mindenkép lefut! */}
                Console.Write(head);
                Thread.Sleep(0);
            } while (k.Key != ConsoleKey.Escape && bentvan);
            Console.Clear();

            int w = Console.WindowWidth / 2;
            int h = Console.WindowHeight / 2;
            string ki = "GAME OVER";
            Console.SetCursorPosition(w - ki.Length / 2, h/2);
            Console.Write(ki);
            Console.ReadLine();



            //



        }

       /* private static void paintApple(int appleX, int appleY)
        {
            Console.SetCursorPosition(appleX, appleY);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(food);
        } */

        /* private static void SetApplePosOnScreen(Random random, out int appleX, out int appleY)
        {
            appleX = random.Next(0 + 2, 70 - 2);
            appleY = random.Next(0 + 2, 40 - 2); 
        } */
    }
}