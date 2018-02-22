<Query Kind="Program" />

void Main()
{
	Insert(null, 2).Dump("Test Case 1");
	Insert(new Node{ Data = 2, Next = null}, 3).Dump("Test Case 2");
	Insert(new Node { Data = 2, Next = new Node { Data = 3, Next = null } }, 4).Dump("Test Case 3");
	Insert(new Node { Data = 2, Next = new Node { Data = 3, Next = new Node { Data = 4, Next = null } } }, 5).Dump("Test Case 4");
}

// Define other methods and classes here
public static Node Insert(Node head, int x)
{
	// Is Empty
	if (head == null)
	{
		head = new Node { Data = x, Next = null };
	}
	// At the last node, insert as last node
	else if (head.Next == null)
	{
		head.Next = new Node { Data = x, Next = null };
	}
	// Else, keep trying
	else
	{
		Insert(head.Next, x);
	}

	return head;
}

public class Node
{
	public int Data;
	public Node Next;
}
