
namespace CapaEntidad
{

    public class USUARIOCLS
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public System.DateTime? fecha { get; set; }
        public int? idRol { get; set; }
        public int? Id_Estado { get; set; }

        public virtual RolCLS Rol { get; set; }
        public virtual EstadoCLS Estado { get; set; }
    }
}