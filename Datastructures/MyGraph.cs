using System;
using System.Collections.Generic;

namespace Datastructures
{
    public class MyGraph
    {
        List<Knude> knudeList;
        List<Kant> kantList;


        public MyGraph()
        {
            knudeList = new List<Knude>();
            kantList = new List<Kant>();
        }

        public void Add_vertex(Knude x)
        {
            knudeList.Add(x);
        }
        
        public void Remove_vertex(Knude x)
        {
            foreach (Kant k in kantList)
            {
                if(k.knude1 == x)
                {
                    k.knude1 = null;
                }
                if(k.knude2 == x)
                {
                    k.knude2 = null;
                }
            }
            knudeList.Remove(x);
        }
        
        public Boolean Adjacent(Knude x, Knude y)
        {
            bool fuckRasmus = false;
            foreach (Kant k in kantList)
            {
            if(x == k.knude1 && y == k.knude2
                || x == k.knude2 && y == k.knude1)
            {
                fuckRasmus = true;
            }

            }
            return fuckRasmus;
        }

        public HashSet<Knude> Neighbors(Knude x)
        {
            HashSet<Knude> Knuden = new HashSet<Knude>();
            foreach (Kant k in kantList)
            {
                if(k.knude1 == x)
                {
                    Knuden.Add(k.knude2);
                }
                else if(k.knude2 == x)
                {
                    Knuden.Add(k.knude1);
                }
            }
            return Knuden;
        }

        public void Add_edge(Knude x, Knude y)
        {
            Kant kant = new Kant();
            kant.knude1 = x;
            kant.knude2 = y;
            kantList.Add(kant);
        }

        public int Get_vertex_value(Knude x)
        {
            return x.value;
        }

        public void Set_vertex_value(Knude x, int v)
        {
            x.value = v;
        }

        public void Set_edge_value(Knude x, Knude y, int v)
        {
            foreach (Kant k in kantList)
            {
                if(x == k.knude1 && y == k.knude2 ||
                    y == k.knude1 && x == k.knude2)
                {
                    k.weight = v; 
                }
            }
        }

        public int Get_edge_value(Knude x, Knude y)
        {
            int value = 0;
            foreach (Kant k in kantList)
            {
                if (x == k.knude1 && y == k.knude2 ||
                    y == k.knude1 && x == k.knude2)
                {
                    value = k.weight;
                }
            }
            return value;
        }
    }
}
