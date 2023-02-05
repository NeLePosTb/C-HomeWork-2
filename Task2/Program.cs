bool isWork = true;

while(isWork)
{
    Console.Write("Введите номер задания ");

    if (int.TryParse(Console.ReadLine(), out int i))
    {
        switch(i)
        {
            case 1:
            {
                Console.Write("Введите трехзначное число ");

                int a = int.Parse(Console.ReadLine());
                int b = a / 10 % 10;
                System.Console.WriteLine(b);

                break;
            }

            case 2:
            {
                System.Console.Write("Введите число ");

                int a =int.Parse(Console.ReadLine());
                string s = a.ToString();

                if (s.Length >= 3)
                {
                    string result = s[2].ToString();
                    System.Console.WriteLine(result);
                } else System.Console.WriteLine("третьей цифры нет");
                
                break;
            }

            case 3:
            {
                System.Console.Write("Введите цифру дня недели ");

                int.TryParse(Console.ReadLine(), out int a);
                string day = "рабочий день";
                string holliday = "выходной день";

                if ( a == 1)
                {
                    System.Console.WriteLine(day);
                } else if (a == 2)
                {
                    System.Console.WriteLine(day);
                } else if ( a == 3)
                {
                    System.Console.WriteLine(day);
                } else if (a == 4)
                {
                    System.Console.WriteLine(day);
                } else if (a == 5)
                {
                    System.Console.WriteLine(day);
                } else if (a == 6)
                {
                    System.Console.WriteLine(holliday);
                } else if (a == 7)
                {
                    System.Console.WriteLine(holliday);
                } else System.Console.WriteLine("Число не соотвествует дню недели");
                
                break;
            }

            case 0: isWork = false; break;
        }
    }
}