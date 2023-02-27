bool isWork = true;

while(isWork)
{
    Console.Write("Введите номер задания: ");

    {
        if (int.TryParse(Console.ReadLine(), out int task))
        {
            switch(task)
            {
                case 1:
                {
                    //Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

                    int firstLength = 3;
                    int secondLength = 4;
                    int[,] array = CreateTwoDimensionArray(firstLength, secondLength);
                    Console.WriteLine(TwoDimensionArrayToString(array));
                    
                    Console.WriteLine(TwoDimensionArrayToString(order(array)));

                    int[,] CreateTwoDimensionArray(int firstLength, int secondLength)
                    {
                        int[,] result = new int[firstLength, secondLength];
                        Random random = new Random();

                        for (int i = 0; i < result.GetLength(0); i++)
                        {
                            for (int j = 0; j < result.GetLength(1); j++)
                            {
                                result[i,j] = random.Next(0, 10);
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

                    int[,] order(int[,] array)
                    {
                        
                        int[] temp = new int[array.GetLength(1)];

                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            for (int j = 0; j < array.GetLength(1); j++)
                            {
                               temp[j] = array[i,j];
                            }

                            Array.Sort(temp);
                            Array.Reverse(temp);

                            for (int j = 0; j < array.GetLength(1); j++)
                            {
                                array[i,j] = temp[j];
                            }
                        }
                        return array;
                    }

                    break;
                }

                case 2:
                {
                    //Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

                    int firstLength = 3;
                    int secondLength = 4;
                    int[,] array = CreateTwoDimensionArray(firstLength, secondLength);
                    Console.WriteLine(TwoDimensionArrayToString(array));
                    Console.WriteLine($"Строка {numberOfRow(array)} имеет наименьшую сумму");

                    int[,] CreateTwoDimensionArray(int firstLength, int secondLength)
                    {
                        int[,] result = new int[firstLength, secondLength];
                        Random random = new Random();

                        for (int i = 0; i < result.GetLength(0); i++)
                        {
                            for (int j = 0; j < result.GetLength(1); j++)
                            {
                                result[i,j] = random.Next(0, 10);
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


                    int numberOfRow (int[,] array)
                    {
                        int rowNumber = 0;
                        int rowMinSum = int.MaxValue;

                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            int rowSum = 0;
                            for (int j = 0; j < array.GetLength(1); j++)
                            {
                                rowSum += array[i,j];
                            }
                            
                            if(rowSum < rowMinSum)
                            {
                                rowNumber = i+1;
                                rowMinSum = rowSum;
                            }
                        }

                        return rowNumber;
                    }

                    break;
                }

                case 3:
                {
                    //Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

                    int firstLength = 3;
                    int secondLength = 3;
                    int[,] arrayOne = CreateTwoDimensionArray(firstLength,secondLength);
                    int[,] arrayTwo = CreateTwoDimensionArray(firstLength,secondLength);
                    Console.WriteLine(TwoDimensionArrayToString(arrayOne));
                    System.Console.WriteLine();
                    Console.WriteLine(TwoDimensionArrayToString(arrayTwo));

                    int[,] mArray = multyArray(arrayOne, arrayTwo);
                    Console.WriteLine(TwoDimensionArrayToString(mArray));

                    int[,] CreateTwoDimensionArray(int firstLength, int secondLength)
                    {
                        int[,] result = new int[firstLength, secondLength];
                        Random random = new Random();

                        for (int i = 0; i < result.GetLength(0); i++)
                        {
                            for (int j = 0; j < result.GetLength(1); j++)
                            {
                                result[i,j] = random.Next(0,10);
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

                    int[,] multyArray(int[,] arrayOne, int[,] arrayTwo)
                    {
                        int[,] result = new int[arrayOne.GetLength(0),arrayTwo.GetLength(1)];

                        for (int i = 0; i < result.GetLength(0); i++)
                        {
                            for (int j = 0; j < result.GetLength(1); j++)
                            {
                                for (int k = 0; k < arrayOne.GetLength(0); k++)
                                {
                                    result[i,j] += result[i,j] + (arrayOne[k,j] * arrayTwo[i,k]);
                                }
                            }
                        }

                        return result;
                    }

                    break;
                }

                case 4:
                {
                    //Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

                    int[,,] array = CreateThreeDimensionArray(2,2,2);
                    Console.WriteLine(ThreeDimensionArrayToString(array));


                    int[,,] CreateThreeDimensionArray(int firstLength, int secondLength, int thirdLength)
                    {
                        int[,,] result = new int[firstLength,secondLength,thirdLength];
                        Random random = new Random();
                        HashSet<int> number = new HashSet<int>();

                        for (int i = 0; i < result.GetLength(0); i++)
                        {
                            for (int j = 0; j < result.GetLength(1); j++)
                            {
                                for (int k = 0; k < result.GetLength(2); k++)
                                {
                                    result[i,j,k] = random.Next(10,100);

                                    while(number.Contains(result[i,j,k]))
                                    {
                                        result[i,j,k] = random.Next(10,100);
                                    }

                                    number.Add(result[i,j,k]);
                                }
                            }
                        }

                        return result;
                    }

                    string ThreeDimensionArrayToString(int[,,] array)
                    {
                        string result = string.Empty;

                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            for (int j = 0; j < array.GetLength(1); j++)
                            {
                                for (int k = 0; k < array.GetLength(2); k++)
                                {
                                    result += $"{array[i,j,k]}({i},{j},{k}) ";
                                }

                                result += Environment.NewLine;
                            }
                        }

                        return result;
                    }
                    break;
                }

                case 5:
                {
                    //Напишите программу, которая заполнит спирально массив 4 на 4.

                    int[,] array = new int[4, 4];
                    int rowStart = 0;
                    int rowEnd = array.GetLength(0) - 1;
                    int colStart = 0;
                    int colEnd = array.GetLength(1) - 1;
                    int num = 1;

                    while (rowStart <= rowEnd && colStart <= colEnd)
                    {
                        for (int i = colStart; i <= colEnd; i++)
                        {
                            array[rowStart, i] = num++;
                        }

                        for (int i = rowStart + 1; i <= rowEnd; i++)
                        {
                            array[i, colEnd] = num++;
                        }

                        if (rowStart < rowEnd && colStart < colEnd)
                        {
                            for (int i = colEnd - 1; i > colStart; i--)
                            {
                                array[rowEnd, i] = num++;
                            }

                            for (int i = rowEnd; i > rowStart; i--)
                            {
                                array[i, colStart] = num++;
                            }
                        }

                        rowStart++;
                        rowEnd--;
                        colStart++;
                        colEnd--;
                    }

                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            Console.Write(array[i, j].ToString("d2") + " ");
                        }

                        Console.WriteLine();
                    }

                    break;
                }

                case 0: isWork = false; break;
            }
        }
    }
}
