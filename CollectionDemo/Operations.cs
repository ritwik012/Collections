using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo
{
    public class Operations
    {
        public static void List()
        {
            List<string> list = new List<string>();
            list.Add("Rutwik");
            list.Add("Ashu");
            list.Add("Harsh");
            list.Add("Yogesh");
            list.Remove("Harsh");
            foreach(var data in list)
            {
                Console.WriteLine(data);
            }
        }
        public static void Stack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(45);
            stack.Push(78);
            stack.Push(48);
            stack.Push(88);
            stack.Push(35);
            foreach (var data in stack)
            {
                Console.WriteLine(data);
            }
        }
        public static void Queue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(48);
            queue.Enqueue(86);
            queue.Enqueue(78);
            queue.Enqueue(51);
            foreach(var data in queue)
            {
                Console.WriteLine(data);
            }
        }
        public static void Set()
        {
            var set = new HashSet<string>();
            set.Add("Rutwik");
            set.Add("Ashu");
            set.Add("Harsh");
            set.Add("Yogesh");
            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        public static void Dictionary()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Rutwik");
            dictionary.Add(101, "Yogesh");
            dictionary.Add(102, "Ashu");
            dictionary.Add(103, "Harsh");
            foreach(var data in dictionary)
            {
                Console.WriteLine("Key = " + data.Key + " & Value = " + data.Value);
            }
        }
    }
}