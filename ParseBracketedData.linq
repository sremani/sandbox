void Main()
{
	const string bracketedData = "   [10, 20.8, 30.88] ";
	bracketedData.ToFloatArray()
		.Dump();
}

// You can define other methods, fields, classes and namespaces here

public static class StringExtension
{
	public static float[] ToFloatArray(this string data) =>
		Regex.Replace(data, "\\[|\\]| ", "")	// clean - remove spaces and brackets
				.Split(',')						// split
				.Select(s => float.Parse(s))	// parse
				.ToArray();						// package
}
