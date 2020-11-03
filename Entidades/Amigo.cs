using System;

namespace Entidades
{
  public class Amigo
  {
    public int codamigo { get; set; }
    // Esto indica que la entidad Amigo esta relacionada al entidad Distrito
    public Distrito edistrito { get; set; }
    public string nombre { get; set; }
    public string dni { get; set; }
    public string direccion { get; set; }
    public string telefono { get; set; }
    public string sexo { get; set; }
    public DateTime fecnac { get; set; }
    // Prop. de solo lectura para obtener el nombre del distrito
    public string nombredistrito
    {
      get { return edistrito.nomdistrito; }
    }
  }
}
