using System;

namespace Examples.Curso.Algorithms.Tree
{
    public class Binary
    {
        class Nodo
        {
            public int data;
            public Nodo Izq, Der;
        }

        Nodo Root;

        public Binary()
        {
            Root = null;
        }

        public void Insert(int data)
        {
            Nodo nuevo = new Nodo();
            nuevo.data = data;
            nuevo.Izq = null;
            nuevo.Der = null;

            if (Root == null)
            {
                Root = nuevo;
            }
            else
            {

                Nodo Before = null, NodoAux;
                NodoAux = Root;

                while (NodoAux != null)
                {
                    Before = NodoAux;
                    if (data < NodoAux.data)
                    {
                        NodoAux = NodoAux.Izq;
                    }
                    else
                    {
                        NodoAux = NodoAux.Der;
                    }
                }

                if (data < Before.data)
                {
                    Before.Izq = nuevo;
                }
                else
                {
                    Before.Der = nuevo;
                }
            }
        }

        private void PreOrder(Nodo Tree, string Posicion)
        {
            if (Tree == null)
                return;

            Console.WriteLine(Tree.data + ": " + Posicion);
            PreOrder(Tree.Izq, "Izq");
            PreOrder(Tree.Der, "Der");
        }

        public void PreOrder()
        {
            PreOrder(Root, "Root");
            Console.WriteLine();
        }

        private void InOrder(Nodo Tree)
        {
            if (Tree == null)
                return;


            InOrder(Tree.Izq);
            Console.WriteLine(Tree.data);
            InOrder(Tree.Der);
        }

        public void InOrder()
        {
            InOrder(Root);
            Console.WriteLine();
        }


        private void PostOrder(Nodo Tree)
        {
            if (Tree == null)
                return;


            PostOrder(Tree.Izq);
            PostOrder(Tree.Der);
            Console.WriteLine(Tree.data);
        }

        public void PostOrder()
        {
            PostOrder(Root);
            Console.WriteLine();
        }


    }



}
