// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
int max   = 7;

if (day <= 0 || day > max )
{
    Console.WriteLine("Такого дня недели не существует");
}
else if (day <= 5)
{
    Console.WriteLine("Этот день будний");
}   
else
{
    Console.WriteLine("Этот день выходной");
}
    Console.WriteLine();