using System;
using Application;
using Core;

var servicio = new LibraryService();

// --- LIBROS DE LA PIZARRA ---
servicio.AgregarLibro(new Libro { ISBN = "111", Nombre = "El Laberinto de la Soledad", Autor = "Octavio Paz", Editorial = "FCE", Genero = "Ensayo", AnioPublicacion = 1950 });
servicio.AgregarLibro(new Libro { ISBN = "222", Nombre = "Fundacion", Autor = "Isaac Asimov", Editorial = "Debolsillo", Genero = "Si-Fi", AnioPublicacion = 1951 });

// --- EL LIBRO DE ANGEL QUINTAL (TU CASO DE USO) ---
servicio.AgregarLibro(new Libro { 
    ISBN = "UTM-2024-Q", 
    Nombre = "Manual de Supervivencia en Programacion", 
    Autor = "Angel Quintal", 
    Editorial = "Quintal Ediciones", 
    Genero = "Novela",
    AnioPublicacion = 2024 
});

Console.WriteLine("=== SISTEMA DE BIBLIOTECA UTM - ANGEL QUINTAL ===");

// Caso de Uso 1: Octavio Paz
var paz = servicio.ObtenerLibrosOctavioPaz();
Console.WriteLine($"\nBuscando Octavio Paz... Encontrados: {paz.Count}");
foreach(var l in paz) Console.WriteLine($"- {l.Nombre}");

// Caso de Uso 2: Si-Fi
var sifi = servicio.ObtenerLibrosSiFi();
Console.WriteLine($"\nBuscando Ciencia Ficcion... Encontrados: {sifi.Count}");
foreach(var l in sifi) Console.WriteLine($"- {l.Nombre}");

// TU CASO DE USO: Buscar por editorial
Console.WriteLine("\n>>> MI CASO DE USO PROPIO <<<");
var miEditorial = servicio.ObtenerLibrosPorEditorial("Quintal Ediciones");
Console.WriteLine($"Buscando Editorial Quintal... Encontrados: {miEditorial.Count}");
foreach(var l in miEditorial) Console.WriteLine($"- Libro: {l.Nombre} | Autor: {l.Autor}");
