using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDinamicas.ListasCirculares
{
    public class Simple
    {
        //Almacenar el primer dato de la Lista
        private Nodo FistInList = new();
        //Almacenar el ultimo dato de la lista
        private Nodo LastInList = new();

        public Simple()
        {
            FistInList = null;
            LastInList = null;
        }

        public void Add()
        {
            Nodo nodo = new();
            Console.WriteLine("Ingrese el Dato:");
            nodo.Values = int.Parse(Console.ReadLine());
            if(FistInList == null)
            {
                FistInList = nodo;
                FistInList.NextValue = FistInList;
                LastInList = FistInList;
            }
            else
            {
                LastInList.NextValue = nodo;
                nodo.NextValue = FistInList;
                LastInList = nodo;
            }
            Console.WriteLine("\n El dato se Ingreso a la Lista Circular\n");
            Console.WriteLine(@"Deseas agregar otro elemento
            1) Si
            2) No");
            var option = int.Parse(Console.ReadLine());
            if (option == 1)
                Add();
            else if (option == 2)
                Listar();

        }

        private void Listar()
        {
            Nodo nodoActual = new();
            nodoActual = FistInList;
            if (nodoActual != null)
            {
                do
                {
                    Console.WriteLine($"+ {nodoActual.Values}");
                    nodoActual = nodoActual.NextValue;
                } while (nodoActual != FistInList);
            }
            else
            {
                Console.WriteLine("La lista esta Vacia.\n");
                Console.WriteLine(@"Deseas agregar un elemento
            1) Si
            2) No");
                var option = int.Parse(Console.ReadLine());
                if (option == 1)
                    Add();
                else if (true)
                    Listar();
            }
        }
    }
}
