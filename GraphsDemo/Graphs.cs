using System;
using System.Collections;

namespace GraphsDemo
{
    class Graphs
    {
        public int vertices;
        int[,] adjMat; // two dimentional array.

        public Graphs(int v)
        {
            this.vertices = v;
            this.adjMat = new int[v, v]; // adjan matrix will be created with row and columns n * n
        }

        /// <summary>
        ///  Time complexity is O (1) - since a new edge can be inserted by adding or updating a new entry in the adj matrix
        /// </summary>
        /// <param name="u"></param>
        /// <param name="v"></param>
        /// <param name="weight"></param>
        public void insertEdge(int u, int v, int weight = 1) => adjMat[u, v] = weight;

        /// <summary>
        /// Time complexity is O (1) - since its east to remove the value in adj matrix         
        /// </summary>
        /// <param name="u"></param>
        /// <param name="v"></param>
        public void removeEdge(int u, int v) => adjMat[u, v] = 0;

        /// <summary>
        /// Time complexity is O (1)
        /// </summary>
        /// <param name="u"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        public bool existEdge(int u, int v) => adjMat[u, v] != 0; // if the value in the cell is zero it will return false


        /// <summary>
        /// Time complexity is O (1)  no. of rows or count will give the count in adj matrix 
        /// </summary>
        /// <returns></returns>
        public int vertexCount() => vertices;

        /// <summary>
        /// Time complexity is O (1) - since we can maintain additional list of all the edges in the graph 
        /// </summary>
        /// <returns></returns>
        public int edgeCount()
        {
            int count = 0;
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {

                    if (adjMat[i, j] != 0)  // if this is not zero that means there is edge between i and j, so we will increase the count by 1
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
                    if (adjMat[i, j] != 0) // check if this is not zero that mean there is a edge between i and j and that we will display.
                        Console.WriteLine(i + "---" + j);
                }
            }
        }

        /// <summary>
        /// The out-degree of the vertex is no of outgoing edges from the vertex. 
        /// 
        /// </summary>
        /// <param name="v"> computing out degree of vertex v</param>
        /// <returns></returns>
        public int outDegree(int v)
        {
            int count = 0;
            for (int i = 0; i < vertices; i++)
            {
                if (adjMat[v, i] != 0)  // adj [v, i] -  
                    count = count + 1;
            }
            return count;
        }

