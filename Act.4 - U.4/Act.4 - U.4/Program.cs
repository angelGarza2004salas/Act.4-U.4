interface mAnimal
{
    void Sonido();
}

class Perro : mAnimal
{
    public void Sonido()
    {
        Console.WriteLine("Wuau wuau!");
    }
}

class Gato : mAnimal
{
    public void Sonido()
    {
        Console.WriteLine("Miao miao!");
    }
}

class Principal
{
    static void Main(string[] args)
    {
        mAnimal miPerro = new Perro();
        mAnimal miGato = new Gato();

        miPerro.Sonido();
        miGato.Sonido();
    }
}
