using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.Curso.Algorithms.Tree
{
    public class BinaryV2
    {

        private class Node
        {
            public int data;
            public Node left;
            public Node right;

            public Node(int data)
            {
                this.data = data;
                this.left = this.right = null;
            }
        }


        #region Izquierda y derecha de un arbol

        int maxLevelLeftPascua = 0;
        private void LeftViewPascua(Node root, int level, List<int> lstResult)
        {
            if (root == null)
                return;

            if (maxLevelLeftPascua < level)
            {
                lstResult.Add(root.data);
                maxLevelLeftPascua = level;
            }

            LeftViewPascua(root.left, level + 1, lstResult);

        }

        int maxLevelRightPascua = 0;
        private void RightViewPascua(Node root, int level, List<int> lstResult)
        {

            if (root == null)
                return;

            if (maxLevelRightPascua < level)
            {
                lstResult.Add(root.data);
                maxLevelRightPascua = level;
            }

            RightViewPascua(root.right, level + 1, lstResult);

        }
        #endregion

        int maxLevel = 0;
        private void LeftView(Node root, int level, List<int> lstResult)
        {
            if (root == null)
                return;

            if (maxLevel < level)
            {
                lstResult.Add(root.data);
                maxLevel = level;
            }

            LeftView(root.left, level + 1, lstResult);
            LeftView(root.right, level + 1, lstResult);
        }

        int maxLevelV2 = 0;

        private void LeftViewV2(Node root, int level)
        {

            if (root == null)
                return;

            if (maxLevelV2 < level)
            {
                Console.WriteLine(root.data);
                maxLevelV2 = level;
            }

            LeftViewV2(root.left, level + 1);
            LeftViewV2(root.right, level + 1);

        }

        private void RightView(Node root, int level, List<int> lstResult)
        {

            if (root == null)
                return;

            if (maxLevel < level)
            {
                lstResult.Add(root.data);
                maxLevel = level;
            }

            RightView(root.right, level + 1, lstResult);
            RightView(root.left, level + 1, lstResult);

        }

        private void PreOrder(Node root)
        {
            if (root == null)
                return;

            Console.Write(root.data + ", ");
            PreOrder(root.left);
            PreOrder(root.right);
        }

        //Preorder(root)
        //Preorder(root.left)
        //Preorder(root.left.left)

        private void InOrder(Node root)
        {
            if (root == null)
                return;

            InOrder(root.left);
            Console.Write(root.data + ", ");
            InOrder(root.right);
        }

        private void PostOrder(Node root)
        {
            if (root == null)
                return;

            PostOrder(root.left);
            PostOrder(root.right);
            Console.Write(root.data + ", ");
        }

        int altura = 0;
        private int HeightTree(Node root, int nivel)
        {
            if (root != null)
            {
                HeightTree(root.left, nivel + 1);
                if (nivel > altura)
                    altura = nivel;
                HeightTree(root.right, nivel + 1);
            }
            return altura;
        }

        //Merge Two Arrays
        private void MergeTwoArray(int[] arrOne, int[] arrTwo)
        {

            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6 };
            int[] arrThree = new int[arrOne.Length + arrTwo.Length];

            Array.Copy(arrOne, arrThree, arrOne.Length);
            Array.Copy(arrTwo, 0, arrThree, arrOne.Length, arrTwo.Length);

            foreach (var item in arrThree)
            {
                Console.WriteLine(item);
            }
        }

        private Node LCA(Node root, int n1, int n2)
        {
            if (root == null)
                return null;

            //Implement While while (root != null)
            //eliminar llaves para que se vea más cool
            if (root.data > n1 && root.data > n2)
            {
                return LCA(root.left, n1, n2);
                //root = root.left
            }

            //else if
            if (root.data < n1 && root.data < n2)
            {
                return LCA(root.right, n1, n2);
                //root = root.right
            }
            //else break

            return root;
        }

        #region Check if a binary tree is subtree of another binary tree

        bool areIdentical(Node rootOne, Node rootTwo)
        {

            /* base cases */
            if (rootOne == null && rootTwo == null)
                return true;

            if (rootOne == null || rootTwo == null)
                return false;

            /* Check if the data of both roots is
            same and data of left and right
            subtrees are also same */
            return (rootOne.data == rootTwo.data
                    && areIdentical(rootOne.left, rootTwo.left)
                    && areIdentical(rootOne.right, rootTwo.right));
        }

        /* This function returns true if S is
        a subtree of T, otherwise false */
        bool isSubtree(Node T, Node S)
        {
            /* base cases */
            if (S == null)
                return true;

            if (T == null)
                return false;

            /* Check the tree with root as current node */
            if (areIdentical(T, S))
                return true;

            /* If the tree with root as current
              node doesn't match then try left
              and right subtrees one by one */
            return isSubtree(T.left, S)
                    || isSubtree(T.right, S);
        }
        #endregion


        private int[] TwoSumBruteForce(int[] nums, int target)
        {
            //Declarations
            int arrayLength = nums.Length;
            //Validations
            if (nums == null || arrayLength < 2)
            {
                return Array.Empty<int>();
            }
            //Logic
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
                }
            }
            return Array.Empty<int>();
        }

        void printLevelOrder(Node root)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {

                Node tempNode = queue.Dequeue();
                Console.Write(tempNode.data + " ");

                /*Enqueue left child */
                if (tempNode.left != null)
                {
                    queue.Enqueue(tempNode.left);
                }

                /*Enqueue right child */
                if (tempNode.right != null)
                {
                    queue.Enqueue(tempNode.right);
                }
            }
        }
        #region Level Order Traversal Tree

        #endregion


        private void MinimoArray()
        {
            int[] numbers = new int[] { 3, 7, 10, 5, 6, 1 };
            Array.Sort(numbers);
           
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine(numbers[i]);

            }




        }



        public void TreePrint()
        {

            MinimoArray();

            Node root = new Node(1);

            //LCA
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            root.left.right.left = new Node(6);
            root.left.right.right = new Node(7);
            //FIN LCA

            //root.right = new Node(2);
            //root.right.right = new Node(5);
            //root.right.right.left = new Node(3);
            //root.right.right.left.right = new Node(4);
            //root.right.right.right = new Node(6);

            //root.left = new Node(7);
            //root.left.left = new Node(3);
            //root.left.right = new Node(7);
            //root.right = new Node(14);
            //root.right.right = new Node(18);

            Console.WriteLine("LeftView");

            List<int> lst = new List<int>();
            LeftView(root, 1, lst);

            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("LeftViewV2");
            LeftViewV2(root, 1);

            Console.WriteLine("Pre Order");
            PreOrder(root);

            Console.WriteLine("In Order");
            InOrder(root);

            Console.WriteLine("Post Order");
            PostOrder(root);

            Console.WriteLine("Altura");
            int altura = HeightTree(root, 1);
            Console.WriteLine("Altura: " + altura);
            Console.WriteLine("Derecha e Izquierda de un arbol: " + altura);

            Console.WriteLine("LeftView Pascua");

            List<int> lstPascua = new List<int>();
            LeftViewPascua(root.left, 1, lstPascua);
            lstPascua.Reverse();
            RightViewPascua(root, 1, lstPascua);

            foreach (var item in lstPascua)
            {
                Console.WriteLine(item);
            }


            //LCA
            Console.WriteLine("LCA");
            Node result = LCA(root, 2, 6);
            Console.WriteLine("Result lca: " + result.data);

            Console.WriteLine("Level Order");
            printLevelOrder(root);
        }

        public void newTree()
        {
            Node root = new Node(1); //raíz
            root.left = new Node(2); //Izquierdo
            root.left.left = new Node(3); //Izquierdo Izquierdo
            root.left.right = new Node(4); //Izquierdo Derecho

            root.right = new Node(5);
            root.right.left = new Node(18);
            root.right.right = new Node(6);
            root.right.right.left = new Node(20);
            root.right.right.right = new Node(7);

            //pre orden 1,2,3,4,5,18,6,7
            Console.WriteLine("");
            Console.WriteLine("pre orden 1,2,3,4,5,18,6,7");
            Console.WriteLine("");
            PreOrder(root);

            //in orden 3,2,4,1,5,7,6,18
            Console.WriteLine("");
            Console.WriteLine("in orden 3,2,4,1,5,7,6,18");
            Console.WriteLine("");
            InOrder(root);

            //post orden 3,2,4,7,6,5,18,1
            Console.WriteLine("");
            Console.WriteLine("post orden 3,2,4,7,6,5,18,1");
            Console.WriteLine("");
            PostOrder(root);

            Console.WriteLine("Altura");
            Console.WriteLine(HeightTree(root, 1));
        }

        //private class Node
        //{
        //    public int data;
        //    public Node left;
        //    public Node right;

        //    public Node(int data)
        //    {
        //        this.data = data;
        //        this.left = this.right = null;
        //    }
        //}
        //     1
        //   2
        // 3  4
        //
    }   //
}
