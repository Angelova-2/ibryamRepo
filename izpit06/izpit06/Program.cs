using System.ComponentModel;

namespace izpit06
{
    internal class Program
    {
        class Node
        {
            public int x;
        }
        public int Value { get; set; }
        
        public Node(int value)
        {
            Value = value;
        }
        class DynamicNodeArray
        {
            public int x;
        }
        private Node[] nodes;
        private int count;
        public DynamicNodeArray()
        {
            nodes = new Node[0];
            nodes = new Node[2];
        }
        public void Add(int value) 
        {
            nodes[0] = new Node();
        }
        private void Resize() 
        {
            count++;
        }
        public int Count() 
        {
            return count;
        }
        public int GetValue(int index) 
        {
            return nodes[index].x;
        }
        public void SetValue(int index, int value) 
        {
            nodes[index].x = value;
        }
        public void Print() 
        {
           
        }
