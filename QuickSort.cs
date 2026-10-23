using System;

namespace AlgoritmosOrdenacao
{
    class QuickSortProfessor
    {
        // Função do QuickSort exatamente como estruturada nos slides das aulas do professor
        static void QuickSort(int[] array, int esq, int dir)
        {
            int i = esq;
            int j = dir;
            
            // O professor define o pivô no meio do array
            int pivo = array[(esq + dir) / 2];

            while (i <= j)
            {
                // Percorre o array a partir da esquerda
                while (array[i] < pivo)
                {
                    i++;
                }
                
                // Percorre o array a partir da direita
                while (array[j] > pivo)
                {
                    j--;
                }
                
                // Realiza a troca (swap)
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    
                    i++;
                    j--;
                }
            }

            // Chamadas recursivas para a esquerda e para a direita
            if (esq < j)
            {
                QuickSort(array, esq, j);
            }
            
            if (i < dir)
            {
                QuickSort(array, i, dir);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Testes do QuickSort (Lógica do Professor) ===");

            // Exercício oficial do slide 118
            int[] exercicioSlide = { 12, 4, 8, 2, 14, 17, 6, 18, 10, 16, 15, 5, 13, 9, 1, 11, 7, 3 };
            
            Console.WriteLine("\n[Exercício Slide 118]");
            Console.WriteLine("Original : " + string.Join(", ", exercicioSlide));
            
            QuickSort(exercicioSlide, 0, exercicioSlide.Length - 1);
            
            Console.WriteLine("Ordenado : " + string.Join(", ", exercicioSlide));
            Console.WriteLine(new string('-', 30));

            // Cenário: "Triângulo" (Pior caso listado no slide 114 para a escolha do pivô no meio)
            int[] arrTriangulo = { 0, 1, 2, 3, 4, 5, 6, 5, 4, 3, 2, 1, 0 };
            
            Console.WriteLine("\n[Array Triângulo - Pior Caso Pivô no Meio]");
            Console.WriteLine("Original : " + string.Join(", ", arrTriangulo));
            
            QuickSort(arrTriangulo, 0, arrTriangulo.Length - 1);
            
            Console.WriteLine("Ordenado : " + string.Join(", ", arrTriangulo));
        }
    }
}