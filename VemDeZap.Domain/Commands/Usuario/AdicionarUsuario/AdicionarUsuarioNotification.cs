using MediatR;
using UsuarioDomain = VemDeZap.Domain.Entities.Usuario;

namespace VemDeZap.Domain.Commands.Usuario.AdicionarUsuario
{
    public class AdicionarUsuarioNotification : INotification
    {
        public UsuarioDomain Usuario { get; set; }

        public AdicionarUsuarioNotification(UsuarioDomain usuario)
        {
            Usuario = usuario;
        }
    }
}
