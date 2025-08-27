using System.Collections.Generic;
using System.Linq;

namespace Pantallas_Sistema_facturacion.Seguridad
{
    public static class UsuariosStore
    {
        // Índice por EmpleadoId
        private static readonly Dictionary<int, Usuario> _porEmpleado = new();

        // Obtiene el usuario por EmpleadoId (null si no existe)
        public static Usuario? GetByEmpleadoId(int empleadoId)
        {
            _porEmpleado.TryGetValue(empleadoId, out var u);
            return u;
        }

        // Crea o actualiza usuario para ese EmpleadoId
        public static void Upsert(int empleadoId, string username, string password)
        {
            if (_porEmpleado.TryGetValue(empleadoId, out var u))
            {
                u.Username = username;
                u.Password = password;
            }
            else
            {
                _porEmpleado[empleadoId] = new Usuario
                {
                    EmpleadoId = empleadoId,
                    Username = username,
                    Password = password
                };
            }
        }

        // Elimina si se quiere dejar sin credenciales (no lo usamos ahora, pero queda útil)
        public static bool Remove(int empleadoId) => _porEmpleado.Remove(empleadoId);
    }
}
