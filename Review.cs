namespace Trabajo;

public class Review{
    int Calificacion{get;set;}
    string Comentario{get;set;}

    public Review(int calificacion, string comentario ){
        this.Calificacion= calificacion;
        this.Comentario=comentario;
    }

     public override string ToString(){
        return $"Calificacion: {this.Calificacion} |  Comentario: {this.Comentario} ";
    }
    
} 
    


 
