<Query Kind="Program" />

void Main()
{
	//int n = Convert.ToInt32(Console.ReadLine());
	int n = Convert.ToInt32("6");
	staircase(n);
}

// Define other methods and classes here
static void staircase(int n)
{
	for(var i = 0; i < n; i++)
	{
		var output = fillSpaces(n);
		for(var j = 0; j <= i; j++)
		{
			output[j] = "#";
		}
		Console.WriteLine(string.Join("", output.Reverse()));
	}
	
}

static string[] fillSpaces(int n)
{
	var result = new string[n];
	for(int i =0; i < n; i++)
	{
		result[i] = " ";
	}
	return result;
}