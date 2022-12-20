// Вид 1
void Method1(){
 Console.WriteLine("Автор ...");   
}
Method1();


// Вид 2 
void Method2(string msg){
 Console.WriteLine(msg);   
}
Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
      Console.WriteLine(msg); 
      i++;
    }   
}
Method21(msg:"Текст сообщения", count: 4);

// вид 3 что-то возвращают но ничего не принимают

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);


//Вид 4 что-то принимают и что-то возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; //пустая строка

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf");
Console.WriteLine(res);


string Method41(int count, string text)
{
    
    string result = String.Empty; //пустая строка
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string resFor = Method41(10, "asdf");
Console.WriteLine(resFor);


// Цикл в цикле
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
    Console.WriteLine($"{i} * {j} = {i*j}");
    }
Console.WriteLine();
}