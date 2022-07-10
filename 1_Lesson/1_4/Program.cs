Console.Write("Write a number N: ");
int n = int.Parse(Console.ReadLine());

int i = 0;
int j = 0;

if (n > 0)
{
    i = -n;
}
else
{
    i = n;
    n = -n;
}

while (i <= n)
{
    Console.WriteLine(i);
    i++;
}


