// Напишите программу, которая принимает на вход число 
// и выдает количество цифр в числе.


Console.WriteLine("Введите число");
int num= Convert.ToInt32(Console.ReadLine());
int countDigit = CountDigit(num);
Console.WriteLine($"В числе {num} сожержится {countDigit} цифр");

int CountDigit (int number)
{
    int quantityDigit = 0;
    do
    {
        number/=10;
        quantityDigit++;
    }
         while(number!=0);
        return quantityDigit;
    
}