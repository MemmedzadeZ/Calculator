using System;

namespace Calculator
{
    internal class Program
    {


        static void Main()
        {
            int choice = 1;
            bool isCheak = true;

            while (isCheak)
            {
                Console.Clear();

                //Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Menu");
                Console.WriteLine(choice == 1 ? "> " : "  " + "+  ");
                Console.WriteLine(choice == 2 ? "> " : "  " + "-  ");
                Console.WriteLine(choice == 3 ? "> " : "  " + "*  ");
                Console.WriteLine(choice == 4 ? "> " : "  " + "/  ");
                Console.WriteLine(choice == 5 ? "> " : "  " + "Exit  ");



                ConsoleKeyInfo temp = Console.ReadKey();


                switch (temp.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (choice > 1)
                            choice--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (choice < 5)
                            choice++;
                        break;

                    case ConsoleKey.Enter:

                        isCheak = Secimiisle(choice);

                        break;
                }


            }

        }
        static bool Secimiisle(int secim)
        {
            Console.Clear();
            double num1, num2, cvb = 0;

           Console.WriteLine("Enter the num1: ");
           num1 = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("Enter the num2: ");
           num2 = Convert.ToDouble(Console.ReadLine());


            switch (secim)
            {
                case 1:
                    
                  
                    Console.Clear();
                    cvb = num1 + num2;
                     Console.WriteLine($"Cavab: {cvb}");
                    Console.ReadKey();
                    return true;
              
                case 2:
                    Console.Clear();
                  
                    Console.Clear();
                    cvb = num1 - num2;
                    Console.WriteLine($"Cavab: {cvb}");
                    Console.ReadKey();
                    return true; 
                                 
                case 3:

                    Console.Clear();
                  
                    cvb = num1 * num2;
                    Console.WriteLine($"Cavab: {cvb}");
                    Console.ReadKey();
                    return true; 
                                
                case 4:
                    
                    Console.Clear();
                 
                   if (num2 != 0)
                   {
                        cvb = num1 / num2;
                         Console.WriteLine($"Cavab: {cvb}");
                   }
                   else Console.WriteLine("0 bolme emeliyyati movcut deyil");
                    Console.ReadKey();
                    return true; 
                                
                case 5:
                    Console.Clear();

                  
                    return false;
                    break;
                default:
                    return true; 
            }
        }
    }


}

