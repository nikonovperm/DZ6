/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

Console.Write("Введите количество вводимых чисел М: ");
int amountOfNumbers = Convert.ToInt32(Console.ReadLine());

//int[] arrayOfInputNumbers = new int [amountOfNumbers];
int countOfPositive = 0;
int inputNumber;

for (int i = 0; i < amountOfNumbers; i++)
{
    Console.WriteLine($"Введите {i+1} число: ");
    //arrayOfInputNumbers[i] = Convert.ToInt32(Console.ReadLine());
    inputNumber = Convert.ToInt32(Console.ReadLine());
    if (inputNumber > 0)
    {
        countOfPositive++;
    }
}

Console.WriteLine($"Количество введёных чисел больше 0: {countOfPositive}");
