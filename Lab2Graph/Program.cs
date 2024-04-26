using Lab2Graph;

Dictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>
    {
        { 1, new List<int> { 2, 3 } },
        { 2, new List<int> { 4 } },
        { 3, new List<int> { 5 } },
        { 4, new List<int> { 5 } },
        { 5, new List<int>() } // Для вершины без исходящих рёбер
    };

Graph graph = new Graph(adjacencyList);

Console.WriteLine("Список смежности:");
graph.PrintAdjacencyList();

Console.WriteLine("\nПроверка наличия циклов:");
if (!graph.HasCycle())
{
    Console.WriteLine("Циклы не найдены.");
}
