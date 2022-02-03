//Task8: Показать чётные числа от 1 до N.

int N = 27;

for (int i = 2; i <= N; i = i + 2)
{
    if (i % 2 == 0)
    Console.WriteLine(i);    
}