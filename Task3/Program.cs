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

            case 0: isWork = false; break;
        }
    }
}