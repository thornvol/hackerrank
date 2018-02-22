<Query Kind="Program" />

void Main()
{
	int n = 6;
	string[] arr_temp = "-4 3 -9 0 4 1".Split(' ');
	int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
	plusMinus(arr);
}

// Define other methods and classes here
static void plusMinus(int[] arr)
{
	// Complete this function
	var length = (double)arr.Length;
	
	// +
	var positive = (double)arr.Count(a => a > 0);
	var p = Math.Round(positive / length, 6).ToString("0.000000");
	Console.WriteLine(p);
	
	// -
	var negative = (double)arr.Count(a => a < 0);
	var n = Math.Round(negative / length, 6).ToString("0.000000");
	Console.WriteLine(n);
	
	// 0
	var zero = (double)arr.Count(a => a == 0);
	var z = Math.Round(zero / length, 6).ToString("0.000000");
	Console.WriteLine(z);
}