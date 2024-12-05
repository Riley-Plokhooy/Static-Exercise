namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(54);
            Console.WriteLine($"54 Fahrenheit is {Math.Round (celsius, 2)} degrees celsius");
            var fahrenheit = TempConverter.CelsiutToFahrenheit(celsius);
            Console.WriteLine("");
            Console.WriteLine($"It is {fahrenheit} converted back");
        }
    }
}
