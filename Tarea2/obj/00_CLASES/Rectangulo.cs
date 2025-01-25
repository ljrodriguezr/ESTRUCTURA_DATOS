public class Rectangulo{
    private double Base;
    private double Altura;


    ///<summary>
    /// Constructor de la clase rectangulo
    /// </summary>
    /// <param name="_base"> Es la medida de la base del rectangulo</param>
    /// <param name="_altura"> Es la medida de la altura del rectangulo</param>
        public Rectangulo(double _base, double _altura){
            Base = _base;
            Altura = _altura;
        }
    /// <summary>
    /// Funcion para calcular el are de un rectangulo
    /// </summary>
    /// <returns>Retorna un valor double</returns>
    public double Area(){
        return Base * Altura;
    } 
}
