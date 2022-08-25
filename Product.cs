using System;
using System.Collections.Generic;

namespace Trabajo{
public class Product{
    private string nombre;
    private int precio;
    List<Review> reviews=new List<Review>();

    public Product(string nombre, int precio, List<Review> review){
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
    public string GetReviews(){
            string reviewJoin= "";
            for (int i = 0; i <this.reviews.Count; i++)
            {
                reviewJoin += this.reviews[i].ToString(); 
            }
            return reviewJoin;
    }

    public override string ToString(){
        string reviews= this.GetReviews();
        return $"Nombre del producto: {this.Nombre} \nPrecio: {this.Precio} \nReviews: {reviews} ";
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