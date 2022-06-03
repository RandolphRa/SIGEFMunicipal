using CapaEntidad;

namespace CapaDatos
{
    public class FinancieroDAL:CadenaDAL
    {
       

        //Servicio que llena la data pasarle Entidad
        public List<FinancieroClasificadoresCLS> ListarClasificadores() { 
            List<FinancieroClasificadoresCLS> listaUsuarios = new List<FinancieroClasificadoresCLS>(); 
            listaUsuarios.Add(new FinancieroClasificadoresCLS
            { 
                ID = 1,
                CLASIFICADOR = 1234,
                DESCRIPCION = "Descripcion algo",
                CUENTA_CONTROL = 23123,
                TIPO = "NORMAL",
                CLASIFICACION = "UNA CLASIFICACION",
                CTA_CONTABLE =123123
            });
            listaUsuarios.Add(new FinancieroClasificadoresCLS
            {
                ID = 1,
                CLASIFICADOR = 1234,
                DESCRIPCION = "Descripcion algo",
                CUENTA_CONTROL = 23123,
                TIPO = "NORMAL",
                CLASIFICACION = "UNA CLASIFICACION",
                CTA_CONTABLE =123123
            });
            listaUsuarios.Add(new FinancieroClasificadoresCLS
            {
                ID = 1,
                CLASIFICADOR = 1234,
                DESCRIPCION = "Descripcion algo",
                CUENTA_CONTROL = 23123,
                TIPO = "NORMAL",
                CLASIFICACION = "UNA CLASIFICACION",
                CTA_CONTABLE =123123
            });
            listaUsuarios.Add(new FinancieroClasificadoresCLS
            {
                ID = 1,
                CLASIFICADOR = 1234,
                DESCRIPCION = "Descripcion algo",
                CUENTA_CONTROL = 23123,
                TIPO = "NORMAL",
                CLASIFICACION = "UNA CLASIFICACION",
                CTA_CONTABLE =123123
            });
            listaUsuarios.Add(new FinancieroClasificadoresCLS
            {
                ID = 1,
                CLASIFICADOR = 1234,
                DESCRIPCION = "Descripcion algo",
                CUENTA_CONTROL = 23123,
                TIPO = "NORMAL",
                CLASIFICACION = "UNA CLASIFICACION",
                CTA_CONTABLE =123123
            });
            listaUsuarios.Add(new FinancieroClasificadoresCLS
            {
                ID = 1,
                CLASIFICADOR = 1234,
                DESCRIPCION = "Descripcion algo",
                CUENTA_CONTROL = 23123,
                TIPO = "NORMAL",
                CLASIFICACION = "UNA CLASIFICACION",
                CTA_CONTABLE =123123
            });
            listaUsuarios.Add(new FinancieroClasificadoresCLS
            {
                ID = 1,
                CLASIFICADOR = 1234,
                DESCRIPCION = "Descripcion algo",
                CUENTA_CONTROL = 23123,
                TIPO = "NORMAL",
                CLASIFICACION = "UNA CLASIFICACION",
                CTA_CONTABLE =123123
            });
            listaUsuarios.Add(new FinancieroClasificadoresCLS
            {
                ID = 1,
                CLASIFICADOR = 1234,
                DESCRIPCION = "Descripcion algo",
                CUENTA_CONTROL = 23123,
                TIPO = "NORMAL",
                CLASIFICACION = "UNA CLASIFICACION",
                CTA_CONTABLE =123123
            });
            listaUsuarios.Add(new FinancieroClasificadoresCLS
            {
                ID = 1,
                CLASIFICADOR = 1234,
                DESCRIPCION = "Descripcion algo",
                CUENTA_CONTROL = 23123,
                TIPO = "NORMAL",
                CLASIFICACION = "UNA CLASIFICACION",
                CTA_CONTABLE =123123
            });
            listaUsuarios.Add(new FinancieroClasificadoresCLS
            {
                ID = 1,
                CLASIFICADOR = 1234,
                DESCRIPCION = "Descripcion algo",
                CUENTA_CONTROL = 23123,
                TIPO = "NORMAL",
                CLASIFICACION = "UNA CLASIFICACION",
                CTA_CONTABLE =123123
            });

            return listaUsuarios;
        
        }
        public List<FinancieroProgramaticaCLS> ListarEtsProgramatico()
        {
            List<FinancieroProgramaticaCLS> listProgramatico = new List<FinancieroProgramaticaCLS>();
            listProgramatico.Add(new FinancieroProgramaticaCLS
            {
                id=5,
                PNAP = 5,
               Programa = 5,
               Proyecto = 5,
               Actividad = 5,
               EstProgControl = "Hola",
               Denominacion = "Hola",
               UnidadResponsable = "Hola"

            });
            listProgramatico.Add(new FinancieroProgramaticaCLS
            {
                id = 5,
                PNAP = 5,
                Programa = 5,
                Proyecto = 5,
                Actividad = 5,
                EstProgControl = "Hola",
                Denominacion = "Hola",
                UnidadResponsable = "Hola"

            });
            listProgramatico.Add(new FinancieroProgramaticaCLS
            {
                id = 5,
                PNAP = 5,
                Programa = 5,
                Proyecto = 5,
                Actividad = 5,
                EstProgControl = "Hola",
                Denominacion = "Hola",
                UnidadResponsable = "Hola"

            });
            listProgramatico.Add(new FinancieroProgramaticaCLS
            {
                id = 5, 
                PNAP = 5,
                Programa = 5,
                Proyecto = 5,
                Actividad = 5,
                EstProgControl = "Hola",
                Denominacion = "Hola",
                UnidadResponsable = "Hola"

            });
            listProgramatico.Add(new FinancieroProgramaticaCLS
            {
                id = 5,
                PNAP = 5,
                Programa = 5,
                Proyecto = 5,
                Actividad = 5,
                EstProgControl = "Hola",
                Denominacion = "Hola",
                UnidadResponsable = "Hola"

            });
            listProgramatico.Add(new FinancieroProgramaticaCLS
            {
                id = 5, 
                PNAP = 5,
                Programa = 5,
                Proyecto = 5,
                Actividad = 5,
                EstProgControl = "Hola",
                Denominacion = "Hola",
                UnidadResponsable = "Hola"

            });


            return listProgramatico;

        }


