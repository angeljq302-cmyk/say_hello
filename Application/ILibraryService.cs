using Core;
using System.Collections.Generic;

namespace Application;

public interface ILibraryService
{
    void AgregarArticulo(Articulo nuevo);
    List<Articulo> ConsultarTodos();
    List<Articulo> ConsultarStockBajo();
}