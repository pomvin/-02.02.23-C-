//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


Console.Clear();

Console.Write("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine()!);

int a1 = N / 10000;
int b2 = ((N / 1000) - a1 * 10);
int c3 = ((N / 100) - a1 * 100 - b2 * 10);
int d4 = ((N / 10) - a1 * 1000 - b2 * 100 - c3 * 10);
int e5 = N % 10;

if (N < 100000 & N > 9999)
{
    if (a1 == e5 & b2 == d4)
    {
        Console.Write($"{N} палиндром");
    }

    else if (a1 != e5 || b2 != d4)
    {
        Console.Write($"{N} не палиндромом");
    }

}
else if (N > 10000 || N < 9999)
{
    Console.WriteLine("Вы ввели не пятизначное число ");
}

// Console.Clear();
// int num, r, sum = 0, t;
// Console.Write("Введите пятизначное число: ");
// num = int.Parse(Console.ReadLine()!);

// if (num >= 10000)
// {
//     for (t = num; num != 0; num = num / 10)
//     {
//         r = num % 10;
//         sum = sum * 10 + r;
//     }
//     if (t == sum)
//         Console.Write("{0} палиндром", t);
//     else
//         Console.Write("{0} не палиндромом", t);
// }
// else
// {
//     Console.Write("Вы ввели не пятизначное число: ");
//     num = int.Parse(Console.ReadLine()!);

//     for (t = num; num != 0; num = num / 10)
//     {
//         r = num % 10;
//         sum = sum * 10 + r;
//     }
//     if (t == sum)
//         Console.Write("{0} палиондром", t);
//     else
//         Console.Write("{0} не палиондром", t);
// }
