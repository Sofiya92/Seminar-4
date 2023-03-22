// Напишите программу, которая принимает на вход число N 
// и выдает произведение чисел от 1 до N.


Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
int factorial = Factorial(number);
Console.WriteLine($"Произведение всех чисел от 1 до N = {factorial}");

int Factorial(int num)
{
    int result = 1;
    for (int i=1; i <= num; i++)
    {
       result = result*i;
    }
    return result;
}
