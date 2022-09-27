using System;

namespace impHeap
{
    class Program
    {
        static void Main (string[] args)
        {
            int[] lista = new int[]{0, 11, 3, 1, 4, 5, 6, 7, 10, 9, 8, 7};
            Heap h = new Heap(lista, false);
            imprimirLista(h.getDato);
        }
        static void imprimirLista(int[] lista)
        {
            for (int i = 0; i<lista.Length; i++)
            {
                Console.Write(lista[i] + " ");
            }
            Console.WriteLine("");
        }
    }
}