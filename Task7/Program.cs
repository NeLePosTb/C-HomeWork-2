bool isWork = true;

while(isWork)
{
    Console.Write("Введите номер задания: ");

    if(int.TryParse(Console.ReadLine(), out int task))
    {
        switch(task)
        {

            case 1:
            {
                //Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

                int firstLength = ReadInt("First Length");
                int secondLength = ReadInt("Second Length");

                int[,] array = CreateTwoDimensionArray(firstLength, secondLength);

                Console.WriteLine(TwoDimensionArrayToString(array));

                int ReadInt (string argument)
                {
                    Console.WriteLine($"Введите размер массива: ");
                    int result = 0;

                    while (!int.TryParse(Console.ReadLine(), out result))
                    {
                        Console.WriteLine("Введите число");
                    }

                    return result;
                }

                int[,] CreateTwoDimensionArray(int firstLength, int secondLength)
                {
                    int[,] result = new int[firstLength, secondLength];

                    Random random = new Random();

                    for (int i = 0; i < result.GetLength(0); i++)
                    {
                        for (int j = 0; j < result.GetLength(1); j++)
                        {
                            result[i,j] = random.Next();
                        }
                    }
                    return result;
                }

                string TwoDimensionArrayToString(int[,] array)
                {
                    string result = string.Empty;

                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            result += $"{array[i, j]} ";
                        }

                        result += Environment.NewLine;
                    }
                    
                    return result;
                }

                break;
            }

            case 2:
            {
                //Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
                //и возвращает значение этого элемента или же указание, что такого элемента нет.
                int firstLength = 3;
                int secondLength = 4;
                int[,] array = CreateTwoDimensionArray(firstLength, secondLength);
                Console.WriteLine(TwoDimensionArrayToString(array));

                int firstIndex = ReadInt("First Index");
                int secondIndex = ReadInt("Second Index");

                Console.WriteLine(foundElement(array, firstIndex, secondIndex));


                int ReadInt (string argument)
                {
                    Console.Write($"Введите позицию элимента: ");
                    int result = 0;
                    while (!int.TryParse(Console.ReadLine(), out result))
                    {
                        Console.WriteLine("Введите число");
                    }
                    return result;
                }
                
                int[,] CreateTwoDimensionArray(int firstLength, int secondLength)
                {
                    int[,] result = new int[firstLength, secondLength];
                    Random random = new Random();

                    for (int i = 0; i < result.GetLength(0); i++)
                    {
                        for (int j = 0; j < result.GetLength(1); j++)
                        {
                            result[i,j] = random.Next(0, 11);
                        }
                    }
                    return result;
                }

                string TwoDimensionArrayToString(int[,] array)
                {
                    string result = string.Empty;
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            result += $"{array[i, j]} :({i},{j}) ";
                        }
                        result += Environment.NewLine;
                    }
                    return result;
                }

                int foundElement(int[,] array, int firstIndex, int secondIndex)
                {
                    if(firstIndex >= array.GetLength(0) || secondIndex >= array.GetLength(1))
                    {
                        System.Console.WriteLine("Error");
                    }

                    return array[firstIndex, secondIndex];
                }


                break;
            }

            case 3:
            {
                //Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

                int firstLength = 3;
                int secondLength = 4;
                int[,] array = CreateTwoDimensionArray(firstLength, secondLength);
                Console.WriteLine(TwoDimensionArrayToString(array));

                average(array);

                int[,] CreateTwoDimensionArray(int firstLength, int secondLength)
                {
                    int[,] result = new int[firstLength, secondLength];
                    Random random = new Random();

                    for (int i = 0; i < result.GetLength(0); i++)
                    {
                        for (int j = 0; j < result.GetLength(1); j++)
                        {
                            result[i,j] = random.Next(0, 11);
                        }
                    }
                    return result;
                }

                string TwoDimensionArrayToString(int[,] array)
                {
                    string result = string.Empty;
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            result += $"{array[i, j]} ";
                        }
                        result += Environment.NewLine;
                    }
                    return result;
                }

                void average (int[,] array)
                {
                    double sum = 0;

                    for (int i = 0; i < array.GetLength(1); i++)
                    {
                        for (int j = 0; j < array.GetLength(0); j++)
                        {
                            sum += array[j,i];    
                        }
                        Console.WriteLine(Math.Round(sum/firstLength, 2)); 
                        sum = 0; 
                    }
                }

                break;
            }

            case 0: isWork = false; break;
        }
    }
}