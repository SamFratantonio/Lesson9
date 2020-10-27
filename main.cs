using System;

class MainClass {
  public static void Main (string[] args) {
    Employee e1 = new Employee();
    Employee e2 = new Employee("John", "Smith", "1234", 45);
    e1.intro();
    e2.intro();
  }
}