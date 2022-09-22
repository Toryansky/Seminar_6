// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа через пробел: ");
int[] inputNumbers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

int count = 0;

for (int i = 0; i < inputNumbers.Length; i++)
{
    if (inputNumbers[i] > 0)
    {
        count += 1;
    }
}
Console.WriteLine($"Введено чисел больше нуля: {count} ");