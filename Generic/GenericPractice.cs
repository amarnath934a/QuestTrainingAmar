using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GenericDictionary<TKey, TValue>
{
    private Dictionary<TKey, TValue> _data = new Dictionary<TKey, TValue>();

    public void Add(TKey key, TValue value) => _data[key] = value;

    public void Remove(TKey key) => _data.Remove(key);
}

class Program
{
    static void Main(string[] args)
    {
        var dictionary = new GenericDictionary<int, string>();
        dictionary.Add(1, "First Entry");
        Console.WriteLine(dictionary.ToString());
        dictionary.Remove(1);
        Console.ReadKey();
    }
}