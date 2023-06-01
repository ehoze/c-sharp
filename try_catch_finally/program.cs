int x, y, result;

try
{
    Console.Write("Podaj numer pierwszy: ");
    x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Podaj numer drugi: ");
    y = Convert.ToInt32(Console.ReadLine());
    result = x / y;
    Console.WriteLine($"Wynik: {result}");
}
catch (FormatException ex)
{
    Console.WriteLine("Podaj jedynie liczby, inne znaki nie będą akceptowane!");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Nie można dzielić przez 0!");
}
catch (Exception ex)
{
    Console.WriteLine("Coś poszło nie tak...");
}
finally
{
    Console.WriteLine("Dzięki - test");
}
