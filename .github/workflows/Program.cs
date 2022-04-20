using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace testPrectish
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            IEnumerable<string> parsesting = new List<string> { "a", "ab", "abc", "abcd", "z" };
            string[] fruits = { "apple", "mango", "orange", "passionfruit", "grape" };
            int[] ints = { 4, 8, 8, 3, 9, 0, 7, 8, 2 };
            //var result = parsesting.Aggregate(false, (count, val) => 
            //count || (val.Length > 3
            //));
            //var result = parsesting.Aggregate(0, (count, val) =>
            //{
            //    return (Convert.ToInt32(count) + val.Length);
            //});
            //Maindata maindata = new Maindata();
            //maindata.loadPlaylist();
            //var result = parsesting.Aggregate((count, val) =>
            //{
            //    return (count + "," + val);
            //});

            //var checkResult = fruits.Aggregate("banana",(count, val) =>
            //{
            //    return (val.Length< count.Length)?count : val;
            //});
            //var findevennumbers = ints.Aggregate(0, (count, val) =>
            //{
            //    return (val%2==0) ? count+1 : count;
            //});
            //string text = "Let’s suppose this is a really long string";
            //var letterFrequencies = new int[26];
            //foreach (char c in text)
            //{
            //    int index = char.ToUpper(c) - 'A';
            //    if (index >= 0 && index <= 26) letterFrequencies[index]++;
            //}

            //var resultset = text.AsParallel().Aggregate(
            //      () => new int[26],
            //      (localaccumlater,text)=>
            //      {
            //          int index = Char.ToUpper(text) - 'A';
            //         if(index>0 && index<26) 
            //              localaccumlater[index]++;
            //          return localaccumlater;
            //      },
            //      (Mainaccumlater,localfunc)=>
            //      {
            //          Mainaccumlater.Zip(localfunc,(a1,a2)=>a1+a2)
            //      }

            AvlTree tree = new AvlTree();

            /* Constructing tree given in the above figure */
            tree.root = tree.Insert(tree.root, 10);
            tree.root = tree.Insert(tree.root, 20);
            tree.root = tree.Insert(tree.root, 30);
            tree.root = tree.Insert(tree.root, 40);
            tree.root = tree.Insert(tree.root, 50);
            tree.root = tree.Insert(tree.root, 25);


            //);
            Console.Read();
            Console.WriteLine("Hello World!");

            
        }

        public void IncreasingSubSequence()
        {
            int[] data = new int[] {4,6,1,3,4,6 };
            int[] sumarray = new int[data.Count()];
            int[] indexes = new int[data.Count()];
            for(int i = 0; i < data.Count(); i++)
            {

            }

        }

    }
    public class Node
    {
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
        public int data { get; set; }
        public int Hight { get; set; }
        public Node(int data)
        {
            this.data = data;
        }

    }

    internal class Btree
    {
        
        int calculatehightLF = 0;
        int calculatehightRT = 0;
        public void CreateTree(int e)
        {
            Node _tree = null;
            if (_tree == null)
            {
             
                _tree = new Node(e);
                return;
            }
            
            int rsult = calculatehightLF - calculatehightRT;
            if (rsult > 1 || rsult < -1)
                KeepBalance(_tree);
            InsertNode(_tree, new Node(e));

            

        }

        private void calculateString()
        {
            IEnumerable<string> parsesting = new List<string> { "a", "ab", "abc", "abcd", "z" };
            var result = parsesting.Aggregate(0,(count, val) =>
             {
                return (Convert.ToInt32(count)  + val.Length);
             });
        }
        private void stringCancatition()
        {
            IEnumerable<string> parsesting = new List<string> { "a", "ab", "abc", "abcd", "z" };
            var result = parsesting.Aggregate((count, val) =>
            {
                return (count +"," +val.Length);
            });
        }

        public void InsertNode(Node e,Node newnode)
        {
            if (e.data > newnode.data)
            {
                if (e.LeftNode == null)
                    e.LeftNode = newnode;
                else                
                    InsertNode(e.LeftNode, newnode);
                
            }
            else
            {
                if (e.RightNode == null)
                    e.RightNode = newnode;
                else                
                    InsertNode(e.RightNode, newnode);

            }
        }

        public void KeepBalance(Node node)
        {

        }

        //hl-hr <>[-1,0,1]
        public void CalculateDefferencefactorleft(Node nd)
        {
            
            if (nd.LeftNode != null)
            {
                calculatehightLF = calculatehightLF + 1;
                CalculateDefferencefactorleft(nd);
            }
            else if(nd.RightNode != null)
                CalculateDefferencefactorright(nd);


        }
        public void CalculateDefferencefactorright(Node nd)
        {
            if (nd.RightNode != null)
            {
                calculatehightRT = calculatehightRT + 1;
                CalculateDefferencefactorright(nd);
            }
            else if(nd.LeftNode != null)
                CalculateDefferencefactorleft(nd);

        }
    }

    public class AvlTree
    {
       public Node root;
        public int max(int a, int b)
        {
            return (a > b) ? a : b;
        }
        public Node rightRotate(Node node)
        {
            Node x = node.LeftNode;
            Node T2 = x.RightNode;
            x.RightNode = node;
            node.LeftNode = T2;

            return x;
        }
        public Node LeftRotate(Node node)
        {
            Node x = node.RightNode;
            Node T2 = x.LeftNode;
            x.LeftNode = node;
            node.RightNode = T2;

            return x;
        }
        public Node Insert(Node node ,int key)
        {
            //1 insert
            if (node == null)
                return new Node(key);
            if (key < node.data)
                node.LeftNode = Insert(node.LeftNode, key);
            else if (key > node.data)
                node.RightNode = Insert(node.RightNode, key);
            else // Duplicate keys not allowed
                return node;

            //2  //calculateheight 
            node.Hight=1+ max(calculatingHight(node.LeftNode),calculatingHight(node.RightNode));

            //3

            int balancefactor = Getbalance(node);

            if (balancefactor > 1 && key < node.LeftNode.data)
                rightRotate(node);
            if (balancefactor < -1 && key > node.RightNode.data)
                LeftRotate(node);
            if (balancefactor > 1 && key > node.LeftNode.data)
                rightRotate(node);
            if (balancefactor < -1 && key < node.RightNode.data)
            {
                node.RightNode = rightRotate(node.RightNode);
                return LeftRotate(node);
            }
                

            return node;

        }

        public int calculatingHight(Node node)
        {
            if (node == null)
                return 0;
            return node.Hight;
        }

        public int Getbalance(Node node)
        {
            if (node == null)
                return 0; 
            return (calculatingHight(node.LeftNode)-calculatingHight(node.RightNode));
        }
    }
}
