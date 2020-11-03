using System;

namespace AccesoDato
{
  public sealed class conexion
  {
    public static string LeerCC
    {
      get { return @"server=.\sqlexpress; database = agenda; integrated security = True;"; }
    }
  }
}
