using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;


namespace Workshop5_DoublyLinkedLists.Cor;

public class DoublyLinkedLists<T>
{
    private DoubleNode<T>? _tail;
    private DoubleNode<T>? _head;

    public DoublyLinkedLists()
    {
        _tail = null;
        _head = null;
    }

    //1.0
    public void InsertAtBeginning(T data)
    {
        var newNode = new DoubleNode<T>(data);
        if (_head == null)
        {
            _head = newNode; //--> Pointer
            _tail = newNode; //--> Pointer
        }
        else
        {
            newNode.Next = _head;
            _head.Prev = newNode;
            _head = newNode;
        }
    }

    //1.1
    public void InsertAtEnd(T data)
    {
        var newNode = new DoubleNode<T>(data);
        {
            if (_tail == null)
            {
                _head = newNode; //--> Pointer
                _tail = newNode; //--> Pointer
            }
            else
            {
                newNode.Prev = _tail;
                _tail.Next = newNode;
                _tail = newNode;
            }
        }
    }

    //2
    public string PrintForward()
    {
        List<T> datos = new List<T>();
        var current = _head;

        while (current != null)
        {
            datos.Add(current.Data!);
            current = current.Next;
        }

        datos.Sort(); // ordena alfabéticamente si T es string

        string resultado = string.Empty;
        foreach (var item in datos)
        {
            resultado += $"{item} <--> ";
        }

        return resultado.Length > 5 ? resultado.Substring(0, resultado.Length - 5) : resultado;
    }

    //3
    public string PrintBackwards()
    {
        var output = string.Empty;
        var current = _tail;

        while (current != null)
        {
            output += $"{current.Data} <--> ";
            current = current.Prev;
        }

        return output.Length > 5 ? output.Substring(0, output.Length - 5) : output;
    }

    //4    
    public string DesendingOrder()
    {
        List<T> datos = new List<T>();
        var current = _head;
        while (current != null)
        {
            datos.Add(current.Data!);
            current = current.Next;
        }
        datos.Sort();
        datos.Reverse();
        return string.Join(" <--> ", datos);
    }

    //5
    public void ShowMode()
    {

        if (_head == null)
        {
            Console.WriteLine("The list is empty.");
            return;
        }
        Dictionary<T, int> frequency = new Dictionary<T, int>();

        var current = _head;
        var ouput = string.Empty;

        while (current != null)
        {
            if (frequency.ContainsKey(current.Data!))
            {
                frequency[current.Data!]++;
            }
            else
            {
                frequency[current.Data!] = 1;
            }
            current = current.Next;
        }
        /*foreach (var par in frequency.OrderBy(p => p.Key))
        {
            
            Console.WriteLine($"The mode with plus option chosen is -> {par.Key}: {par.Value}");
        }
        */
        int maxFrequency = frequency.Values.Max();
        var modes = frequency.Where(pair => pair.Value == maxFrequency).Select(pair => pair.Key).ToList();
        Console.WriteLine($"Mode(s): { string.Join(", ", modes)} with a frequency of {maxFrequency}");
    }

    //6 
    public void ShowGraph()
    {
        if (_head == null)
        {
            Console.WriteLine("The list is empty.");
            return;
        }

        Dictionary<T, int> frequency = new Dictionary<T, int>();
        var current = _head;

        while (current != null)
        {
            if (frequency.ContainsKey(current.Data))
                frequency[current.Data]++;
            else
                frequency[current.Data] = 1;

            current = current.Next;
        }

        Console.WriteLine("Graph of frequencies:");
        foreach (var pair in frequency.OrderBy(p => p.Key))
        {
            Console.WriteLine($"{pair.Key}: {new string('*', pair.Value)}");
        }
    }
    
    //7
    public void Exist()
    {
        List<T> datos = new List<T>();
        var current = _head;
        while (current != null)
        {
            datos.Add(current.Data!);
            current = current.Next;
        }
        Console.WriteLine("Enter the data to search for:");
        var input = Console.ReadLine();
        if (input != null && datos.Contains((T)Convert.ChangeType(input, typeof(T))))
        {
            Console.WriteLine($"The data '{input}' exists in the list.");
        }
        else
        {
            Console.WriteLine($"The data '{input}' does not exist in the list.");
        }

    }

    //8
    public void DeleteOccurrence(T data)
    {
        var current = _head;
        while (current != null)
        {
            if (EqualityComparer<T>.Default.Equals(current.Data!, data))
            {
                if (current.Prev != null)
                {
                    current.Prev.Next = current.Next;
                }
                else
                {
                    _head = current.Next;
                }
                if (current.Next != null)
                {
                    current.Next.Prev = current.Prev;
                }
                else
                {
                    _tail = current.Prev;
                }
                return;
            }
            current = current.Next;
        }
    }

    //9
    public void Clear()
    {
        _head = null;
        _tail = null;
    }
}