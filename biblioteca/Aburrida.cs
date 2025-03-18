
namespace biblioteca;
public class EstadoAburrido : EstadoMascota
{
    private DateTime inicioAburrimiento;

    public EstadoAburrido()
    {
        inicioAburrimiento = DateTime.Now;
    }

    public void Comer(Mascota mascota)
    {
        TimeSpan tiempoAburrido = DateTime.Now - inicioAburrimiento;
        if (tiempoAburrido.TotalMinutes > 80)
            mascota.CambiarEstado(new EstadoContento(mascota.Felicidad));
    }

    public void Jugar(Mascota mascota)
    {
        mascota.CambiarEstado(new EstadoContento(mascota.Felicidad));
    }

    public bool PuedeJugar() => true;
}
