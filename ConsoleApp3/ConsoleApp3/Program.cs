//using FluentAssertions;

using System.Xaml;

namespace ConsoleApp3
{
    public record Tree
    {
        public List<Apple> Fruit { get; } = new();
    }

    public record Apple
    {
        public int Seeds { get; init; }
    };

    internal class Program
    {
        static void Main(string[] args)
        {
            Tree objectGraph = new()
            {
                Fruit =
                    {
                        new Apple { Seeds = 3 },
                        new Apple { Seeds = 5 },
                    },
            };

            string xaml = XamlServices.Save(objectGraph);
            Console.WriteLine(xaml);
            Tree deserialized = (Tree)XamlServices.Load(new StringReader(xaml));
            Console.WriteLine($"Fruit on deserialized tree: {deserialized.Fruit.Count}");
        }
    }
}