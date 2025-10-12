using Workshop5_DoublyLinkedLists.Cor;


var list = new DoublyLinkedLists<string>();
list.InsertAtBeginning("Perro");
list.InsertAtBeginning("Gato");
list.InsertAtEnd("Loro");
Console.WriteLine(list.GetForward());
Console.WriteLine(list.GetBackward());