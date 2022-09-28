// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите необходимое кол-во цифр, после окончания, введите слово - stop");

int countPositivNumber = 0;
while(true)
{
    string answer = Console.ReadLine();
    if(answer == "stop")
    {
        break;
    }
    else
    {
        int Number = Convert.ToInt32(answer);
        if(Number > 0)
        {
            countPositivNumber++;
        }
    }
}
Console.WriteLine($"Колличество положительныхчисел = {countPositivNumber}");