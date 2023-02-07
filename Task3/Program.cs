bool isWork = true;

while (isWork)
{
    Console.Write("Введите номер задания: ");

    if (int.TryParse(Console.ReadLine(), out int i))
    {
        switch(i)
        {
            case 1:
            {
                //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

               
                Console.Write($"Введите пятизначное число: ");
                int a =int.Parse(Console.ReadLine());
                string argument = a.ToString();
                    
                if(argument.Length == 5)
                {
                    if (argument[0] == argument[argument.Length - 1] & argument[1] == argument[argument.Length -2])
                    {
                        Console.WriteLine($"{argument} - является палиндромом");
                    } else 
                    {
                        Console.WriteLine($"{argument} - не является палиндромом");
                    }
                } else 
                {
                    Console.WriteLine("Вы ввели не пятизначное число");
                }

                break;
            }

            case 2:
            {
                //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

                Console.WriteLine("введите координаты первой точки: ");
                System.Console.Write("X = ");
                int.TryParse(Console.ReadLine(), out int x1);
                System.Console.Write("Y = ");
                int.TryParse(Console.ReadLine(), out int y1);
                System.Console.Write("Z = ");
                int.TryParse(Console.ReadLine(), out int z1);
                Console.WriteLine("введите координаты второй точки: ");
                System.Console.Write("X = ");
                int.TryParse(Console.ReadLine(), out int x2);
                System.Console.Write("Y = ");
                int.TryParse(Console.ReadLine(), out int y2);
                System.Console.Write("Z = ");
                int.TryParse(Console.ReadLine(), out int z2);

                double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
                Console.Write("Дистанция = ");
                System.Console.WriteLine(Math.Round(distance, 3));
                


                break;
            }

            case 3:
            {
                //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

                System.Console.Write("Введите число: ");
                int number =int.Parse(Console.ReadLine());

                
                break;
            }

            case 0: isWork = false; break;
        }
    }
}