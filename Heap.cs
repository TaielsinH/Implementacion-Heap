using System;
using System.Collections;

namespace impHeap
{
    public class Heap
    {
        private int[] dato;
        private bool tipoHeap; //true si es maxHeap, false si es minHeap

        public Heap(int[]lista, bool tipoHeap)
        {
            dato = lista;
            this.tipoHeap = tipoHeap;
            buildHeap();
        }
        public int[] getDato
        {get{return dato;}}

        private void filtradoAbajo(int posicion)
        {
            if (!tipoHeap)
            {
                try
                {
                    if (dato[posicion] > dato[posicion * 2])
                    {
                        int swap = dato[posicion];
                        dato[posicion] = dato[posicion * 2];
                        dato[posicion * 2] = swap;
                        filtradoAbajo(posicion * 2);
                    }
                    if (dato[posicion] > dato[(posicion * 2) + 1])
                    {
                        int swap = dato[posicion];
                        dato[posicion] = dato[(posicion * 2) + 1];
                        dato[(posicion * 2) + 1] = swap;
                        filtradoAbajo((posicion * 2) + 1);
                    }
                }
                catch (System.IndexOutOfRangeException)
                {
                    return;
                }
            }
            else
            {
                try
                {
                    if (dato[posicion] > dato[posicion * 2])
                    {
                        int swap = dato[posicion];
                        dato[posicion] = dato[posicion * 2];
                        dato[posicion * 2] = swap;
                        filtradoAbajo(posicion * 2);
                    }
                    if (dato[posicion] > dato[(posicion * 2) + 1])
                    {
                        int swap = dato[posicion];
                        dato[posicion] = dato[(posicion * 2) + 1];
                        dato[(posicion * 2) + 1] = swap;
                        filtradoAbajo((posicion * 2) + 1);
                    }
                }
                catch (System.IndexOutOfRangeException)
                {
                    return;
                }
            }
        }
        private void buildHeap()
        {
            for (int i = dato.Length/2; i>0; i--)
            {
                filtradoAbajo(i); 
            }
        }
       private void filtradoArriba()
        {
            int n = dato.Length;
            if(!this.tipoHeap){
                for (int i = n; i< 1 /2; i--)
                {
                    if (this.dato[i] < this.dato[i/2])
                    {
                        int swap = this.dato[i];
                        this.dato[i] = this.dato[i/2];
                        this.dato[i/2] = swap;
                    }
                }
            }
            if(tipoHeap)
            {
                for (int i = n; i>1; i--)
                {
                    if (this.dato[i]>this.dato[i/2])
                    {
                        int swap = this.dato[i];
                        this.dato[i] = this.dato[i/2];
                        this.dato[i/2] = swap;
                    }
                }
            }
        }    

        
    }
}