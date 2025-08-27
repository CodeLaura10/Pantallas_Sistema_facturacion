using System;
using System.Collections.Generic;
using System.Linq;

namespace Pantallas_Sistema_facturacion.Seguridad
{
    public class Usuario
    {
        public int EmpleadoId { get; set; }
        public string Username { get; set; } = "";
        public string Password { get; set; } = ""; // Solo práctica (en producción: hash)
    }

    public static class UsuariosStore
    {
        // Índice por empleado
        private static readonly Dictionary<int, Usuario> _porEmpleado = new();

        // Índice por username (ignore case)
        private static readonly Dictionary<string, int> _porUsername =
            new(StringComparer.OrdinalIgnoreCase);

        // Crea o actualiza credenciales de un empleado.
        // Garantiza que el username sea único en todo el sistema.
        public static bool Upsert(int empleadoId, string username, string password, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(username))
            {
                error = "El usuario es requerido.";
                return false;
            }

            username = username.Trim();

            // Si el username ya existe y pertenece a otro empleado → error
            if (_porUsername.TryGetValue(username, out var otroEmpId) && otroEmpId != empleadoId)
            {
                error = "Ese usuario ya está en uso.";
                return false;
            }

            // Si el empleado ya tenía usuario, liberar el username anterior si cambió
            if (_porEmpleado.TryGetValue(empleadoId, out var existente))
            {
                if (!string.Equals(existente.Username, username, StringComparison.OrdinalIgnoreCase))
                {
                    // quita el índice del anterior, si existía
                    if (!string.IsNullOrWhiteSpace(existente.Username))
                        _porUsername.Remove(existente.Username);
                }

                existente.Username = username;
                existente.Password = password;
            }
            else
            {
                var nuevo = new Usuario
                {
                    EmpleadoId = empleadoId,
                    Username = username,
                    Password = password
                };
                _porEmpleado[empleadoId] = nuevo;
            }

            // Apunta el índice por username al empleado
            _porUsername[username] = empleadoId;
            return true;
        }

        public static Usuario? GetByEmpleadoId(int empleadoId)
        {
            _porEmpleado.TryGetValue(empleadoId, out var u);
            return u;
        }

        public static Usuario? GetByUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username)) return null;
            if (!_porUsername.TryGetValue(username.Trim(), out var empId)) return null;
            return GetByEmpleadoId(empId);
        }

        // Valida credenciales. Devuelve el Usuario válido en 'user' si coincide.
        public static bool ValidateCredentials(string username, string password, out Usuario? user)
        {
            user = null;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return false;

            var u = GetByUsername(username);
            if (u == null) return false;

            if (!string.Equals(u.Password, password, StringComparison.Ordinal))
                return false;

            user = u;
            return true;
        }

        // Crea un admin por defecto si no existe (útil para primera ejecución)
        public static void EnsureDefaultAdmin()
        {
            if (_porUsername.ContainsKey("admin")) return;

            // Busca algún empleado para asociar el admin. Si no hay, crea uno básico.
            Empleado empRef = EmpleadoStore.Empleados.FirstOrDefault();
            if (empRef == null)
            {
                EmpleadoStore.Add("Administrador del sistema", "999999999", "0000000");
                empRef = EmpleadoStore.Empleados.Last();
            }

            // Admin de prueba: admin / 123  (solo para práctica)
            Upsert(empRef.Id, "admin", "123", out _);
        }
    }
}
``

