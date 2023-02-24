//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
uint oddNumberCount = 0;
uint evenNumberCount = 0;
int oddNumberSum = 0;
int evenNumberSum = 0;

Console.WriteLine("Введите первое число диапазона");
int currentValue = int.Parse(Console.ReadLine());

Console.WriteLine("Введите последнее число диапазона");
int limit = int.Parse(Console.ReadLine());

while(currentValue <= limit)
{
    if(currentValue % 2 == 0)
    {evenNumberCount++;
     evenNumberSum += currentValue;
    }
    
    else {
        oddNumberSum= oddNumberSum + currentValue;
        oddNumberCount++;}
    currentValue++;
}
Console.WriteLine("Колическтво нечётных чисел" + oddNumberCount);
Console.WriteLine("Колическтво чётных чисел" + evenNumberCount);
Console.WriteLine("Сумма  чётных чисел" + evenNumberSum);
Console.WriteLine("Сумма нечётных чисел" + oddNumberSum);

 
