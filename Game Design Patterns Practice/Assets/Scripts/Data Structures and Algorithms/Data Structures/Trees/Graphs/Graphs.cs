using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdjacencyMatrix
{
    class Graphs
    {
        int vertices; //store number of vertices
        int[,] adjMat; //initialize adjacency matrix

        public Graphs(int n)
        {
            vertices = n;
            adjMat = new int[n, n]; //allocate memory to matrix
        }

        public void insertEdge(int u, int v, int x) //u = vertex u. v = vertex v. x = cost/weight of edge
        {
            adjMat[u, v] = x; //assign the cost of the edge in the cell at row u and column v
        }

        public void removeEdge(int u, int v)
        {
            adjMat[u, v] = 0; //assign the cost of the edge in the cell at row u and column v to 0
        }

        public bool existEdge(int u, int v)
        {
            return adjMat[u, v] != 0; // if there is an edge, we will have a value at row u, column v
        }

        public int vertexCount()
        {
            return vertices;
        }

        public int edgeCount() //traverse the adjacency matrix and count number of edges
        {
            int count = 0; //initialize a count variable
            for (int i = 0; i < vertices; i++) //traverse the rows
            {
                for (int j = 0; j < vertices; j++) //traverse the columns in each row
                    if (adjMat[i, j] != 0) //if this is true, that means there's an edge between i and j
                        count = count + 1;
            }
            return count; //return the count
        }

        public void edges() //display the edges from the matrix
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
            for (int j = 0; j < vertices; j++) //traverse the columns
                if (adjMat[v, j] != 0)//check if the cell v and j contains 0.
                    count = count + 1;
            return count;
        }

        public int indegree(int v)
        {
            int count = 0;
            for (int i = 0; i < vertices; i++) //traverse the rows
                if (adjMat[i, v] != 0) //check if the cell i and v contains 0.
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

        static void Main(string[] args)
        {
        }
    }
}
