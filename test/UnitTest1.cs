using biblioteca;

namespace test;

public class UnitTest1
{   
    [Fact]
    public void Validar_estado_por_default()
    {


    }


   [Fact]
    public void MascotaAburrida_Come_NoCambiaFelicidad()
    {
        var mascota = new Mascota();
        mascota.Comer();
        Assert.Equal(0, mascota.Felicidad);
    }

    [Fact]
    public void MascotaHambrienta_Come_SePoneContenta()
    {
        var mascota = new Mascota();
        mascota.CambiarEstado(new EstadoHambriento());
        mascota.Comer();
        Assert.True(mascota.PuedeJugar());
    }

    [Fact]
    public void MascotaContenta_Juega_AumentaFelicidad()
    {
        var mascota = new Mascota();
        mascota.CambiarEstado(new EstadoContento(mascota,3));
        mascota.Jugar();

        Assert.Equal(5, mascota.Felicidad);
    }
}