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

            case 0:
            {
                isWork = false; break;
            }
        }
    }
}
