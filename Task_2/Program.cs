// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.WriteLine("Введите число");
bool check = false;
int number = 0;
int count = 0;
while (check == false)
{
    string text = Console.ReadLine();
    if (int.TryParse(text, out number))
    {
        // while (number != 0)
        // {
        //     number = number / 10;
        //     count++;
        // }
        for (int i = 0; number > 0; i++)
        {
            number = number / 10;
            count++;
        } 
         break;      
       
    }
    else
    {
        Console.WriteLine("Не удалось распознать число, поробуйте ещё раз");
    }
}
Console.WriteLine(count);