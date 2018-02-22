<Query Kind="Program" />

void Main()
{
	var arr = new string[] { "31415926535897932384626433832795", "1", "3", "10", "3", "5" };
	//var arr = new string[] { "89", "1", "3", "10", "3", "5", "101", "205", "10321" };
	//var arr = Enumerable.Range(1, 50).Reverse().Select(e => e.ToString()).ToArray();
	bigSorting(arr).Dump();
	arr.Dump();
}

// Define other methods and classes here
static string[] bigSorting(string[] arr)
{
	Array.Sort(arr, new CustomComparer());
	return arr;
}

internal class CustomComparer : IComparer<string>
{
	public int Compare(string x, string y)
	{
		// If the length is not the same, we return the difference.
		// A negative # means, x Length is shorter, 0 means the same (this doesn't occur) and a postive # means Y is bigger
		if (x.Length != y.Length) return x.Length - y.Length;

		// Now the length is the same.
		// Compare the number from the first digit.
		for (int i = 0; i < x.Length; i++)
		{
			char left = x[i];
			char right = y[i];
			if (left != right)
				return left - right;
		}

		// Default: "0" means both numbers are the same.
		return 0;
	}
}