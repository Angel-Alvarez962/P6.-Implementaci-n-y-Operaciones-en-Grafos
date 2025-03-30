using System;
using System.Collections.Generic;

class Grafo
{
    private Dictionary<string, List<string>> adyacencia;
    private bool esDirigido;

    public Grafo(bool esDirigido)
    {
        this.esDirigido = esDirigido;
        adyacencia = new Dictionary<string, List<string>>();
    }

    public void AgregarNodo(string nodo)
    {
        if (!adyacencia.ContainsKey(nodo))
        {
            adyacencia[nodo] = new List<string>();
            Console.WriteLine($"Nodo '{nodo}' agregado.");
        }
        else
        {
            Console.WriteLine($"El nodo '{nodo}' ya existe.");
        }
    }

    public void AgregarArista(string origen, string destino)
    {
        if (!adyacencia.ContainsKey(origen) || !adyacencia.ContainsKey(destino))
        {
            Console.WriteLine("Ambos nodos deben existir.");
            return;
        }

        adyacencia[origen].Add(destino);
        if (!esDirigido)
        {
            adyacencia[destino].Add(origen);
        }
        Console.WriteLine($"Arista de '{origen}' a '{destino}' agregada.");
    }

    public void BFS(string inicio)
    {
        if (!adyacencia.ContainsKey(inicio))
        {
            Console.WriteLine("El nodo inicial no existe.");
            return;
        }

        var visitados = new HashSet<string>();
        var cola = new Queue<string>();

        cola.Enqueue(inicio);
        visitados.Add(inicio);

        Console.WriteLine("BFS Recorrido:");
        while (cola.Count > 0)
        {
            var nodo = cola.Dequeue();
            Console.Write($"{nodo} ");

            foreach (var vecino in adyacencia[nodo])
            {
                if (!visitados.Contains(vecino))
                {
                    visitados.Add(vecino);
                    cola.Enqueue(vecino);
                }
            }
        }
        Console.WriteLine();
    }

    public void DFS(string inicio)
    {
        if (!adyacencia.ContainsKey(inicio))
        {
            Console.WriteLine("El nodo inicial no existe.");
            return;
        }

        var visitados = new HashSet<string>();
        var pila = new Stack<string>();

        pila.Push(inicio);

        Console.WriteLine("DFS Recorrido:");
        while (pila.Count > 0)
        {
            var nodo = pila.Pop();
            if (!visitados.Contains(nodo))
            {
                visitados.Add(nodo);
                Console.Write($"{nodo} ");
            }

            foreach (var vecino in adyacencia[nodo])
            {
                if (!visitados.Contains(vecino))
                {
                    pila.Push(vecino);
                }
            }
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¿El grafo es dirigido? (s/n): ");
        bool esDirigido = Console.ReadLine().ToLower() == "s";
        Grafo grafo = new Grafo(esDirigido);

        while (true)
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Agregar Nodo");
            Console.WriteLine("2. Agregar Arista");
            Console.WriteLine("3. Recorrer BFS");
            Console.WriteLine("4. Recorrer DFS");
            Console.WriteLine("5. Salir");

            Console.Write("Selecciona una opción: ");
            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Por favor, selecciona una opción válida.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Console.Write("Nombre del nodo: ");
                    string nodo = Console.ReadLine();
                    grafo.AgregarNodo(nodo);
                    break;

                case 2:
                    Console.Write("Nodo origen: ");
                    string origen = Console.ReadLine();
                    Console.Write("Nodo destino: ");
                    string destino = Console.ReadLine();
                    grafo.AgregarArista(origen, destino);
                    break;

                case 3:
                    Console.Write("Nodo de inicio para BFS: ");
                    string inicioBFS = Console.ReadLine();
                    grafo.BFS(inicioBFS);
                    break;

                case 4:
                    Console.Write("Nodo de inicio para DFS: ");
                    string inicioDFS = Console.ReadLine();
                    grafo.DFS(inicioDFS);
                    break;

                case 5:
                    Console.WriteLine("Saliendo...");
                    return;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}
