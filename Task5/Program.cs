bool isWork = true;

while(isWork)
{
    Console.Write("Введите номер задания: ");

    if (int.TryParse(Console.ReadLine(), out int task))
    {
        switch(task)
        {
            case 1:
            {
                //Задайте массив заполненный случайными положительными трёхзначными числами. 
                //Напишите программу, которая покажет количество чётных чисел в массиве.

                int[] array = createArray(8);
                Console.Write("В массиве: ");
                print(array);
                Console.WriteLine($" количество четных чисел - {evenNumber(array)}");
            

                int[] createArray(int length)
                {
                    int[] array = new int [length];
                    Random random = new Random();
                    for (int i = 0; i < length; i++)
                    {
                        array[i] = random.Next(100, 1000);
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
                    System.Console.Write("]");
                }

                int evenNumber (int[] array)
                {
                   int count = 0;

                   for (int i = 0; i < array.Length; i++)
                   {
                     if (array[i] % 2 == 0)
                     {
                        count++;
                     }
                   }

                   return count;
                }

                break;
            }

            case 2:
            {
                //Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

                int[] array = createArray(8);
                Console.Write("В массиве: ");
                print(array);
                Console.WriteLine($" сумма элементов на нечетных позициях - {sumNumber(array)}");

                int[] createArray(int length)
                {
                    int[] array = new int [length];
                    Random random = new Random();
                    for (int i = 0; i < length; i++)
                    {
                        array[i] = random.Next(0, 11);
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
                    System.Console.Write("]");
                }

                int sumNumber(int[] array)
                {
                    int sum = 0;

                    for (int i = 1; i < array.Length; i += 2)
                    {
                        sum += array[i];
                    }

                    return sum;
                }

                break;

            }

            case 3:
            {
                //Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

                int[] array = createArray(8);
                Console.Write("В массиве: ");
                print(array);
                Console.WriteLine($" разница между Max и Min элементов = {difference(array)}");

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
                    System.Console.Write("]");
                }

                int difference(int[] array)
                {
                    int Max = array[0];
                    int Min = array[0];

                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] < Min)
                        {
                            Min = array[i];
                        }
                        if (array[i] > Max)
                        {
                            Max = array[i];
                        }
                    }

                    int dif = Max - Min;
                    return dif;
                }

                break;
            }

            case 0: isWork = false; break;

        }
    }
}