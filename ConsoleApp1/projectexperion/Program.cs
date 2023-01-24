//////void Greet() => Console.WriteLine("Hello World");
//////Greet ()
//////int Add (int x, int y) => x + y;

//////var res = Add(1, 2);
//////Console.WriteLine (res);
//////null coalescing operator 

//////string? data = "This is a text";
//////var res = data ?? "Default data";
//////Console.WriteLine(res);


//////string? data = null;

//////data ??= "Default data";
//////Console.WriteLine(data);




//////var day = Days.Monday;
//////Console.WriteLine(day);

//////enum Days
//////{
//////    Monday,
//////    Tuesday,
//////    Wednesday,
//////    Thursday,   
//////    Friday, 
//////    Saturday
//////}


//////var day = Days.Monday;
//////int d = (int)day;
//////Console.WriteLine(d);

//////enum Days
//////{
//////   Monday,
////// Tuesday,
//////Wednesday,
//////Thursday,
//////Friday,
//////Saturday
//////}





//////Days day = 0;
//////Console.WriteLine(day);
//////enum Days
//////{
//////    Monady,
//////    Tuesday,
//////    Wednesday,
//////    Thursday
//////}


////string ConvertCasing(string text, Option option)
////{
////    switch (option)
////    {
////        case Option.UpperCase:
////            return text.ToUpper();
////        case Option.Lowercase:
////            return text.ToLower();
////        default:
////            return text;
////    }
////}

////var s =ConvertCasing("HelLo", Option.UpperCase);
////Console.WriteLine(s);
////enum Option
////{
////    UpperCase,
////    Lowercase
////}


//using LearnCSharpSoftware;
//var obj = new Student()
//{
//    nameof = "student 1",
//    age = 25
//};
//Console.WriteLine(Student.schoolNam); 







using projectexperion;

var obj = new Student()
{
    Name = "Student 1",
    Age = 25
};
Console.WriteLine(Student.SchoolName);
