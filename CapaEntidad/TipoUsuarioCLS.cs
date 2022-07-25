namespace CapaEntidad
{
    public class TipoUsuarioCls
    {
        public int idtipousuario { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public List<int> idpaginas { get; set; }
    }
}