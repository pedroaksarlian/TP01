public class Integrante
{
    private string nombre;
    private string foto;
    private int dni;
    private DateTime fechaNacimiento;
    List <string> familiares;
    List <string> intereses;

    public Integrante(string nombre, string foto, int dni, DateTime fechaNacimiento, List<string> familiares, List<string> intereses){
        this.nombre = nombre;
        this.foto = foto;
        this.dni = dni;
        this.fechaNacimiento = fechaNacimiento;
        familiares = new List<string>();
        intereses = new List<string>();
    }
}