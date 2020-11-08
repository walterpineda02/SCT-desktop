using System;

namespace MODELS
{
    public class User
    {
        public User() { }
        public int ID { set; get; }
        public String NombreUsuario { set; get; }
        public String NombreCompleto { set; get; }
        public String Contrasena { set; get; }
        public String Tipo { set; get; }
    }
}
