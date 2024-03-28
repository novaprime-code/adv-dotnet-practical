using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void PrintDetails()
    {
        Console.WriteLine("############  Method From Person Class (Parent) ############");
        Console.WriteLine("\tName: " + Name + ", \n\tAge : " + Age);
    }
}

class Student : Person
{
    public string StudentID { get; set; }
    public Student(string name, int age, string studentID) : base(name, age)
    {
        StudentID = studentID;
    }
    public void PrintDetails()
    {
        Console.WriteLine("\n############  Method From Student Class (Child)  ###########");
        Console.WriteLine("\tName: " + Name + ",\n\tAge : " + Age + ",\n\tStudentID : " + StudentID);
    }
}

class Q1_Constructor
{
    static void Main(string[] args)
    {
        Console.WriteLine("################  ADV. .NET Lab Practical  ################");
        Console.WriteLine("##############  Inheritance and Constructor  ##############\n");

        Person p1 = new Person("Nova Prime", 25);
        p1.PrintDetails();

        Student s1 = new Student("Optimus Prime", 30, "12345");
        s1.PrintDetails();

        Console.ReadKey();
    }
}