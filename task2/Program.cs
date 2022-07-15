// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void FindDigit (string numb)
{
    if (numb.Length >= 3)
    {
       char thirdChar = numb [2];
       Console.WriteLine("Third digital " + thirdChar);
    }
    
    else
    {
        if (numb.Length == 2 || numb.Length ==1)
        {
            Console.WriteLine("This numb has not third digital");
        }
    }
    
}

string numb;
Console.Write("Input your numb: ");
numb = Console.ReadLine();
FindDigit (numb);
