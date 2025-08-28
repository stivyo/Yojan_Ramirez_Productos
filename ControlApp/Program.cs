// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public class Productos
{
    public int ID_P = 0;
    public string? nombreProducto = "";
    public decimal precioProducto = 0.0m;
    public int iva = 0;
    public string marca="";
   
    public int cantidadProducto = 0; 
    
     

}



public class FacturaProductos
{
    public double Total = 0;

    public int NumFactura = 0;



}
// elimine herencia para conflicto
public class Tienda
{


    public string? NIT = "";
    public string Direccion = "";
    public string? nombre = "";


}

public class PropietarioTienda
{

   
     public string? cedula = "";
    
    public string? nombre = "";


}
