
Console.Write("Введите число А: ");
int limit = Convert.ToInt32(Console.ReadLine());
int GetSum(int A) // A = limit
{
    int sum = 0;
    for (int i = 1; i <= A; i++)
    {
        sum += i;   // sum = sum + i;
    }
    return sum;
}
Console.WriteLine($"Cумма чисел от 1 до {limit} = {GetSum(limit)}");

