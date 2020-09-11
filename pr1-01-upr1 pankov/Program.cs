using System;

namespace pr1_01_upr1_pankov
{
  class Program
  {
    struct Person
    {
      public string firstName;
      public string LastName;
      public int age;

      public Person(string _firstName, string _lastName, int _age)
      {
        firstName = _firstName;
        LastName = _lastName; 
        age = _age;
      }
      public override string ToString()
      {
        return firstName + " " + LastName + ", age " + age;
      }
    }
    static void Main(string[] args)
    {
      Person p = new Person("Tony", "Allen", 32); Console.WriteLine(p);
    }
  }
}
