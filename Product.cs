using System;
using System.Collections.Generic;

namespace Trabajo{
public class Product{
    private string nombre;
    private int precio;
    List<Review> reviews=new List<Review>();

    public Product(string nombre, int precio,List<Review> review){
        this.nombre= nombre;
        this.precio=precio;
        this.reviews=review;
    }

    public string Nombre{
        get{
            return this.nombre;
        }
    }
    public int Precio{
        get{
            return this.precio;
        }
    }
    public string Review{
        get{
            string reviewJoin= string.Join (", ", this.reviews);
            Console.WriteLine(reviewJoin);
            return reviewJoin;
        }
        
    }

   
        
    public override string ToString(){
        return $"Nombre del producto: {this.Nombre} \nPrecio: {this.Precio} \nReviews: {this.reviews } ";
}
}
class MainClass{
    public static void Main(){
        var reviewProducto1 = new List<Review>(){new Review(9,"Muy bueno")} ;
        Product producto1= new Product("Termo Termolar",2000,reviewProducto1 );
        Console.WriteLine(producto1.ToString());
    }
}

}