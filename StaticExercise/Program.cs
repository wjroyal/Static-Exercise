namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelsius(32);
            Console.WriteLine($"32 degrees Farenheit is {celcius} degrees celcius");

            var farenheit = TempConverter.CelsiusToFahrenheit(17);
            Console.WriteLine($"17 degrees celcius is {farenheit} degrees fahrenheit");




        }
    }
}
