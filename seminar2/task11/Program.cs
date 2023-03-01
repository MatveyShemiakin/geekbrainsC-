// случайное число на отрезке;

int number = new Random().Next(10,100);

int firstDigit = number / 10;
int secondDigit = number % 10;

if (int FirstDigit > secondDigit)
{
    Console.WriteLine(secondDigit);
}
else
{
     Console.WriteLine(firstDigit);
}




