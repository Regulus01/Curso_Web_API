using MediatR;
using System.Diagnostics;

namespace VemDeZap.Domain.Commands.Usuario.AdicionarUsuario.Notifications
{
    public class AvisarAdiministradores : INotificationHandler<AdicionarUsuarioNotification>
    {
        public async Task Handle(AdicionarUsuarioNotification notification, CancellationToken cancellationToken)
        {
            Debug.WriteLine("Chamar o webservice que avisa que novo usuário se cadastrou: " + notification.Usuario.PrimeiroNome);
        }
    }
}
