using System;


namespace GraphsDemo
{
    class Graphs
    {
        public int vertices;
        int[,] adjMat;

        public Graphs(int v)
        {
            this.vertices = v;
            this.adjMat = new int[v, v];
        }


        public void insertEdge(int u, int v, int weight = 1)     
        {

            adjMat[u, v] = weight;
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
                {

                    if (adjMat[i, j] != 0)
                        count = count + 1;
                }

            }

            return count;
        }

        public void edges()
        {
            Console.WriteLine("edges");

            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {

                    if (adjMat[i, j] != 0)
                        Console.WriteLine(i + "---" + j);
                }
            }            
        }

        public int outDegree( int v)
        {
            int count = 0;
            for (int i = 0; i < vertices; i++)
            {
                if (adjMat[v, i] != 0)
                    count = count + 1;
            }
            return count;            
        }

        public int inDegree(int v)
        {
            int count = 0;
            for (int i = 0; i < vertices; i++)
            {
                if (adjMat[i, v] != 0)
                    count = count + 1;
            }
            return count;
        }

        public void Display()
        {
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {
                    Console.WriteLine(adjMat[i,j]+ "\t");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
