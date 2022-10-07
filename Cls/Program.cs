using Cls;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Class2 tom = new Class2();
Class1 tom1 = new Class1("Peter");
//tom.name = "Павел";
//tom.Print();
Console.WriteLine(tom1.name);

Person p = new Person { name = "Tom", age = 23 };
ChangePerson(p);

Console.WriteLine(p.name); // Alice
Console.WriteLine(p.age); // 23

void ChangePerson(Person person)
{
// сработает
person.name = "Alice";
// сработает только в рамках данного метода
person = new Person { name = "Bill", age = 45 };
Console.WriteLine(person.name); // Bill
}

class Person
{
    public string name = "";
    public int age;
}