// 

System.Console.WriteLine("Введите число");

int.TryParse(Console.ReadLine(), out int a);

int b = 1;

while(b <= a)
{
    System.Console.WriteLine(Math.Pow(b, 2));
    b++;
}