        public List<FinancieroCatalogoFuncionesCLS> ListarFinancieroCatalogo()
        {
            List<FinancieroCatalogoFuncionesCLS> listaUsuarios = new List<FinancieroCatalogoFuncionesCLS>();
            listaUsuarios.Add(new FinancieroCatalogoFuncionesCLS
            {
                ID = 1,
                codigo = 1245,
                finalidad = 1234,
                funcion = 25,
                subfuncion = 23123,
                denominacion = "OPERACION FALCON",

            });
            listaUsuarios.Add(new FinancieroCatalogoFuncionesCLS
            {
                ID = 1,
                codigo = 1245,
                finalidad = 1234,
                funcion = 25,
                subfuncion = 23123,
                denominacion = "OPERACION FALCON",

            });
            listaUsuarios.Add(new FinancieroCatalogoFuncionesCLS
            {
                ID = 1,
                codigo = 1245,
                finalidad = 1234,
                funcion = 25,
                subfuncion = 23123,
                denominacion = "OPERACION FALCON",

            });



            return listaUsuarios;
        }
        public List<FinancieroFuentesFinanciamientoCLS> ListarFuentesFinanciamiento()
        {
            List<FinancieroFuentesFinanciamientoCLS> ListaFuentes = new List<FinancieroFuentesFinanciamientoCLS>();
            ListaFuentes.Add(new FinancieroFuentesFinanciamientoCLS
            {
                ID = 1,
                CODIGO = 1234,
                DENOMINACION = "Descripcion algo",
                ORIGEN = "",
                FONDO = 12312,
                FUENTE = "UNA FUENTE",
                GRUPO = "UNA CLASIFICACION"
              
            });
            ListaFuentes.Add(new FinancieroFuentesFinanciamientoCLS
            {
                ID = 1,
                CODIGO = 1234,
                DENOMINACION = "Descripcion algo",
                ORIGEN = "",
                FONDO = 12312,
                FUENTE = "UNA FUENTE",
                GRUPO = "UNA CLASIFICACION"

            });
            ListaFuentes.Add(new FinancieroFuentesFinanciamientoCLS
            {
                ID = 1,
                CODIGO = 1234,
                DENOMINACION = "Descripcion algo",
                ORIGEN = "",
                FONDO = 12312,
                FUENTE = "UNA FUENTE",
                GRUPO = "UNA CLASIFICACION"

            });
            ListaFuentes.Add(new FinancieroFuentesFinanciamientoCLS
            {
                ID = 1,
                CODIGO = 1234,
                DENOMINACION = "Descripcion algo",
                ORIGEN = "",
                FONDO = 12312,
                FUENTE = "UNA FUENTE",
                GRUPO = "UNA CLASIFICACION"

            });

            return ListaFuentes;


        }


