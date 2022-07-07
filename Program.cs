// найти кубы чисел от 1 до N
Console.WriteLine("введите число ");
int a= int.Parse(Console.ReadLine());
 for (int i=1; i<=a; i++)
 {
    Console.WriteLine($"{i}x{i}x{i}={i*i*i}");
 }