        /// <summary>
        /// The in-degree of the vertex is no. of incoming edges on the vertex. 
        /// </summary>
        /// <param name="v">Compting in degree of vertex v</param>
        /// <returns></returns>
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
                    Console.Write(adjMat[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }


        public void BFS(int v)
        {
            var current = v;
            var q = new Queue();
            int[] visited = new int[vertices];

            Console.Write(current + " ");
            visited[current] = 1;

            q.Enqueue(current);
            while (q.Count != 0)
            {
                current = (int) q.Dequeue();

                for (int i = 0; i < vertices; i++)
                {
                    if (adjMat[current, i] == 1 && visited[i] == 0)
                    {
                        Console.Write(i + " ");
                        visited[i] = 1;
                        q.Enqueue(i);
                    }
                }
            }
            

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            #region "undirected graphs"
            //Graphs g1 = new Graphs(4);
            //Console.WriteLine("Graphs Adjancey matrix");
            //g1.Display();
            //Console.WriteLine("Vertex count " + g1.vertexCount());
            //Console.WriteLine("Edges count " + g1.edgeCount());
            //g1.insertEdge(0, 1, 1);
            //g1.insertEdge(0, 2, 1);
            //g1.insertEdge(1, 0, 1);
            //g1.insertEdge(1, 2, 1);
            //g1.insertEdge(2, 0, 1);
            //g1.insertEdge(2, 1, 1);
            //g1.insertEdge(2, 3, 1);
            //g1.insertEdge(3, 2, 1);
            //g1.Display();
            //Console.WriteLine("Vertex count " + g1.vertexCount());
            //Console.WriteLine("Edges count " + g1.edgeCount());
            //g1.edges();            
            //Console.WriteLine("Edge between 1 and 3 : " + g1.existEdge(1, 3));
            //Console.WriteLine("Edge between 1 and 2 : " + g1.existEdge(1, 2));
            //Console.WriteLine("Degree on Vertex 2 " + g1.inDegree(2));
            //g1.removeEdge(1, 2);
            //Console.WriteLine("Graph Adjacency Matrix");
            //g1.Display();
            //Console.WriteLine("edge between 1 and 2 "+ g1.existEdge(1,2));
            #endregion


            #region "Weighted Undirected Graph"
            //Graphs g1 = new Graphs(4);
            //Console.WriteLine("Graphs Adjancey matrix");
            //g1.Display();
            //Console.WriteLine("Vertex count " + g1.vertexCount());
            //Console.WriteLine("Edges count " + g1.edgeCount());
            //g1.insertEdge(0, 1, 26);
            //g1.insertEdge(0, 2, 16);
            //g1.insertEdge(1, 0, 26);
            //g1.insertEdge(1, 2, 12);
            //g1.insertEdge(2, 0, 16);
            //g1.insertEdge(2, 1, 12);
            //g1.insertEdge(2, 3, 8);
            //g1.insertEdge(3, 2, 8);
            //g1.Display();
            //Console.WriteLine("Vertex count " + g1.vertexCount());
            //Console.WriteLine("Edges count " + g1.edgeCount());
            //g1.edges();
            //Console.WriteLine("Edge between 1 and 3 : " + g1.existEdge(1, 3));
            //Console.WriteLine("Edge between 1 and 2 : " + g1.existEdge(1, 2));
            //Console.WriteLine("Degree on Vertex 2 " + g1.inDegree(2));
            //g1.removeEdge(1, 2);
            //Console.WriteLine("Graph Adjacency Matrix");
            //g1.Display();
            //Console.WriteLine("edge between 1 and 2 " + g1.existEdge(1, 2));
            #endregion

            #region "Directed Graph"
            //Graphs g1 = new Graphs(4);
            //Console.WriteLine("Graphs Adjancey matrix");
            //g1.Display();
            //Console.WriteLine("Vertex count " + g1.vertexCount());
            //Console.WriteLine("Edges count " + g1.edgeCount());
            //g1.insertEdge(0, 1, 1);
            //g1.insertEdge(0, 2, 1);            
            //g1.insertEdge(1, 2, 1);                        
            //g1.insertEdge(2, 3, 1);            
            //g1.Display();
            //Console.WriteLine("Vertex count " + g1.vertexCount());
            //Console.WriteLine("Edges count " + g1.edgeCount());
            //g1.edges();
            //Console.WriteLine("Edge between 1 and 3 : " + g1.existEdge(1, 3));
            //Console.WriteLine("Edge between 1 and 2 : " + g1.existEdge(1, 2));

            //// since this is a directed craph - we wil lbe computing the in degree and out degree 
            //Console.WriteLine("Degree on Vertex 2 : " + g1.inDegree(2) + g1.outDegree(2));
            //Console.WriteLine("IN - Degree on Vertex 2 " + g1.inDegree(2));
            //Console.WriteLine("OUt Degree on Vertex 2 " + g1.outDegree(2));
            //g1.removeEdge(1, 2);
            //Console.WriteLine("Graph Adjacency Matrix");
            //g1.Display();
            //Console.WriteLine("edge between 1 and 2 " + g1.existEdge(1, 2));
            #endregion

            #region "Wieghted Directed Graph"
            //Graphs g1 = new Graphs(4);
            //Console.WriteLine("Graphs Adjancey matrix");
            //g1.Display();
            //Console.WriteLine("Vertex count :" + g1.vertexCount());
            //Console.WriteLine("Edges count :" + g1.edgeCount());
            //g1.insertEdge(0, 1, 26);
            //g1.insertEdge(0, 2, 16);
            //g1.insertEdge(1, 2, 12);
            //g1.insertEdge(2, 3, 8);
            //g1.Display();
            //Console.WriteLine("Vertex count : " + g1.vertexCount());
            //Console.WriteLine("Edges count : " + g1.edgeCount());
            //g1.edges();
            //Console.WriteLine("Edge between 1 and 3 : " + g1.existEdge(1, 3));
            //Console.WriteLine("Edge between 1 and 2 : " + g1.existEdge(1, 2));

            //// since this is a directed craph - we wil lbe computing the in degree and out degree 
            //Console.WriteLine("Degree on Vertex 2 : " + (g1.inDegree(2) + g1.outDegree(2)));
            //Console.WriteLine("IN - Degree on Vertex 2 : " + g1.inDegree(2));
            //Console.WriteLine("OUt Degree on Vertex 2 : " + g1.outDegree(2));
            //g1.removeEdge(1, 2);
            //Console.WriteLine("Graph Adjacency Matrix");
            //g1.Display();
            //Console.WriteLine("edge between 1 and 2 : " + g1.existEdge(1, 2));
            #endregion

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
            g.Display();
            Console.WriteLine("Breadth First Method");
            g.BFS(0);



            Console.ReadKey();




        }
    }
}
