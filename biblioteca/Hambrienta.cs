

namespace biblioteca;

public class EstadoHambriento : EstadoMascota
{
    public void Comer(Mascota mascota)
    {
        mascota.CambiarEstado(new EstadoContento(mascota,mascota.Felicidad));
    }

    public void Jugar(Mascota mascota)
    {
        // No puede jugar si está hambrienta.
    }

    public bool PuedeJugar() => false;
}
