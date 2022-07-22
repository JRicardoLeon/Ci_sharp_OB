

public struct persona
{
public persona(String name, String tele, String direc, String email, String cliente)
    {

        nombre = name;
        telefono = tele;
        direccion = direc;
        emaill = email;
        clienteN = cliente;
    }
    public String nombre { get; set; }
    public String telefono { get; set; }
    public String direccion { get; set; }
    public String emaill { get; set; }
    public String clienteN { get; set;}
    public override String ToString() => $"({nombre},{telefono},{direccion},{emaill},{clienteN})";
}