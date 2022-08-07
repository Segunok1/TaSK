int a = 2;
Console.WriteLine(a);
int b = 3;
Console.WriteLine(b);
int c = 7;
Console.WriteLine(c);

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);
