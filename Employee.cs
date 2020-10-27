using System;

public class Employee
{
  private string firstname, lastname, id, address, phonenumber, title, employmentstatus;
  int age;
  double yearlysalary;
  public Employee()
  {
    firstname = "Unknown";
    lastname = "Unknown";
    id = "Unknown";
    age = 0;
    employmentstatus = "active";
  }
  public Employee(string Firstname, string Lastname, string Id, int Age)
  {
    firstname = Firstname;
    lastname = Lastname;
    id = Id;
    age = Age;
    employmentstatus = "Active";
  }
  public void intro()
  {
    Console.WriteLine("First Name: " + firstname);
    Console.WriteLine("Last Name: " + lastname);
    Console.WriteLine("ID: " + id);
    Console.WriteLine("Age: " + age);
    Console.WriteLine("Employment Status: " + employmentstatus);
  }
}