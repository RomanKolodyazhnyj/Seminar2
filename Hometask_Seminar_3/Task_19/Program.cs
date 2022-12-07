// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int number1 = (number / 10000) % 10;
int number2 = (number / 1000) % 10;
int number4 = (number / 10) % 10;
int number5 = number % 10;

if (number > 9999 && number < 100000)
{
    if (number1 == number5 && number2 == number4)
    {
        Console.WriteLine("Да, число является палиндромом");
    }
    else
    {
        Console.WriteLine("Нет, число не является палиндромом");
    }
}
else
{
    Console.WriteLine("Введите пятизначное число");
}