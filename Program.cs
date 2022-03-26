double primeiroNumero, segundoNumero, terceiroNumero, media;
Console.WriteLine(" media aritimedica de 3 numeros");

Console.Write("digite o primeiro numero: ");
primeiroNumero=Convert.ToDouble(Console.ReadLine());

Console.Write("digite o segundo numero: ");
segundoNumero=Convert.ToDouble(Console.ReadLine());

Console.Write("digite o terceiro numero: ");
terceiroNumero=Convert.ToDouble(Console.ReadLine());

media=(primeiroNumero + segundoNumero + terceiroNumero) /3;

Console.WriteLine($"\nMédia: {media:N1}");