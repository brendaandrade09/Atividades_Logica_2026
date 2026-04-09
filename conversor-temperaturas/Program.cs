//Feito por Brenda Lima Andrade
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Conversor de Celsius C° para Fahrenheit F° 😊😊" +
    "\n Digite o valor em °C: ");

float.TryParse(Console.ReadLine(), out float celsius);
float resultado = (celsius * 9 / 5) + 32;

Console.WriteLine($"A conversão de {celsius}° C é: {resultado}° F ✨");


Console.WriteLine("Conversor de Fahrenheit F° para Celsius C° 😊😊" +
    "\n Digite o valor em °F: ");

float.TryParse(Console.ReadLine(), out float fahrenheit);
float resultadoFahrenheit = (fahrenheit - 32) * 5 / 9;

Console.WriteLine($"A conversão de {fahrenheit}° F é: {resultadoFahrenheit}° C ✨");


Console.WriteLine("Conversor de Kelvin K para Celsius C° 😊😊" +
    "\n Digite o valor em K: ");

float.TryParse(Console.ReadLine(), out float kelvin);
float resultadoKelvin = (kelvin - 273.15f);

Console.WriteLine($"A conversão de {kelvin} K é: {resultadoKelvin}° C ✨");

Console.WriteLine("Conversor de Kelvin K para Fahrenheit F° 😊😊" +
    "\n Digite o valor em K: ");

float.TryParse(Console.ReadLine(), out float kelvin2);
float resultadoKelvin2 = (kelvin2 - 273.15f) * 9 / 5 + 32;

Console.WriteLine($"A conversão de {kelvin2} K é: {resultadoKelvin2}° F ✨");

