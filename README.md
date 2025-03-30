# P6.-Implementaci-n-y-Operaciones-en-Grafos
En el codigo realizamos un grafo el cual nos permite interactuar con el, ya sea haciendolo dirigido o no dirigido, en este podemos agregar nodos y aristas al igual que recorrerlo, ya sea por el ancho o por lo profundo.
Sus funciones principales son:

Agregar nodos: Permite añadir vértices únicos al grafo.
Agregar aristas: Relaciona dos nodos mediante una conexión (dirigida o no dirigida).
Recorrido BFS (Búsqueda en Anchura) explora los nodos nivel por nivel desde un nodo inicial.
Recorrido DFS (Búsqueda en Profundidad) recorre el grafo siguiendo caminos completos antes de retroceder.

En este agregamos la clase grafo y la clase program, en donde:

La clase grafo tiene toda la estructura para crear el grafo, agregar nodos, aristas  las maneras en las que se va a recorrer
En la clase program podemos encontrar el menu del programa y como este manda a llamar a las funciones encontradas en la clase grafo

Un ejemplo del funcionamiento de este seria el siguiente:
(Este es el copy paste del menu al ejecutar el programa, en este agregamos los nodos "A", "B" y "C" y los unimos por aristas para despues recorrerlo por lo ancho)
¿El grafo es dirigido? (s/n):
s

Menú:
1. Agregar Nodo
2. Agregar Arista
3. Recorrer BFS
4. Recorrer DFS
5. Salir
Selecciona una opción: 1
Nombre del nodo: A
Nodo 'A' agregado.

Menú:
1. Agregar Nodo
2. Agregar Arista
3. Recorrer BFS
4. Recorrer DFS
5. Salir
Selecciona una opción: 1
Nombre del nodo: B
Nodo 'B' agregado.

Menú:
1. Agregar Nodo
2. Agregar Arista
3. Recorrer BFS
4. Recorrer DFS
5. Salir
Selecciona una opción: 1
Nombre del nodo: C
Nodo 'C' agregado.

Menú:
1. Agregar Nodo
2. Agregar Arista
3. Recorrer BFS
4. Recorrer DFS
5. Salir
Selecciona una opción: 2
Nodo origen: A
Nodo destino: C
Arista de 'A' a 'C' agregada.

Menú:
1. Agregar Nodo
2. Agregar Arista
3. Recorrer BFS
4. Recorrer DFS
5. Salir
Selecciona una opción: 2
Nodo origen: B
Nodo destino: A
Arista de 'B' a 'A' agregada.

Menú:
1. Agregar Nodo
2. Agregar Arista
3. Recorrer BFS
4. Recorrer DFS
5. Salir
Selecciona una opción: 2
Nodo origen: C
Nodo destino: A
Arista de 'C' a 'A' agregada.

Menú:
1. Agregar Nodo
2. Agregar Arista
3. Recorrer BFS
4. Recorrer DFS
5. Salir
Selecciona una opción: 3
Nodo de inicio para BFS: A
BFS Recorrido:
A C
