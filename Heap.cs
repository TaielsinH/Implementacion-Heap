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
            filtradoAbajo();
        }
        public int[] getDato
        {get{return dato;}}
        private void filtradoAbajo()
        {
            if(!this.tipoHeap){
                for (int i = 1; i< this.dato.Length /2; i++)
                {
                    if (this.dato[i] > this.dato[2*i])
                    {
                        int swap = this.dato[i];
                        this.dato[i] = this.dato[2*1];
                        this.dato[2*1] = swap;
                    }
                    if (this.dato[i] > this.dato[(2*i)+1])
                    {
                        int swap = this.dato[i];
                        this.dato[i] = this.dato[(2*i)+1];
                        this.dato[(2*i)+1] = swap;
                    }
                }
            }
            if(tipoHeap)
            {
                for (int i = 0; i<this.dato.Length /2; i++)
                {
                    if (this.dato[i]<this.dato[2*i])
                    {
                        int swap = this.dato[i];
                        this.dato[i] = this.dato[2*1];
                        this.dato[2*1] = swap;
                    }
                    if (this.dato[i] < this.dato[2*i])
                    {
                        int swap = this.dato[i];
                        this.dato[i] = this.dato[2*1];
                        this.dato[2*1] = swap;
                    }
                }
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