        public List<FinancieroFuenteEspecificaCLS> ListarFuentesEspecificas()
        {
            List<FinancieroFuenteEspecificaCLS> ListaEspecificas = new List<FinancieroFuenteEspecificaCLS>();
            ListaEspecificas.Add(new FinancieroFuenteEspecificaCLS
            {
                id=1,
                codigo=5,
                fuente =5,
                denominacion= "UNA FUENTE"


            });

            ListaEspecificas.Add(new FinancieroFuenteEspecificaCLS
            {
                id = 1,
                codigo = 5,
                fuente = 5,
                denominacion = "UNA FUENTE"


            });
            ListaEspecificas.Add(new FinancieroFuenteEspecificaCLS
            {
                id = 1,
                codigo = 5,
                fuente = 5,
                denominacion = "UNA FUENTE"


            });
            ListaEspecificas.Add(new FinancieroFuenteEspecificaCLS
            {
                id = 1,
                codigo = 5,
                fuente = 5,
                denominacion = "UNA FUENTE"


            });
            ListaEspecificas.Add(new FinancieroFuenteEspecificaCLS
            {
                id = 1,
                codigo = 5,
                fuente = 5,
                denominacion = "UNA FUENTE"


            });
            ListaEspecificas.Add(new FinancieroFuenteEspecificaCLS
            {
                id = 1,
                codigo = 5,
                fuente = 5,
                denominacion = "UNA FUENTE"


            });
            ListaEspecificas.Add(new FinancieroFuenteEspecificaCLS
            {
                id = 1,
                codigo = 5,
                fuente = 5,
                denominacion = "UNA FUENTE"


            });
            ListaEspecificas.Add(new FinancieroFuenteEspecificaCLS
            {
                id = 1,
                codigo = 5,
                fuente = 5,
                denominacion = "UNA FUENTE"


            });
            ListaEspecificas.Add(new FinancieroFuenteEspecificaCLS
            {
                id = 1,
                codigo = 5,
                fuente = 5,
                denominacion = "UNA FUENTE"


            });
            return ListaEspecificas;


        }

        //public List<UsuarioEntity> ListarUsuarios2()
        //{
        //    List<UsuarioEntity> listaUsuarios = null;

        //    using (SqlConnection cn = new SqlConnection(cadena))
        //    {
        //        try
        //        {
        //            cn.Open();
        //            using (SqlCommand cmd = new SqlCommand("Select * from prueba",cn)) {
        //                cmd.CommandType = CommandType.Text;
        //                SqlDataReader drd = cmd.ExecuteReader();
        //                if (drd != null) {
        //                    UsuarioEntity oUsuarioEntity;
        //                    while (drd.Read()) {
        //                        oUsuarioEntity = new UsuarioEntity();
        //                        oUsuarioEntity.ID = drd.GetInt32(0);
        //                        oUsuarioEntity.Name = drd.GetString(1);
        //                        listaUsuarios.Add(oUsuarioEntity);
        //                    }
        //                    cn.Close();
        //                }
        //            }
        //        }
        //        catch(Exception ex)
        //        { 
        //            cn.Close();
        //            listaUsuarios = null;
        //        }
        //    }

        //    return null;

        //}
    }
}
