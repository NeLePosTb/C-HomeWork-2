bool isWork = true;

while(isWork)
{
    Console.Write("Введите номер задания: ");

    if (int.TryParse(Console.ReadLine(), out int i))
    {
        switch(i)
        {
            case 1:
            {
                //Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
                System.Console.Write("Введите число: ");
                int number = int.Parse(Console.ReadLine());
                System.Console.Write("Введите cтепень: ");
                int degree = int.Parse(Console.ReadLine());

                Console.WriteLine($"Степень {degree} числа {number} = {up(number)}");

                int up (int N)
                {
                    N = number;
                    for (int i = 1; i < degree; i++)
                    {
                        N *= number;
                    } 
                    return N;
                }


                break;
            }

            case 2:
            {
                //Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

                System.Console.Write("Введите число: ");
                int number = int.Parse(Console.ReadLine());
                System.Console.WriteLine(sum(number));

                int sum (int N)
                {
                   N = 0;
                   while (number > 0)
                   {
                    N = N + number % 10;
                    number = number / 10;
                   }
                   return N;
                }


                break;
            }

            case 3:
            {
                //Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
                
                int[] array = createArray(8);
                print(array);
                

                int[] createArray(int length)
                {
            
                    int[] array = new int [length];
                    Random random = new Random();
                    for (int i = 0; i < length; i++)
                    {
                        array[i] = random.Next(0, 100);
                    }
                    return array;
                }

                void print (int[] array)
                {
                    System.Console.Write("[");
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        System.Console.Write($"{array[i]}, ");
                    }
                    System.Console.Write($"{array[array.Length - 1]}");
                    System.Console.WriteLine("]");
                }



                break;
            }

            case 0:
            {
                isWork = false; break;
            }
        }
    }
}
