using System;
using Application;
using Core;

// 1. Iniciamos el servicio de la biblioteca
var servicio = new LibraryService();

// 2. Agregamos libros de prueba para que el profe vea datos
servicio.AgregarLibro(new Libro { Nombre = "El Laberinto de la Soledad", Autor = "Octavio Paz", Genero = "Ensayo" });
servicio.AgregarLibro(new Libro { Nombre = "Fundación", Autor = "Isaac Asimov", Genero = "Si-Fi" });
servicio.AgregarLibro(new Libro { Nombre = "Cien años de soledad", Autor = "Gabriel García Márquez", Genero = "Novela" });

Console.WriteLine("=== SISTEMA DE BIBLIOTECA UTM ===");

// 3. Probamos la búsqueda de Octavio Paz
var librosPaz = servicio.ObtenerLibrosOctavioPaz();
Console.WriteLine($"\nBuscando a Octavio Paz... Encontrados: {librosPaz.Count}");
foreach(var libro in librosPaz) {
    Console.WriteLine($"- {libro.Nombre} ({libro.Genero})");
}

// 4. Probamos la búsqueda de Si-Fi
var librosSifi = servicio.ObtenerLibrosSiFi();
Console.WriteLine($"\nBuscando Ciencia Ficción... Encontrados: {librosSifi.Count}");
foreach(var libro in librosSifi) {
    Console.WriteLine($"- {libro.Nombre} de {libro.Autor}");
    // Probando el caso de uso que yo creé
var porEditorial = servicio.ObtenerLibrosPorEditorial("RM");
Console.WriteLine($"\nCaso de uso de Ángel: Buscando Editorial RM... Encontrados: {porEditorial.Count}");
}