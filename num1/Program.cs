/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int m = Convert.ToInt32(Console.ReadLine());
int count = 0;

for (int i = 0; i < m; i++)
{
    int input = Convert.ToInt32(Console.ReadLine());
    if (input > 0)
    {
        count += 1;
    }
}

Console.WriteLine($"Количество чисел больше 0: {count}");