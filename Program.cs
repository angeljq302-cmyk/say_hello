using Application;
using Core;

var servicio = new LibraryService();

// Agregamos lo que pide la pizarra
servicio.AgregarArticulo(new Articulo { Nombre = "Tenis", Sku = "SNK-01", Color = "Rojo", Marca = "Nike", Precio = 1200, Stock = 5 });
servicio.AgregarArticulo(new Articulo { Nombre = "Gorra", Sku = "CAP-02", Color = "Negra", Marca = "Adidas", Precio = 450, Stock = 15 });

Console.WriteLine("=== INVENTARIO: ANGEL QUINTAL ===");
var bajos = servicio.ConsultarStockBajo();
Console.WriteLine($"\nArticulos con stock bajo (<10): {bajos.Count}");
foreach(var a in bajos) Console.WriteLine($"- {a.Nombre} | SKU: {a.Sku} | Stock: {a.Stock}");