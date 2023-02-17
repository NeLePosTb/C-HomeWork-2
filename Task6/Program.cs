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
            // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

             int length = ReadInt("количество чисел: ");
             int[] array = createArray(length);
             printArray(array);
             Console.WriteLine($"Количество положительных числе = {positiveNumber(array)}");
 
             int ReadInt(string argument)
             {
                 Console.Write(argument);
                 string value = Console.ReadLine();
                 int result = Convert.ToInt32(value);
 
                 return result;

             }

             int[] createArray(int length)
             {
                 int[] result = new int[length];
 
                 for (int i = 0; i < result.Length; i++)
                 {
                     result[i] = ReadInt($"Введите {i + 1} число: ");
                 }
 
                 return result;
 
             }
 
             void printArray(int[] array)
             {
                 for (int i = 0; i < array.Length; i++)
                 {
                     Console.WriteLine(array[i]);
                 }
             }
 
             int positiveNumber(int[] array)
             {
                 int count = 0;
                 for (int i = 0; i < array.Length; i++)
                 {
                     if (array[i] > 0)
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
                //Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2
                
                System.Console.WriteLine("Введите аргументы первой прямой: ");
                int k1 = ReadInt("первый аргумент = ");
                int b1 = ReadInt("второй аргумент = ");

                System.Console.WriteLine("Введите аргументы второй прямой: ");
                int k2 = ReadInt("первый аргумент = ");
                int b2 = ReadInt("второй аргумент = ");

                int x = (b2 - b1) / (k1 - k2);

                foundCoordinates(x);

                int ReadInt(string argument)
                {
                    Console.Write(argument);
                    int result = 0;

                    while (!int.TryParse(Console.ReadLine(), out result))
                    {
                        Console.WriteLine("Try again");
                    }
                    return result;
                }
                
                void foundCoordinates(int X)
                {
                    X = (b2 - b1) / (k1 - k2);
                    int Y = k2 * X + b2;

                    Console.WriteLine($"кординаты пересечения прямых: [{X},{Y}]");
                }

                break;
             }

        

             case 0: isWork =false; break; 
        }
    }   
}