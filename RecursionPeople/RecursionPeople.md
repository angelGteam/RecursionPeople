RecursionPeople
Tu red social esta empezando y lo vas a petar, se va a llamar CaraLibro (no tienes equipo de marketing aún) 
Se te va a proveer de un array de personas y debes de indicar con cuantas personas ha de hablar para llegar
a otra personas

así pues

si tienes algo así

|Juan| Pedro| |Juan| Fernando| |Fernando| Maria| |Maria| Clara|

Saludar(Juan, Pedro) = Juan -> Pedro Saludar(Fernando, Maria) = Fernando -> Maria Saludar(Juan, Maria) = Juan -> Fernando -> Maria Saludar(Juan, Clara) = Juan -> Fernando -> Maria -> Clara Saludar(Juan, Luis) = not found

Extra Saludar(Pedro, Fernando) = Pedro -> Fernando -