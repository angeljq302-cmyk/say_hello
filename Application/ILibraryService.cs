using System.Collections.Generic;
using Core;

namespace Application;

public interface ILibraryService
{
    List<Libro> ObtenerLibrosSiFi();
    List<Libro> ObtenerLibrosOctavioPaz();
    void AgregarLibro(Libro nuevoLibro);
    List<Libro>
     ObtenerLibrosPorEditorial(string editorial);
}