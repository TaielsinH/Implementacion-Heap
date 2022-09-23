using System;
using System.Collections.Generic;

namespace impHeap
{
	public class ArbolGeneral<T>
	{
		
		private T dato;
		private List<ArbolGeneral<T>> hijos = new List<ArbolGeneral<T>>();

		public ArbolGeneral(T dato) {
			this.dato = dato;
		}
	
		public T getDatoRaiz() {
			return this.dato;
		}
	
		public List<ArbolGeneral<T>> getHijos() {
			return hijos;
		}
	
		public void agregarHijo(ArbolGeneral<T> hijo) {
			this.getHijos().Add(hijo);
		}
	
		public void eliminarHijo(ArbolGeneral<T> hijo) {
			this.getHijos().Remove(hijo);
		}
	
		public bool esHoja() {
			return this.getHijos().Count == 0;
		}
	
		public int altura() {
			int cont = 0;
			if (esHoja()){
				return 0;
			}
			else
				cont++;
			for (int i = 0; i < this.getHijos().Count; i++)
			{
				int subCont = this.getHijos()[i].altura();
				cont += subCont;
			}
			return cont;
		}
	
		
		public int nivel(T dato) {
			return 0;
		}
	
	}

}