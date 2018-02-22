<Query Kind="Program" />

void Main()
{
	//string s = Console.ReadLine();
	string s = "12:05:00PM"; //"07:05:45PM";
	string result = timeConversion(s);
	Console.WriteLine(result);
}

// Define other methods and classes here
static string timeConversion(string s)
{
	// Complete this function
	var timeArray = s.Split(':');
	var hh = timeArray[0];
	var mm = timeArray[1];
	var ss = timeArray[2].Substring(0,2);
	var tt = timeArray[2].Substring(2,2);
	
	var h = Convert.ToInt32(hh);

	
	if(tt.ToLower() == "am")
	{
		if(h == 12){
			h = 0;
		}
	}
	
	if(tt.ToLower() == "pm")
	{
		if(h != 12)
		{
			h += 12;
		}
	}
	
	var HH = AddLeadingZero(h.ToString());
	
	var result = string.Format("{0}:{1}:{2}", HH, mm, ss);
	
	return result;
}

static string AddLeadingZero(string hh)
{
	if(hh.Length == 1)
	{
		return "0" + hh;
	}
	return hh;
}