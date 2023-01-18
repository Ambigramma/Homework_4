// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.


int GetPow()
{
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Введите степень: ");
int B = int.Parse(Console.ReadLine());

int a_pow_b = 1;

for(int i=0; i<B; i++)
{
    a_pow_b*=A;
}

Console.WriteLine(a_pow_b);
return 0;
}

GetPow();