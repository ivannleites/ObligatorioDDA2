using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obligatorio.BusinessLogic.Contracts
{
    public interface IUsuarioServicio
    {
        void Registrar(Usuario usuario);
        Usuario IniciarSesion(string correo, string contraseña);
        void ActualizarPerfil(Usuario usuario);
        void CerrarSesion();
    }
}
