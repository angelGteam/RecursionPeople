using System;

namespace RecursionPeople {
    class Program {
        static void Main(string[] args) {
            Persona Juan = new Persona("Juan");
            Persona Pedro = new Persona("Pedro");
            Persona Angel = new Persona("Angel");
            Persona Selene = new Persona("Selene");
            Persona David = new Persona("David");
            Persona Ana = new Persona("Ana");
            Persona Nacho = new Persona("Nacho");
            //Nacho.Saludar(Nacho, Juan);
            Persona[] personas = {Juan, Pedro, Angel, Selene, David, Ana, Nacho};
            Console.WriteLine("Se ha dado una cantidad de saltos de: " + calcularSaltos(Juan, Nacho, 0, 0, personas));

        }
        static int calcularSaltos(Persona persona1, Persona persona2, int firstPosition, int cantidadSaltos, Persona[] personas) {
            if(persona2.Equals(personas[firstPosition + 1])) {
                return cantidadSaltos+1;
            }
            5personas[cantidadSaltos].Saludar(personas[cantidadSaltos], personas[cantidadSaltos + 1]);
            cantidadSaltos+=1;
            firstPosition += 1;
            return calcularSaltos(persona1,  persona2, firstPosition, cantidadSaltos, personas);
        }

    }
}
