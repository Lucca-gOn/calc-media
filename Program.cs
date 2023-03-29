//Programa que receba 5 notas de um aluno e calcule a média aritmética.
Console.WriteLine($"Seja bem vindo, irei calcular a média aritmética de 5 notas sua.");

Console.Write($"Digite sua primeira nota:");
float nota1 = float.Parse(Console.ReadLine());

Console.Write($"Digite sua segunda nota:");
float nota2 = float.Parse(Console.ReadLine());

Console.Write($"Digite sua terceira nota:");
float nota3 = float.Parse(Console.ReadLine());

Console.Write($"Digite sua quarta nota:");
float nota4 = float.Parse(Console.ReadLine());

Console.Write($"Digite sua quinta nota:");
float nota5 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2 + nota3 + nota4 + nota5)/5;

Console.WriteLine($"Parabéns! A média das suas notas são: {media}");


