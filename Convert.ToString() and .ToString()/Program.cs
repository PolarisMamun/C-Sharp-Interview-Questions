//What is the difference between Convert.toString and .toString() method ?

object a = null;
Console.WriteLine(Convert.ToString(a));//Output:""
Console.WriteLine(a.ToString());//System.NullReferenceException: 'Object reference not set to an instance of an object.'
Console.ReadLine();
