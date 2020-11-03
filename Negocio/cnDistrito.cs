using System;
using System.Collections.Generic;

namespace Negocio
{
  public sealed class cnDistrito
  {
    public static bool Grabar(Entidades.Distrito pEntidad)
    {
      // Una regla del negocio, es que, el nombre del distrito no podra ser un valor nulo o vacio
      // Sera obligatorio ingresar dicho dato
      if (string.IsNullOrEmpty(pEntidad.nomdistrito.Trim()))
        throw new Exception("El nombre del distrito no puede ser un valor nulo o vacio");

      return AccesoDato.adDistrito.Grabar(pEntidad);
    }

    public static bool Eliminar(Entidades.Distrito pEntidad)
    {
      return AccesoDato.adDistrito.Eliminar(pEntidad);
    }

    public static List<Entidades.Distrito> Listar(string dato)
    {
      return AccesoDato.adDistrito.Leer(dato);
    }
  }
}
