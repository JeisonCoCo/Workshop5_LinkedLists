using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Workshop5_DoublyLinkedLists.Cor;

public class DoubleNode<T>
{
    public DoubleNode(T data) //Constructor whit pointers
    {
        Data = data;
        Next = null;
        Prev = null;
    }
        public DoubleNode<T>? Prev { get; set; }
        public T? Data { get; set; }
        public DoubleNode<T>? Next { get; set; }    
}
