public class Grupo
{
    Dictionary<int, Integrante> integrantes;

    public Grupo()
    {

    }

    private void cargaDatosManual()
    {
        List<string>familiaresPedro = new List<string>();
        familiaresPedro.Add("Mamá: Marisa");
        familiaresPedro.Add("Papá: Cristian");
        familiaresPedro.Add("Hermana: Agus");
        familiaresPedro.Add("Perro: Paul");
        List<string>interesesPedro = new List<string>();
        interesesPedro.Add("Jugar al fútbol");
        interesesPedro.Add("Jugar a la play");
        interesesPedro.Add("Estar con mis amigos");
        integrantes.Add(49554455, new Integrante("Pedro", "imagenPedro.jpg", 49554455, new DateTime(2009,07,06), familiaresPedro, interesesPedro));
        
        List<string>familiaresUriel = new List<string>();
        familiaresUriel.Add("Mamá: Yesica");
        familiaresUriel.Add("Papá: Esteban");
        familiaresUriel.Add("Hermano: Ezequiel");
        List<string>interesesUriel = new List<string>();
        interesesUriel.Add("Jugar al Fortnite");
        interesesUriel.Add("Jugar al Futbol");
        interesesUriel.Add("Jugar al padel");
        integrantes.Add(50156463, new Integrante("Uriel", "imagenUriel.jpg", 50156463, new DateTime(2010,04,04), familiaresUriel, interesesUriel));

        List<string>familiaresTobias = new List<string>();
        familiaresTobias.Add("Mamá: Constanza");
        familiaresTobias.Add("Papá: Javier");
        familiaresTobias.Add("Hermano: Manuel");
        List<string>interesesTobias = new List<string>();
        interesesTobias.Add("Comer hamburguesas");
        interesesTobias.Add("Mirar peliculas");
        interesesTobias.Add("Hacer boxeo");
        integrantes.Add(49905586, new Integrante("Tobias", "imagenTobias.jpg", 49905586, new DateTime(2009,11,10), familiaresTobias, interesesTobias));
    }

    Dic<int, integrantes> devolverIntegrantes()
    {
        return integrantes;
    }
    
    Integrante getIntegrante(int dni)
    {
        bool resultado = integrantes.ContainsKey(dni);
        if(resultado)
        {
            return integrantes[dni];
        }else{
            return null;
        }
        
}