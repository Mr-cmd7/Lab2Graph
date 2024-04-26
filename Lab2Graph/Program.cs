using Lab2Graph;

class Program
{
    static void Main(string[] args)
    {
        Graph graph = new Graph();

        graph.AddVertex(1);
        graph.AddVertex(2);
        graph.AddVertex(3);
        graph.AddVertex(4);
        graph.AddVertex(5);

        graph.AddEdge(1, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(2, 4);
        graph.AddEdge(3, 5);
        graph.AddEdge(4, 5);

        Console.WriteLine("Список смежности:");
        graph.PrintAdjacencyList();

        Console.WriteLine("\nПроверка наличия циклов:");
        if (graph.HasCycle())
        {
            Console.WriteLine("Циклы найдены.");
        }
        else
        {
            Console.WriteLine("Циклы не найдены.");
        }
    }
}