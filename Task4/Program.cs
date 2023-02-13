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

                int up (int count)
                {
                    int N = number;
                    for (int i = 1; i < degree; i++)
                    {
                        N *= number;
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
