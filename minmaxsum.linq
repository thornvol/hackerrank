<Query Kind="Program" />

void Main()
{
	string[] arr_temp = "1 2 3 4 5".Split(' ');
	int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
	miniMaxSum(arr);

}

// Define other methods and classes here
static void miniMaxSum(int[] arr)
{
	// Complete this function
	var length = arr.Length-1;
	var maxarray = GetMaxArray(arr, length);
	var minarray = GetMinArray(arr, length);
	Console.WriteLine(string.Format("{0} {1}", minarray.Sum(), maxarray.Sum()));
}

static long[] GetMaxArray(int[] arr, int length)
{
	var result = new long[length];
	Array.Sort(arr);
	for(var i = length; i > 0; i--)
	{
		result[i-1] = (long)arr[i];
	}
	
	return result;
}

static long[] GetMinArray(int[] arr, int length)
{
	var result = new long[length];
	Array.Sort(arr);
	for (var i = 0; i < length; i++)
	{
		result[i] = (long)arr[i];
	}

	return result;
}