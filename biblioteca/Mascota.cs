
namespace biblioteca;
public class Mascota
{
    private EstadoMascota estado;
    public int Felicidad { get;  set; }

    public Mascota()
    {
        Felicidad = 0;
        estado = new EstadoAburrido();
    }

    public void Comer() => estado.Comer(this);

    public void Jugar()
    {
        if (estado.PuedeJugar())
            estado.Jugar(this);
    }

    public bool PuedeJugar() => estado.PuedeJugar();

    public void CambiarEstado(EstadoMascota nuevoEstado)
    {
        estado = nuevoEstado;
    }
}
