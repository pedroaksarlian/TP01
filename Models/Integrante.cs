public class Integrante
{
    private string nombre;
    private string foto;
    private int dni;
    private DateTime fechaNacimiento;
    List <string> familiares;
    List <string> intereses;

    public Integrante(string nombre, string foto, int dni, DateTime fechaNacimiento, List<string>familiares, List<string>intereses){
        this.nombre = nombre;
        this.foto = foto;
        this.dni = dni;
        this.fechaNacimiento = fechaNacimiento;
        this.familiares = familiares;
        this.intereses = intereses;
    }

    public string ObtenerNombre(){
        return nombre;
    }

    public string ObtenerFoto(){
        return foto;
    }

    public int ObtenerDni(){
        return dni;
    }

    public DateTime ObtenerFecha(){
        return fechaNacimiento;
    }

    public List<string> ObtenerFamiliares(){
        return familiares;
    }

    public List<string> ObtenerIntereses(){
        return intereses;
    }
}