using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionPeople {
    class Persona {
        string nombre;
        public Persona(string id) {
            this.nombre = id;
        }
        public void Saludar(Persona p1, Persona p2) {
            Console.WriteLine($"{p1.nombre} said something to {p2.nombre}");
        }
    }
}
