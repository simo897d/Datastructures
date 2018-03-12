using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Datastructures;

namespace Tests
{
    [TestClass]
    public class TestDatastructures
    {
        [TestMethod]
        public void TestQueue()
        {
            Queue<int> stdQueue = new Queue<int>();         // standard queue implemented by C#
            MyQueue<int> ourQueue = new MyQueue<int>();     // our manually implemented queue

            // Test generates 100 random integers and adds to both queues
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                int randVal = r.Next();
                stdQueue.Enqueue(randVal);
                ourQueue.Enqueue(randVal);
            }

            // Test reading back half the added integers
            for (int i = 0; i < 50; i++)
            {
                Assert.AreEqual(stdQueue.Dequeue(), ourQueue.Dequeue());
                Assert.AreEqual(stdQueue.Count, ourQueue.Count());
            }

            // Test adding 50 more random integers
            for (int i = 0; i < 50; i++)
            {
                int randVal = r.Next();
                stdQueue.Enqueue(randVal);
                ourQueue.Enqueue(randVal);
            }

            // Test reading back all the remaining values
            for (int i = 0; i < 100; i++)
            {
                Assert.AreEqual(stdQueue.Dequeue(), ourQueue.Dequeue());
                Assert.AreEqual(stdQueue.Count, ourQueue.Count());
            }

            // Test queue is empty now
            Assert.AreEqual(true, ourQueue.IsEmpty());
        }

        [TestMethod]
        public void TestStack()
        {
            Stack<int> stdStack = new Stack<int>();         // standard queue implemented by C#
            MyStack<int> ourStack = new MyStack<int>();     // our manually implemented stack

            // Test generates 100 random integers and adds to both queues
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                int randVal = r.Next();
                stdStack.Push(randVal);
                ourStack.Push(randVal);
            }

            // Test reading back half the added integers
            for (int i = 0; i < 50; i++)
            {
                Assert.AreEqual(stdStack.Pop(), ourStack.Pop());
                Assert.AreEqual(stdStack.Peek(), ourStack.Peek());
                Assert.AreEqual(stdStack.Count, ourStack.Count());
            }

            // Test adding 50 more random integers
            for (int i = 0; i < 50; i++)
            {
                int randVal = r.Next();
                stdStack.Push(randVal);
                ourStack.Push(randVal);
            }

            // Test reading back all the remaining values
            for (int i = 0; i < 100; i++)
            {
                Assert.AreEqual(stdStack.Peek(), ourStack.Peek());
                Assert.AreEqual(stdStack.Pop(), ourStack.Pop());
                Assert.AreEqual(stdStack.Count, ourStack.Count());
            }
        }

        [TestMethod]
        public void TestGraph()
        {
            MyGraph ourGraph = new MyGraph();
            Vertex A = new Vertex();
            Vertex B = new Vertex();
            Vertex C = new Vertex();
            Vertex D = new Vertex();

            // add the four vertices to the graph
            ourGraph.Add_vertex(A);
            ourGraph.Add_vertex(B);
            ourGraph.Add_vertex(C);
            ourGraph.Add_vertex(D);

            // add the edges between the vertices
            ourGraph.Add_edge(A, B);
            ourGraph.Add_edge(B, C);
            ourGraph.Add_edge(B, D);

            // add the edge weights to the edges
            ourGraph.Set_edge_value(A, B, 5);
            ourGraph.Set_edge_value(B, C, 3);
            ourGraph.Set_edge_value(B, D, 1);

            // now do some checks
            Assert.IsTrue(ourGraph.Neighbors(D).Contains(B));
            Assert.AreEqual(ourGraph.Get_edge_value(A, B), ourGraph.Get_edge_value(B, A));
            Assert.IsTrue(ourGraph.Adjacent(C, B));
            Assert.IsTrue(ourGraph.Adjacent(A, B));
            ourGraph.Remove_vertex(B);
            Assert.IsFalse(ourGraph.Adjacent(A, B));
        }
    }
}