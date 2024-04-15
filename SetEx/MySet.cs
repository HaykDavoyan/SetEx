using System.Collections;
namespace SetEx;

public class MySet<T> : IEnumerable<T>
    where T : IComparable<T>
{
    private readonly List<T> _items = new List<T>();

    public MySet()
    {

    }
    public MySet(IEnumerable<T> items)
    {
        AddRange(items);
    }

    public void Add(T item)
    {
        if (Contains(item))
        {
            throw new InvalidOperationException("Item already exists in Set");
        }
        _items.Add(item);
    }
    public void AddRange(IEnumerable<T> items)
    {
        foreach (T item in items)
        {
            Add(item);
        }
    }
    public bool Remove(T item)
    {
        return _items.Remove(item);
    }
    public bool Contains(T item)
    {
        return (_items.Contains(item));
    }
    public int Count
    {
        get
        {
            return _items.Count;
        }
    }
    public MySet<T> Union(MySet<T> other)
    {
        var union = new MySet<T>(_items);
        foreach (T item in other)
        {
            if (!union.Contains(item))
                union.Add(item);
        }
        return union;
    }

    public MySet<T> Intersection(MySet<T> other)
    {
        var intersection = new MySet<T>();
        foreach (T item in _items)
        {
            if (other.Contains(item))
                intersection.Add(item);
        }
        return intersection;
    }

    public MySet<T> Difference(MySet<T> other)
    {
        var difference = new MySet<T>(_items);
        foreach (T item in other)
        {
            difference.Remove(item);
        }
        return difference;
    }

    public MySet<T> SymmetricDifference(MySet<T> other)
    {
        var symmetricDifference = new MySet<T>();
        foreach (T item in _items)
        {
            if (!other.Contains(item))
                symmetricDifference.Add(item);
        }

        foreach (T item in other)
        {
            if (!_items.Contains(item))
                symmetricDifference.Add(item);
        }
        return symmetricDifference;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return _items.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)_items).GetEnumerator();
    }
}
