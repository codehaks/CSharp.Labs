using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections.Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //ICollection<Post> posts = new Blog().Posts.;

            int[,] numbers = { { 1, 2,3 },
                               { 4, 5,6 } };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine($"({i},{j}) => {numbers[i,j]}");
                }
            }
            IEnumerable<int> nums;

            ICollection<int> col;

            IList<int> list;

            IQueryable<int> query;

            //var s = "Hello from C#";
            ////s.tocha

            //var e = numbers.GetEnumerator();

            //while (e.MoveNext())
            //{
            //    int value = (int)e.Current;
            //    Console.WriteLine(value);
            //}

            //IEnumerable<int> num = numbers;

            //foreach (var item in num)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            ////IList<Post> posts =new List() { new Post {Id=1,Name="Hey" } }

            //Console.WriteLine("Hello World!");
        }
    }


    class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Post> Posts { get; set; }
    }

    class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
