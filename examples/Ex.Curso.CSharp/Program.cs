﻿using System;
using Examples.Curso.Algorithms.Tree;


namespace Examples.Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Delegados.TestDelegate();
            //BinaryTree();
            BinaryV2 Tree = new BinaryV2();
            //Tree.TreePrint();
            Tree.newTree();
            //ArbolBinarioOrdenado abo = new ArbolBinarioOrdenado();
            //abo.Insertar(100);
            //abo.Insertar(50);
            //abo.Insertar(25);
            //abo.Insertar(75);
            //abo.Insertar(150);
            //Console.WriteLine("Impresion preorden: ");
            //abo.ImprimirPre();
            //Console.WriteLine("Impresion entreorden: ");
            //abo.ImprimirEntre();
            //Console.WriteLine("Impresion postorden: ");
            //abo.ImprimirPost();
            //Console.ReadKey();
        }


        static void BinaryTree()
        {
            Binary Tree = new Binary();
            Tree.Insert(100);
            Tree.Insert(50);
            Tree.Insert(25);
            Tree.Insert(75);
            Tree.Insert(150);

            Console.WriteLine("Impresion PreOrden: ");
            Tree.PreOrder();
            Console.WriteLine("Impresion InOrden: ");
            Tree.InOrder();
            Console.WriteLine("Impresion PostOrden: ");
            Tree.PostOrder();
            Console.ReadKey();
        }


        public class ArbolBinarioOrdenado
        {
            class Nodo
            {
                public int info;
                public Nodo izq, der;
            }
            Nodo raiz;

            public ArbolBinarioOrdenado()
            {
                raiz = null;
            }

            public void Insertar(int info)
            {
                Nodo nuevo;
                nuevo = new Nodo();
                nuevo.info = info;
                nuevo.izq = null;
                nuevo.der = null;
                if (raiz == null)
                    raiz = nuevo;
                else
                {
                    Nodo anterior = null, reco;
                    reco = raiz;
                    while (reco != null)
                    {
                        anterior = reco;
                        if (info < reco.info)
                            reco = reco.izq;
                        else
                            reco = reco.der;
                    }
                    if (info < anterior.info)
                        anterior.izq = nuevo;
                    else
                        anterior.der = nuevo;
                }
            }


            private void ImprimirPre(Nodo reco)
            {
                if (reco != null)
                {
                    Console.Write(reco.info + " ");
                    ImprimirPre(reco.izq);
                    ImprimirPre(reco.der);
                }
            }

            public void ImprimirPre()
            {
                ImprimirPre(raiz);
                Console.WriteLine();
            }

            private void ImprimirEntre(Nodo reco)
            {
                if (reco != null)
                {
                    ImprimirEntre(reco.izq);
                    Console.Write(reco.info + " ");
                    ImprimirEntre(reco.der);
                }
            }

            public void ImprimirEntre()
            {
                ImprimirEntre(raiz);
                Console.WriteLine();
            }


            private void ImprimirPost(Nodo reco)
            {
                if (reco != null)
                {
                    ImprimirPost(reco.izq);
                    ImprimirPost(reco.der);
                    Console.Write(reco.info + " ");
                }
            }


            public void ImprimirPost()
            {
                ImprimirPost(raiz);
                Console.WriteLine();
            }
        }


        
    }
    
}
