using System;
namespace practos
{
    class Program
    {
        
        static void Main()
        {

            int choice;
            string di = "-----------";
            int number2, nb;

            do
            {
                Console.WriteLine("Выберите программу, которую хотите запустить:");
                Console.WriteLine("1. Угадай число");
                Console.WriteLine("2. Таблица умножения");
                Console.WriteLine("3. Вывод делителей");
                Console.WriteLine("4. Выход из программы");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine(di);
                    Console.WriteLine("Ёу ёУ эб, нужно ввести число от 1 до 4");
                    Console.WriteLine(di);
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        
                        Random rnd = new Random();
                        int number1 = rnd.Next(0, 100);
                        Console.WriteLine("Угадайте число от 0 до 100 ");

                        do
                        {
                            Console.WriteLine("Введите число: ");
                            if (!int.TryParse(Console.ReadLine(), out number2))
                            {
                                Console.WriteLine(di);
                                Console.WriteLine("Ёу ёУ эб, нужно ввести число .");
                                Console.WriteLine(di);
                                continue;
                            }
                            if (number1 > number2)
                            {
                                Console.WriteLine(di);
                                Console.WriteLine("нужно больше");
                                Console.WriteLine(di);
                            }
                            else
                            {
                                Console.WriteLine(di);
                                Console.WriteLine("нужно меньше");
                                Console.WriteLine(di);
                            }


                        } while (number1 != number2);
                        Console.WriteLine(di);

                        Console.WriteLine("вы угадали!!! поздравляю.");
                        Console.WriteLine(di);

                        
                        break;


                    case 2:
                        Console.WriteLine(di);
                        Console.WriteLine("Пожалуйста, вот ваша таблица умножения");
                        Console.WriteLine(di);
                        
                        int n = 10; 
                        int[,] multiplicationTable = new int[n, n];

              
                        for (int i = 1; i <= n; i++)
                        {
                            for (int j = 1; j <= n; j++)
                            {
                                multiplicationTable[i - 1, j - 1] = i * j;
                            }
                        }

                
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                Console.Write($"{multiplicationTable[i, j]}\t");
                            }
                            Console.WriteLine();
                        }

                        break;
                    case 3:
                        Console.WriteLine("Раз вы выбрали вывод делителей, ну тогда получайте вывод делителей");
                        Console.WriteLine("Если захотите выйти введите 'выход' ");
                        do
                        {
                            Console.WriteLine("Введите число : ");
                            string input = Console.ReadLine();

                            if (input.ToLower() == "выход")
                            {
                                break; 
                            }

                            if (!int.TryParse(input, out nb))
                            {
                                Console.WriteLine("Ёу ёУ эб, нужно ввести число или 'выход'");
                                continue;
                            }

                            Console.WriteLine($"Делители числа {nb}:");
                            for (int i = 1; i <= nb; i++)
                            {
                                if (nb % i == 0)
                                {
                                    Console.WriteLine(i);
                                }
                            }

                        } while (true); 
                        break; 



                }
            } while (choice != 4);



        }
    }

}

