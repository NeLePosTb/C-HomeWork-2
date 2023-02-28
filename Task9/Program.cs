bool isWork = true;

while(isWork)
{
    Console.Write("Введите номер задания: ");
    {
        if(int.TryParse(Console.ReadLine(), out int task))
        {
            switch(task)
            {
                case 1:
                {
                    //Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

                    int readInt(string argument)
                    {
                        Console.Write($"{argument}: ");
                        int result = 0;
                        while(!int.TryParse(Console.ReadLine(), out result))
                        {
                            Console.WriteLine("Errrror");
                        }

                        return result;
                    }

                    string numb(int n)
                    {
                        int count = 1;
                        if (count <= n) return $"{n} " + numb(n - count);
                        else return string.Empty;
                    }

                    int n = readInt("Enter number ");
                    Console.WriteLine(numb(n));

                    break;
                }

                case 2:
                {
                    //Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

                    int M = readInt("Enter min number: ");
                    int N = readInt("Enter max number: ");
                    Console.WriteLine(sumOfNumber(M, N));

                    int readInt(string argument)
                    {
                        Console.Write($"{argument}: ");
                        int result = 0;
                        while(!int.TryParse(Console.ReadLine(), out result))
                        {
                            Console.WriteLine("Errrror");
                        }

                        return result;
                    }


                    int sumOfNumber(int min, int max)
                    {
                        int sum = 0;
                        if(min <= max)
                        {
                            return sum += min + sumOfNumber(min + 1, max);
                        } else
                        {
                            Console.Write($"Cумма элементов между {M} и {max} = ");
                        }
                       
                       return sum;
                    }


                    break;
                }

                case 3:
                {
                    //Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

                    int m = readInt("Введите первое число: ");
                    int n = readInt("Введите второе число: ");

                    Console.WriteLine(functionAkkerman(m,n));
                    int readInt (string argument)
                    {
                        Console.Write($"{argument}: ");
                        int result = 0;
                        if(!int.TryParse(Console.ReadLine(), out result))
                        {
                            Console.WriteLine("Errror");
                        }
                        
                        return result;
                    }

                    int functionAkkerman(int numberOne, int numberTwo)
                    {
                        if(numberOne == 0)
                        {
                            return numberTwo + 1;
                        } else if((numberOne != 0) && (numberTwo == 0))
                        {
                            return functionAkkerman(numberOne - 1, 1);
                        } else return functionAkkerman(numberOne - 1, functionAkkerman(numberOne,numberTwo-1));
                    }

                    break;
                }

                case 0: isWork = false; break;
            }
        }
    }
}