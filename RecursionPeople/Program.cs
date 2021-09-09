using System;

namespace RecursionPeople {
    class Program {
        static void Main(string[] args) {
            Person Juan = new Person("Juan");
            Person Pedro = new Person("Pedro");
            Person Angel = new Person("Angel");
            Person Selene = new Person("Selene");
            Person David = new Person("David");
            Person Ana = new Person("Ana");
            Person Nacho = new Person("Nacho");
            //Nacho.Saludar(Nacho, Juan);
            Person[] personas = {Juan, Pedro, Angel, Selene, David, Ana, Nacho};
            Console.WriteLine("The ammounts of jumps needed was: " + CalculateDistance(Juan, Nacho, 0, 0, personas));
        }
        static int CalculateDistance(Person persona1, Person persona2, int firstPosition, int quantityOfJumps, Person[] people) {
            if(persona2.Equals(people[firstPosition + 1])) {
                people[quantityOfJumps].Greet(people[quantityOfJumps], people[quantityOfJumps + 1]);
                return quantityOfJumps+1;
            }
            people[quantityOfJumps].Greet(people[quantityOfJumps], people[quantityOfJumps + 1]);
            quantityOfJumps +=1;
            firstPosition += 1;           
            return CalculateDistance(persona1,  persona2, firstPosition, quantityOfJumps, people);
        }

    }
}
