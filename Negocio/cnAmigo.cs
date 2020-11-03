using System;
using System.Collections.Generic;

namespace Negocio
{
  public sealed class cnAmigo
  {
    public static bool Grabar(Entidades.Amigo pEntidad)
    {
      // Una regla del negocio, es que, el nombre del amigo(a) no podra ser un valor nulo o vacio
      // Sera obligatorio ingresar dicho dato
      if (string.IsNullOrEmpty(pEntidad.nombre.Trim()))
        throw new Exception("El nombre del amigo(a) no puede ser un valor nulo o vacio");

      // Otra regla del negocio es que el numero de dni debe ser de ocho caracteres
      if (pEntidad.dni.Trim().Length < 8 | pEntidad.dni.Trim().Length > 8)
        throw new Exception("El numero de dni debera ser de 8 caracteres");

      return AccesoDato.adAmigo.Grabar(pEntidad);
    }

    public static bool Eliminar(Entidades.Amigo pEntidad)
    {
      return AccesoDato.adAmigo.Eliminar(pEntidad);
    }

    public static List<Entidades.Amigo> Listar(string dato)
    {
      return AccesoDato.adAmigo.Leer(dato);
    }
  }
}
