using Workshop5_DoublyLinkedLists.Cor;

var option = string.Empty;
var list = new DoublyLinkedLists<string>();

do
{
    option = Menu();
    switch (option)
    {
        case "1":
            Console.WriteLine("You chose to add data.");
            string option2 = string.Empty;
            bool opcionValida = false;

            do
            {
                Console.WriteLine("Where do you want to insert the data?");
                Console.WriteLine("\t -> a) At the beginning");
                Console.WriteLine("\t -> b) At the end");
                Console.WriteLine("------------------------------------------------");

                option2 = Console.ReadLine()!;

                switch (option2)
                {
                    case "a":
                        Console.Write("Enter the data to add at the beginning: ");
                        var dataAtBeginning = Console.ReadLine();
                        if (dataAtBeginning != null)
                            list.InsertAtBeginning(dataAtBeginning);
                        opcionValida = true;
                        break;

                    case "b":
                        Console.Write("Enter the data to add at the end: ");
                        var dataGetAtEnd = Console.ReadLine();
                        if (dataGetAtEnd != null)
                            list.InsertAtEnd(dataGetAtEnd);
                        opcionValida = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose 'a' or 'b'.");
                        break;
                }

            } while (!opcionValida);

            break;

        case "2":
            Console.WriteLine(list.PrintForward());
            Console.WriteLine("------------------------------------------------");
            break;

        case "3":
            Console.WriteLine(list.PrintBackwards());
            Console.WriteLine("------------------------------------------------");
            break;

        case "4":
            Console.WriteLine(list.DesendingOrder());
            Console.WriteLine("------------------------------------------------");
            break;

        case "5":
            list.ShowMode();
            Console.WriteLine("------------------------------------------------");
            break;

        case "6":
            list.ShowGraph();
            Console.WriteLine("------------------------------------------------");
            break;

        case "7":
            list.Exist();
            Console.WriteLine("------------------------------------------------");
            break;
    }
}
while (option != "0");

string Menu()
{
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine("1. Add at the beginning or at the end?.");
    Console.WriteLine("2. Show Beginning.");
    Console.WriteLine("3. Show List end.");
    Console.WriteLine("4. Arrange descendently.");
    Console.WriteLine("5. Show the mode(s).");
    Console.WriteLine("6. Show Graph");
    Console.WriteLine("7. There is.");
    Console.WriteLine("8. Delete an occurrence.");
    Console.WriteLine("9. Delete all occurrences.");
    Console.WriteLine("0. Exit.");
    Console.WriteLine("------------------------------------------------");

    return Console.ReadLine() ?? "0";
}
Console.WriteLine("desea continuar?... 1 [si] or 0 [no]");
option = Console.ReadLine();