// Вид 1

void method1()
{
    Console.WriteLine("Method 1");
}

method1();



// Вид 2

void method2(string msg)
{
    Console.WriteLine(msg);
}

method2("Method 2");


void method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i += 1;
    }
    
}

// method21("Method 21", 4);
// method21(msg: "Method 21", count: 4);
method21(count: 4, msg: "Method _21_");



// Вид 3

int method3()
{
    return DateTime.Now.Year;
}

int year = method3();
Console.WriteLine(year);



// Вид 4

string method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = method4(10, "qwerty ");
Console.WriteLine(res);