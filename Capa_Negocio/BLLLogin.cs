using Capa_Datos;

namespace Capa_Negocio
{
    public class BLLLogin
    {
        private DALLogin dal = new DALLogin();

        public bool Login(string usuario, string contraseña)
        {
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
                return false;

            return dal.ValidarLogin(usuario, contraseña);
        }
    }
}
