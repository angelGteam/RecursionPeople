using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionPeople {
    class Person {
        string name;
        public Person(string name) {
            this.name = name;
        }
        public void Greet(Person p1, Person p2) {
            Console.WriteLine($"{p1.name} said something to {p2.name}");
        }
    }
}
