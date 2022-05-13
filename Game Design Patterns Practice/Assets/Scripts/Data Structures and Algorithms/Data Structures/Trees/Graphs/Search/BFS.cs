using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreadthFirstSearch
{
    class Graphs
    {
        int vertices;
        int[,] adjMat;

        public Graphs(int n)
        {
            vertices = n;
            adjMat = new int[n, n];
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

        public void BFS(int s)
        {
            int i = s; //assign a variable as the start vertex
            QueuesLinked q = new QueuesLinked();
            int[] visited = new int[vertices];  //create an array to store visited vertices
            Console.Write(i + " ");
            visited[i] = 1; //signifies that the vertex i is visited
            q.enqueue(i); //enqueue start vertex
            while (!q.isEmpty()) //check if the queue is empty
            {
                i = q.dequeue(); //remove the vertex from queue (store in variable i)
                for (int j = 0; j < vertices; j++) //traverse all edges of vertex i
                {
                    if (adjMat[i, j] == 1 && visited[j] == 0)  //check if there is an edge between vertex i and vertex j, and check if vertex j is visited or not
                    {
                        Console.Write(j + " ");
                        visited[j] = 1; //signifies that j is now visited
                        q.enqueue(j); //store in queue to begin the loop again and check j's edges
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            //create the graph
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
            Console.WriteLine("Breadth First Search:");
            g.BFS(0); //perform the BFS from vertex 0
            Console.ReadKey();
        }
    }
}
