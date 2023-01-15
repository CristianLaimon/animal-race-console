using System;

class Animals
{
  public Animals(string nombre)
  {
    nombreAnimal = nombre;
  }

  public string GetNombre() => nombreAnimal;
  public string SetNombre(string nuevoNombre) => this.nombreAnimal = nuevoNombre;

  public int GetDistanceRun() => distanciaRecorrida;
  public void Moverse() => distanciaRecorrida += movimiento;

  private string nombreAnimal;
  protected byte movimiento;
  protected int distanciaRecorrida = 0; // CHECK: ¿Esto sería necesario?
}

class Gato : Animals
{
  public Gato(string nombregato) : base(nombregato)
  {
    this.movimiento = 4;
  }

}

class Caballo : Animals
{
  public Caballo(string nombreCaballo) : base(nombreCaballo)
  {
    this.movimiento = 7;
  }
}

class Perro : Animals
{
  public Perro(string nombrePerro) : base(nombrePerro)
  {
    this.movimiento = 5;
  }
}