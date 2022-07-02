Console.WriteLine ("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int  j = 1;

while (Math.Abs(num) - j >= 0)
{
    Console.Write ($"{j*j},");
    j++;
}
Console.Write("\b \b");