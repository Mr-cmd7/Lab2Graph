using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Graph
{
    
    public class Graph
    {
        private Dictionary<int, List<int>> adjacencyList;

        public Graph(Dictionary<int, List<int>> adjacencyList)
        {
            this.adjacencyList = adjacencyList;
        }
        public void AddVertex(int vertex)
        {
            if (!adjacencyList.ContainsKey(vertex))
            {
                adjacencyList[vertex] = new List<int>();
            }
            else
            {
                Console.WriteLine("Вершина уже существует!");
            }
        }
        public void AddEdge(int source, int destination)
        {
            if (adjacencyList.ContainsKey(source) && adjacencyList.ContainsKey(destination))
            {
                adjacencyList[source].Add(destination);
            }
            else
            {
                Console.WriteLine("Одна или обе вершины не существуют!");
            }
        }
        public void PrintAdjacencyList()
        {
            foreach (var vertex in adjacencyList)
            {
                Console.Write($"{vertex.Key}: ");
                foreach (var neighbor in vertex.Value)
                {
                    Console.Write($"{neighbor} ");
                }
                Console.WriteLine();
            }
        }
        public bool HasCycle()
        {
            HashSet<int> visited = new HashSet<int>();
            HashSet<int> currentlyVisited = new HashSet<int>();

            foreach (var vertex in adjacencyList.Keys)
            {
                if (DFS(vertex, visited, currentlyVisited))
                {
                    return true;
                }
            }

            return false;
        }
        private bool DFS(int vertex, HashSet<int> visited, HashSet<int> currentlyVisited)
        {
            if (currentlyVisited.Contains(vertex))
            {
                List<int> cycle = new List<int>(currentlyVisited);
                cycle.Reverse();
                Console.WriteLine("Цикл найден: " + string.Join(" -> ", cycle));
                return true;
            }

            if (visited.Contains(vertex))
            {
                return false;
            }

            visited.Add(vertex);
            currentlyVisited.Add(vertex);

            foreach (var neighbor in adjacencyList[vertex])
            {
                if (DFS(neighbor, visited, currentlyVisited))
                {
                    return true;
                }
            }

            currentlyVisited.Remove(vertex);
            return false;
        }

    }
}
