using System;

// 1. Entrada de datos
int n1 = 15, n2 = 7, n3 = 20;

// 2. Flujo para encontrar el menor
int menor = Math.Min(n1, Math.Min(n2, n3));
Console.WriteLine("El número menor es: " + menor);

// 3. Flujo para verificar si es primo
bool esPrimo = true;
if (menor < 2) esPrimo = false;
for (int i = 2; i < menor; i++) {
    if (menor % i == 0) esPrimo = false;
}

// 4. Salida de resultados
if (esPrimo) Console.WriteLine(menor + " es un número primo.");
else Console.WriteLine(menor + " no es un número primo.");
