using System;

public class ArrayList<T>
{
    //main array
    private T[] bufferArr;

    public int Count { get; set; }

    public int Capacity;

    public ArrayList(int capacity = 2)
    {
        this.bufferArr = new T[capacity];
        this.Capacity = capacity;
    }

    public T this[int index]
    {
        get
        {
            //boundary chek
            if (index < 0 || index > this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            return this.bufferArr[index];
        }

        set
        {
            //boundary chek
            if (index < 0 || index > this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            this.bufferArr[index] = value;
        }
    }

    public void Add(T item)
    {
        //boundary chek
        if (this.Count + 1 >= this.Capacity)
        {
            this.Grow();
        }

        this.bufferArr[this.Count] = item;

        this.Count++;
    }

    private void Grow()
    {
        T[] growArr = new T[this.Capacity * 2];
        this.Capacity *= 2;

        Array.Copy(this.bufferArr, growArr, this.Count);

        this.bufferArr = growArr;
    }

    public T RemoveAt(int index)
    {
        T item = this[index];
        this[index] = default(T);
        this.ShiftLeft(index);
        if (this.Count - 1 < this.Capacity / 3)
        {
            this.Shrink();
        }
        this.Count--;
        return item;
    }

    private void Shrink()
    {
        T[] shArr = new T[this.Capacity / 3];
    }

    private void ShiftLeft(int index)
    {
        for (int i = index; i < this.Count; i++)
        {
            this.bufferArr[i] = this.bufferArr[i + 1];
        }
    }
}