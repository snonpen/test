// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

Console.Clear();
Console.WriteLine("This program generates numbers from N to 1.");
Console.WriteLine();
int endValue=1;
int numberN = EnterUserData("Enter the end number N:");
if (numberN < endValue)
{
    numberN = endValue;
}
Console.Write(SumFunction(endValue, numberN));
Console.WriteLine();

int SumFunction(int endValue, int numberN)
{
    if (endValue == numberN)
    {
        return endValue;
    }
    Console.Write(SumFunction(endValue + 1,numberN) + ", ");
    return endValue;
}

int EnterUserData(string nameUserData)
{
    Console.Write($"{nameUserData}");
    return Convert.ToInt32(Console.ReadLine());
}