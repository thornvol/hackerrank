<Query Kind="Program" />

void Main()
{
	Insert(null, 1).Dump("Test Case 1");
	Insert(new Node{ Data = 1, Next = null}, 2).Dump("Test Case 2");
	Insert(new Node { Data = 2, Next = new Node { Data = 1, Next = null } }, 3).Dump("Test Case 3");
	Insert(new Node { Data = 3, Next = new Node { Data = 2, Next = new Node { Data = 1, Next = null } } }, 4).Dump("Test Case 4");
}

// Define other methods and classes here
public static Node Insert(Node head, int x)
{
	// If empty, set to head
	Node temp;
	if(head == null)
	{
		temp = new Node { Data = x, Next = null};
	}
	else
	{
		temp = new Node { Data = x, Next = head};
	}

	return temp;
}

public class Node
{
	public int Data;
	public Node Next;
}