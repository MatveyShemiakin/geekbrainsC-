//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

internal partial class Program
{
    private static void Main(string[] args)
    {
        int x = (int)(Math.random() * 1000);
        int firstDigit = x / 100;
        int thirdDigit = x % 10;
        Console.WriteLine(firstDigit + "" + thirdDigit);
    }
};