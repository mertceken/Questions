using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vertices = new List<Vertex>();
            var boundingPolies = new List<BoundingPoly>();
            var root = new List<Root>();
            string jsonFilePath = @"C:\response.json";

            using (StreamReader reader = new StreamReader(jsonFilePath))
            {
                string json = reader.ReadToEnd();
                vertices = JsonSerializer.Deserialize<List<Vertex>>(json);
                boundingPolies = JsonSerializer.Deserialize<List<BoundingPoly>>(json);
                root = JsonSerializer.Deserialize<List<Root>>(json);
            }
            if(vertices!=null && vertices.Count>0)
            {
                foreach (var vertex in vertices)
                {
                    Console.WriteLine($"{vertex.x} + {vertex.y}");
                }
                if(boundingPolies!=null && boundingPolies.Count>0)
                {
                    if(root!=null && root.Count>0)
                    {
                        foreach (var item in root)
                        {
                            Console.WriteLine($"{item.locale} + {item.description} + {item.boundingPoly}");
                        }
                    }
                }
            }
            Console.WriteLine("Hello World!");
        }
    }
    public class BoundingPoly
    {
        public List<Vertex> vertices { get; set; }
    }

    public class Root
    {
        public string locale { get; set; }
        public string description { get; set; }
        public BoundingPoly boundingPoly { get; set; }
    }

    public class Vertex
    {
        public int x { get; set; }
        public int y { get; set; }
    }
}
