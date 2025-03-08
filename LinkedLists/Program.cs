// using LinkedLists;

class Node {
    public int Value;           // value stored at node
    public Node Next;           // pointer to next node
    
    public Node(int value) {
        Value = value;
        Next = null;
    }
}

class SinglyLinkedList {
    public Node Head;
    public Node Tail;

    public void InsertAtTail(int data) {
        Node NewNode = new(data);

        if (Head == null) {
            Head = NewNode;
            Tail = NewNode;
            // Console.WriteLine("First node added to Linked list." + $"{NewNode.Value}");
            return;
        }

        Tail.Next = NewNode;
        Tail = NewNode;
    }

    public void InsertAtHead(int data) {
        Node NewNode = new(data);

        // Empty 
        if (Head == null) {
            Head = NewNode;
            Tail = NewNode;
            // Console.WriteLine("First node added to Linked list." + $"{NewNode.Value}");
            return;
        }

        // Non-empty
        NewNode.Next = Head;
        Head = NewNode;
    }

    // ASC, DSC, PART
    public void InsertInBetween(int data, string mode = "PART") {
        switch(mode) {
            case "PART": 
                Console.WriteLine("Enter value: ");
                int PartnerValue = Convert.ToInt32(Console.ReadLine());
                
                Node NewNode = new(data);
                Node Temp = Head;
                while (Temp.Value != PartnerValue) {
                    Temp = Temp.Next;
                }

                // What if user adds an element at tail
                // instead of using tail function?
                if (Temp.Next == null) {
                    InsertAtTail(data);
                    return;
                }

                NewNode.Next = Temp.Next;
                Temp.Next = NewNode;

                break;
            case "ASC":
                break;
            case "DSC":
                break;
            default: 
                Console.WriteLine("Invalid mode.");
                break;
        }
    }

    public void Display() {
        if (Head == null) {
            Console.WriteLine("Linked list is non-existent.");
            return;
        }

        Node Temp = Head;

        while (Temp != null) {  
            Console.Write($"{Temp.Value} -> ");
            Temp = Temp.Next;
        }
        Console.WriteLine("NULL");
    }
}

class DoublyLLNode : Node {
    public DoublyLLNode Previous;
    public new DoublyLLNode Next;

    public DoublyLLNode(int data) : base(data) {
        Previous = null;
        Next = null;
    }
}

class DoublyLinkedList {
    DoublyLLNode Head;
    DoublyLLNode Tail;

    public void InsertAtHead(int data) {
        DoublyLLNode NewNode = new(data);
        
        if (Head == null) {
            Head = NewNode;
            Tail = NewNode;
            return;
        }

        Head.Previous = NewNode;
        NewNode.Next = Head;
        Head = NewNode;
    }

    public void InsertAtTail(int data) {
        DoublyLLNode NewNode = new(data);
        
        if (Head == null) {
            Head = NewNode;
            Tail = NewNode;
            return;
        }

        Tail.Next = NewNode;
        NewNode.Previous = Tail;
        Tail = NewNode;
    }

    public void Display() {
        if (Head == null) {
            Console.WriteLine("Linked list is non-existent.");
            return;
        }

        DoublyLLNode Temp = Head;

        while (Temp != null) {  
            Console.Write($"{Temp.Value} -> ");
            Temp = Temp.Next;
        }
        Console.WriteLine("NULL");
    }
}

class Program {
    public static void Main(string[] args) {
        // SinglyLinkedList SLList = new();
        // SLList.InsertAtHead(40);
        // SLList.InsertAtHead(20);
        // SLList.InsertAtHead(30);
        // SLList.InsertAtTail(56);
        // SLList.InsertAtHead(23);
        // SLList.InsertInBetween(28);
        // SLList.Display();

        DoublyLinkedList DLList = new();
        DLList.InsertAtHead(49);
        DLList.InsertAtTail(65);
        DLList.InsertAtHead(50);
        DLList.Display();
    }
}