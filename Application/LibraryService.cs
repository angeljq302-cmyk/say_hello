using Core;
using System.Collections.Generic;
using System.Linq;

namespace Application;

public class LibraryService : ILibraryService
{
    private List<Articulo> _articulos = new List<Articulo>();

    public void AgregarArticulo(Articulo nuevo) => _articulos.Add(nuevo);

    public List<Articulo> ConsultarTodos() => _articulos;

    public List<Articulo> ConsultarStockBajo() => _articulos.Where(a => a.Stock < 10).ToList();
}