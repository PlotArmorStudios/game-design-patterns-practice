using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DepthFirstSearch
{
    class Graphs
    {
        int vertices;
        int[,] adjMat;
        int[] visited;

        public Graphs(int n)
        {
            vertices = n;
            adjMat = new int[n, n];
            visited = new int[vertices];
        }

        public void insertEdge(int u, int v, int x)
        {
            adjMat[u, v] = x;
        }

        public void removeEdge(int u, int v)
        {
            adjMat[u, v] = 0;
        }

        public bool existEdge(int u, int v)
        {
            return adjMat[u, v] != 0;
        }

        public int vertexCount()
        {
            return vertices;
        }

        public int edgeCount()
        {
            int count = 0;
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                    if (adjMat[i, j] != 0)
                        count = count + 1;
            }
            return count;
        }

        public void edges()
        {
            Console.WriteLine("Edges:");
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                    if (adjMat[i, j] != 0)
                        Console.WriteLine(i + "--" + j);
            }
        }

        public int outdegree(int v)
        {
            int count = 0;
            for (int j = 0; j < vertices; j++)
                if (adjMat[v, j] != 0)
                    count = count + 1;
            return count;
        }

        public int indegree(int v)
        {
            int count = 0;
            for (int i = 0; i < vertices; i++)
                if (adjMat[i, v] != 0)
                    count = count + 1;
            return count;
        }

        public void display()
        {
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                    Console.Write(adjMat[i, j] + "\t");
                Console.WriteLine();
            }
        }

        public void DFS(int s)
        {
            if (visited[s] == 0) //check if vertex is visited. If this is true, this means the vertex is not yet visited
            {
                Console.Write(s + " "); //
                visited[s] = 1; //vertex s is now visited
                for (int j = 0; j < vertices; j++) //find all the edges from vertex s
                    if (adjMat[s, j] == 1 && visited[j] == 0) //first condition check if an edge exists between vertex s and vertex j. second condition checks if vertex j is already visited or not
                        DFS(j); //recursively call DFS and pass the not visited vertex into the algorithm to begin search again
            }
        }

        static void Main(string[] args)
        {
            //initiate directed graph with 7 vertices
            Graphs g = new Graphs(7);
            g.insertEdge(0, 1, 1);
            g.insertEdge(0, 5, 1);
            g.insertEdge(0, 6, 1);
            g.insertEdge(1, 0, 1);
            g.insertEdge(1, 2, 1);
            g.insertEdge(1, 5, 1);
            g.insertEdge(1, 6, 1);
            g.insertEdge(2, 3, 1);
            g.insertEdge(2, 4, 1);
            g.insertEdge(2, 6, 1);
            g.insertEdge(3, 4, 1);
            g.insertEdge(4, 2, 1);
            g.insertEdge(4, 5, 1);
            g.insertEdge(5, 2, 1);
            g.insertEdge(5, 3, 1);
            g.insertEdge(6, 3, 1);
            Console.WriteLine("Depth First Search:");
            g.DFS(0);
            Console.ReadKey();
        }
    }
}
