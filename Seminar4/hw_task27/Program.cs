// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int number = ReadNumber("Введите число");
int result = SumDigitals(number);
int SumDigitals(int num)
{
    int res = 0;
    while(num != 0)
    {
        res = res + (number % 10);
        num = number / 10;
    }
    return res;
}
Console.WriteLine(result);