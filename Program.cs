Console.WriteLine("Введите число");
long a = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Введите число");
long b = Convert.ToInt64(Console.ReadLine());
string c;
Console.WriteLine("Введите знак");
c = Console.ReadLine();
if (b == 0 && c == "/")
{
    Console.WriteLine("Деление на ноль невозможно");
}
else
{
    switch (c)
    {
        case "+":
            Console.Write(a + " " + c + " " + b + " " + "=" + " " + (a + b));
            break;
        case "-":
            Console.Write(a + " " + c + " " + b + " " + "=" + " " + (a - b));
            break;
        case "*":
            Console.Write(a + " " + c + " " + b + " " + "=" + " " + (a * b));
            break;
        case "/":
            Console.Write(a + " " + c + " " + b + " " + "=" + " " + (a / b));
            break;
        default:
            Console.WriteLine("ОШИБКА Доступно только + - * /");
            break;
    }
  
}
Console.ReadKey();