using static System.Net.Mime.MediaTypeNames;
using System.Drawing;


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
    
    public string GetForward()
    {    
        var output = string.Empty;
        var current = _head;

        while (current != null)
        {
            output += ($"{current.Data} <--> ");
            current = current.Next;
        }
        return output. Substring(0, output.Length -5);
    }

    public string GetBackward()
    {
        var output = string.Empty;
        var current = _tail;

        while (current != null)
        {
            output += ($"{current.Data} <--> ");
            current = current.Prev;
        }
        return output.Substring(0, output.Length -5);
    }
}
