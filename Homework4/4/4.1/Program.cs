using System;


namespace _4
{
    
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            head = tail = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public Node<T> Tail
        {
            get => tail;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if(tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        
        public static void ForEachNode(GenericList<T> l,Action<T> action)
        {
            Node<T> top = l.Head;
            while (top != null)
            {
                action(top.Data);
                top = top.Next;
            }
        }

    };

    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> g = new GenericList<int>();
            g.Add(2);
            g.Add(3);
            g.Add(4);
            GenericList<int>.ForEachNode(g,(n)=> { Console.WriteLine(n); });
            int max = g.Head.Data;
            int min = g.Head.Data;
            int sum = 0;
            GenericList<int>.ForEachNode(g, (n) => {
                max = Math.Max(n, max);
            });
            Console.WriteLine($"the max is {max}");
            GenericList<int>.ForEachNode(g, (n) => { min = Math.Min(n, min); });
            Console.WriteLine($"the min is {min}");
            GenericList<int>.ForEachNode(g, (n) => { sum += n; });
            Console.WriteLine($"the sum is {sum}");
        }
    }
}
