// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void SecondDig (int number)

{

int twodigital = number/10;
int result = twodigital %10;

Console.WriteLine ("SecondDig" + result);
}

Console.WriteLine("input number:");

int number1 = Convert.ToInt32(Console.ReadLine());

SecondDig(number1);
