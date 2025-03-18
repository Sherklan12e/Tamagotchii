
namespace biblioteca;
public class EstadoContento : EstadoMascota
{
    private int vecesJugadas;

    public EstadoContento(int felicidadInicial)
    {
        vecesJugadas = 0;
    }

    public void Comer(Mascota mascota)
    {
        mascota.Felicidad++;
    }

    public void Jugar(Mascota mascota)
    {
        mascota.Felicidad += 2;
        vecesJugadas++;
        if (vecesJugadas > 5)
            mascota.CambiarEstado(new EstadoHambriento());
    }

    public bool PuedeJugar() => true;
}
