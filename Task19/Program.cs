//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


Console.Clear();
int num, r, sum = 0, t;
Console.Write("Введите пятизначное число: ");
num = int.Parse(Console.ReadLine()!);

if (num >= 10000)
{
    for (t = num; num != 0; num = num / 10)
    {
        r = num % 10;
        sum = sum * 10 + r;
    }
    if (t == sum)
        Console.Write("{0} палиндром", t);
    else
        Console.Write("{0} не палиндромом", t);
}
else
{
    Console.Write("Вы ввели не пятизначное число: ");
    num = int.Parse(Console.ReadLine()!);

    for (t = num; num != 0; num = num / 10)
    {
        r = num % 10;
        sum = sum * 10 + r;
    }
    if (t == sum)
        Console.Write("{0} полиондром", t);
    else
        Console.Write("{0} не полиондром", t);
}