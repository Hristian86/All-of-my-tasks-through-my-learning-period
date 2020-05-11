using System;
using System.Collections;
using System.Collections.Generic;

public class DoublyLinkedList<T> : IEnumerable<T>
{
    private class Node<T>
    {
        //value of the node
        public T Value { get; set; }

        //refference to next node
        public Node<T> NextNode { get; set; }

        //refference to previos node
        public Node<T> PreviosNode { get; set; }

        public Node(T value)
        {
            this.Value = value;
        }
    }

    private Node<T> Head;
    private Node<T> Tail;
    private T[] toArray;

    public int Count { get; private set; }

    public void AddFirst(T element)
    {
        if (this.Count == 0)
        {
            this.Head = this.Tail = new Node<T>(element);
        }
        else
        {
            var newNode = new Node<T>(element);
            newNode.NextNode = this.Head;
            this.Head.PreviosNode = newNode;
            this.Head = newNode;
        }

        this.Count++;
    }

    public void AddLast(T element)
    {
        if (this.Count == 0)
        {
            this.Head = this.Tail = new Node<T>(element);
        }
        else
        {
            var newNode = new Node<T>(element);
            newNode.PreviosNode = this.Tail;
            this.Tail.NextNode = newNode;
            this.Tail = newNode;
        }
        this.Count++;
    }

    public T RemoveFirst()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }
        
        var firstNode = this.Head.Value;
        this.Head = this.Head.NextNode;
        if (this.Head != null)
        {
            this.Head.PreviosNode = null;
        }
        else
        {
            this.Tail = null;
        }
        this.Count--;
        return firstNode;
    }

    public T RemoveLast()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }

        var lastNode = this.Tail.Value;
        this.Tail = this.Tail.PreviosNode;
        if (this.Tail != null)
        {
            this.Tail.NextNode = null;
        }
        else
        {
            this.Head = null;
        }
        this.Count--;
        return lastNode;
    }

    public void ForEach(Action<T> action)
    {
        var currentNode = this.Head;
        while (currentNode != null)
        {
            action(currentNode.Value);
            currentNode = currentNode.NextNode;
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        var currentNode = this.Head;
        while (currentNode != null)
        {
            yield return currentNode.Value;
            currentNode = currentNode.NextNode;
        }

    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public T[] ToArray()
    {
        this.toArray = new T[this.Count];

        var currentNode = this.Head;
        int i = 0;
        while (currentNode != null)
        {
            this.toArray[i] = currentNode.Value;
            currentNode = currentNode.NextNode;
            i++;
        }
        return this.toArray;
    }
}


class Example
{
    static void Main()
    {
        var list = new DoublyLinkedList<int>();

        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");

        list.AddLast(5);
        list.AddFirst(3);
        list.AddFirst(2);
        list.AddLast(10);
        Console.WriteLine("Count = {0}", list.Count);

        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");

        list.RemoveFirst();
        list.RemoveLast();
        list.RemoveFirst();

        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");

        list.RemoveLast();

        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");
    }
}