using System;
using System.Collections;
//using System.Collections.Generic;

//ref link:https://www.youtube.com/watch?v=u4yaUd4hWzQ&list=PLRwVmtr-pp07QlmssL4igw1rnrttJXerL&index=12
//ctrl+shift+space --- check details 
// list -- are dynamic, can grow and shrink
// list -- manage array underneath

class MeList<T>
{
    T[] items = new T[5];
    int count;
    public void Add(T item)
    {
        if (count == items.Length)
            Array.Resize(ref items, items.Length * 2);  // resize the underlying containers --- add slots by x2 of previous slot
        items[count++] = item;
    }
}

static class MainClass
{
    static void Main()
    {
        //int[] ints = new int[] { 25, 34, 32 };
        //ArrayList myPartyAges = new ArrayList();    // none generic
        //myPartyAges.Add(25);
        //myPartyAges.Add(34);
        //myPartyAges.Add("Billy");
        //myPartyAges.Add(32);
        //myPartyAges.Add(99);
        //List<int> myPartyAges2 = new List<int>();   //generic list
        MeList<int> myPartyAges2 = new MeList<int>();
        //new System.Collections.Generic.List<int>()
        myPartyAges2.Add(25);
        myPartyAges2.Add(34);
        myPartyAges2.Add(32);
        myPartyAges2.Add(99);
        myPartyAges2.Add(55);

        myPartyAges2.Add(43);
        myPartyAges2.Add(36);
        myPartyAges2.Add(36);
        myPartyAges2.Add(36);
        //myPartyAges2.Remove(2);
        //foreach(int i in myPartyAges2)
        //    Console.WriteLine(i);
    }
}