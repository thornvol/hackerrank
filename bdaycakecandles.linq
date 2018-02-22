<Query Kind="Program" />

void Main()
{
	//	int n = Convert.ToInt32(Console.ReadLine());
	//	string[] ar_temp = Console.ReadLine().Split(' ');
	int n = Convert.ToInt32(4);
	string[] ar_temp = "3 2 1 3".Split(' ');
	int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
	int result = birthdayCakeCandles(n, ar);
	Console.WriteLine(result);
}

// Define other methods and classes here
static int birthdayCakeCandles(int n, int[] ar)
{
	// Complete this function
	
	// Sort (asc)
	Array.Sort(ar);
	// Get max
	var max = GetMax(ar);
	
	// Count items with max value
	return CountValues(ar, max);
}

static int GetMax(int[] ar)
{
	var max = ar[0];
	for(var i = 0; i < ar.Length; i++)
	{
		if(ar[i] > max)
		{
			max = ar[i];
		}
	}
	return max;
}

static int CountValues(int[] ar, int value)
{
	return Array.FindAll(ar, (a) => a == value).Length;
//	var count = 0;
//	for (var i = 0; i < ar.Length; i++)
//	{
//		if (ar[i] == value)
//		{
//			count++;
//		}
//	}
//	return count;
}