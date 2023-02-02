// Напишите программу, которая принимает на вход 
//число (N) и выдает таблицу кубов чисел 
//от 1 до N
// 3 -> 1,8,27
Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int count = 1;

while (count <= num)
{
    int sqr = count * count * count;
    Console.WriteLine($"{sqr}");
    count++;

}
