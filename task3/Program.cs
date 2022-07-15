// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void FindDayofWeek (int numb)

{
if (numb <= 5)
{
    Console.WriteLine ("this day is weekday");
}


if (numb ==6 || numb == 7)
{
Console.WriteLine ("this day is weekend");

}

}

Console.WriteLine ("input numb");

int numb1 = Convert.ToInt32 (Console.ReadLine());
FindDayofWeek ( numb1);