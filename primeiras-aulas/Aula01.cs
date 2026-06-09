using System;

namespace PrimeirasAulas
{
	class Aula01
	{
		static void Main(string[] args)
		{
			// Basic C# examples
			Console.WriteLine("Olá! Bem-vindo às primeiras aulas de C#.");

			// Variables
			int idade = 20;
			double altura = 1.75;
			string nome = "Aluno";
			bool maiorIdade = idade >= 18;

			Console.WriteLine($"Nome: {nome}, Idade: {idade}, Altura: {altura}m, Maior de idade: {maiorIdade}");

			// Conditional
			if (maiorIdade)
			{
				Console.WriteLine("Você é maior de idade.");
			}
			else
			{
				Console.WriteLine("Você é menor de idade.");
			}

			// Loop
			Console.WriteLine("Números de 1 a 5:");
			for (int i = 1; i <= 5; i++)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();

			// Method call
			int soma = Somar(3, 4);
			Console.WriteLine($"3 + 4 = {soma}");

			Console.WriteLine("Pressione qualquer tecla para sair...");
			Console.ReadKey();
		}

		static int Somar(int a, int b)
		{
			return a + b;
		}
	}
}
