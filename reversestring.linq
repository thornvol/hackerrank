<Query Kind="Program" />

void Main()
{
	var test = "hello world";
	reverse(test).Dump();
}

// Define other methods and classes here
static string reverse(string test)
{
	var result = new string[test.Length];
	var counter = 0;
	for(var i = test.Length-1; i >= 0; i--)
	{
		result[counter] = test[i].ToString();
		counter++;
	}
	
	return string.Join("",result);
}
