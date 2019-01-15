using System;

namespace BinarySearchConsoleApp {
	class Program {
		static void Main(string[] args) {
			//int valor = 0;
			int[] vetor = new int[] { 1, 0, 5, -2, -5, 7, 223, 125, 85, 10, 33, 23 };

			Console.WriteLine("\nVetor: [" + String.Join(",", vetor) + "]");
			Array.Sort(vetor);
			Console.WriteLine("\nVetor em ordem crescente: [" + String.Join(",", vetor) + "]");

			//Console.Write("\nDigite o valor que deseja buscar? ");
			//valor = int.Parse(Console.ReadLine());

			//int indice = FindBinaryDoWhile(vetor, valor);
			int[] indice = FindBinaryWithWhile(vetor, 223);

			if (indice[0] == -1) {
				Console.WriteLine($"\nValor não encontrado no vetor!");
			}
			else {
				Console.WriteLine($"\nValor encontrado na chave: {indice[0]} \n\nQuantidade de iterações: {indice[1]}");
			}
		}
		public static int[] GetTwoInt(int val1, int val2) {
			int[] retorno = new int[2];
			retorno[0] = val1;
			retorno[1] = val2;
			return retorno;
		}
		public static int[] FindBinaryWithWhile(int[] vet, int chave) {
			int inicio = 0;
			int fim = vet.Length - 1;
			bool valorEncontrado = false;
			int contador = 0;

			while ((inicio <= fim) && (!valorEncontrado)) {
				int meio = (inicio + fim) / 2;

				if (vet[meio] == chave) {
					valorEncontrado = true;
					//return meio;
					contador++;
					return GetTwoInt(meio, contador);
				}
				else if (vet[meio] > chave) {
					fim = meio - 1;
					contador++;
				}
				else {
					inicio = meio + 1;
					contador++;
				}
			}
			return GetTwoInt(-1, contador);
		}

		public static int FindBinaryDoWhile(int[] vet, int chave) {
			int inicio = 0;
			int fim = vet.Length - 1;
			do {
				int meio = (inicio + fim) / 2;

				if (vet[meio] == chave) {
					return meio;
				}
				else if (vet[meio] > chave) {
					fim = meio - 1;
				}
				else {
					inicio = meio + 1;
				}
			} while (inicio <= fim);
			return -1;
		}
	}
}
