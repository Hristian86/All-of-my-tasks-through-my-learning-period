using System;
using System.Collections;
using System.Collections.Generic;

public class LinkedList<T> : IEnumerable<T>
{
    private Node head;

    private Node tail;

    public int Count { get; private set; }

    public LinkedList()
    {
        this.head = null;
        this.tail = null;
        this.Count = 0;
    }

    public void AddFirst(T item)
    {
        // TODO
        Node currentNode = new Node(item);
        if (this.Count == 0)
        {
            this.head = currentNode;
            this.tail = currentNode;
        }
        else
        {
            currentNode.next = this.head;
            this.head = currentNode;
        }
        this.Count++;
    }

    public void AddLast(T item)
    {
        Node currentNode = new Node(item);
        if (this.Count == 0)
        {
            this.head = currentNode;
            this.tail = currentNode;
        }
        else
        {
            this.tail.next = currentNode;
            this.tail = currentNode;
        }
        this.Count++;
    }

    public T RemoveFirst()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }

        T element = this.head.value;
        if (this.Count == 1)
        {
            this.head = null;
            this.tail = null;
        }
        else
        {
            this.head = this.head.next;
        }
        this.Count--;
        return element;
    }

    public T RemoveLast()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }

        T element = this.tail.value;
        if (this.Count == 1)
        {
            this.head = null;
            this.tail = null;
        }
        else
        {
            Node perant = this.head;
            while (perant.next != tail)
            {
                perant = perant.next;
            }
            perant.next = null;
            this.tail = perant;
        }
        this.Count--;
        return element;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node start = this.head;
        while (start != null)
        {
            yield return start.value;
            start = start.next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    private class Node
    {
        public T value { get; set; }

        public Node next { get; set; }

        public Node(T value)
        {
            this.value = value;
        }

    }

}