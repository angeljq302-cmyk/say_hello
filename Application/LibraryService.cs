using System.Collections.Generic;
using System.Linq; // Esto sirve para buscar rápido en listas
using Core;

namespace Application;

// Aquí le decimos que este archivo va a cumplir las promesas de ILibraryService
public class LibraryService : ILibraryService
{
    // Esta es nuestra "estantería" de libros imaginaria
    private List<Libro> _libros = new List<Libro>();
    private List<Autor> _autores = new List<Autor>();

    // 1. Lógica para buscar libros de Ciencia Ficción (Si-Fi)
    public List<Libro> ObtenerLibrosSiFi() {
        return _libros.Where(l => l.Genero == "Si-Fi").ToList();
    }

    // 2. Lógica para buscar libros de Octavio Paz
    public List<Libro> ObtenerLibrosOctavioPaz() {
        return _libros.Where(l => l.Autor == "Octavio Paz").ToList();
    }

    // 3. Lógica para buscar autores de Colombia
    public List<Autor> ObtenerEscritoresColombianos() {
        return _autores.Where(a => a.PaisDeOrigen == "Colombia").ToList();
    }

    // 4. Lógica para buscar novelas románticas
    public List<Autor> ObtenerAutoresNovelasRomanticas() {
        // Aquí buscamos los autores que escriben ese género
        return _autores.ToList(); 
    }

    // 5. El método para meter libros nuevos a la biblioteca
    public void AgregarLibro(Libro nuevoLibro) {
        _libros.Add(nuevoLibro);
    }
    public List<Libro> ObtenerLibrosPorEditorial(string editorial)
{
    return _libros.Where(l => l.Editorial == editorial).ToList();
}
}