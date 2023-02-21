// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число");
bool check = false;
int number = 0;
int count = 1;
while (check == false)
{
    string text = Console.ReadLine();
    if (int.TryParse(text, out number))
    {
        for (int i = 0; i < number; i++)
        {
            number = number / 10;
            count++;
        }
        break;
        check = true;
    }
    else
    {
        Console.WriteLine("Не удалось распознать число, поробуйте ещё раз");
    }
}
Console.WriteLine(count);