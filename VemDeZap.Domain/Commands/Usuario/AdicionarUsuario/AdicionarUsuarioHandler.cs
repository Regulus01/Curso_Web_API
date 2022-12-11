using MediatR;
using prmToolkit.NotificationPattern;
using VemDeZap.Domain.Interfaces.Repositories;
using UsuarioDomain = VemDeZap.Domain.Entities.Usuario;

namespace VemDeZap.Domain.Commands.Usuario.AdicionarUsuario
{
    public class AdicionarUsuarioHandler : Notifiable, IRequestHandler<AdicionarUsuarioRequest, Response>
    {
        private readonly IRepositoryUsuario _repository;

        public AdicionarUsuarioHandler(IRepositoryUsuario repository)
        {
            _repository = repository;
        }

        public async Task<Response> Handle(AdicionarUsuarioRequest? request, CancellationToken cancellationToken)
        {
            //valida se o request veio preenchido
            if(request == null)
            {
                AddNotification("Request", "Informe os dados do usuário.");
                return new Response(this);
            }

            if (_repository.Existe(x => x.Email == request.Email))
            {
                AddNotification("Email", "E-mail já cadastrado no sistema.");
                return new Response(this);
            }

            var usuario = new UsuarioDomain();

            usuario.PrimeiroNome = request.PrimeiroNome;
            usuario.PrimeiroNome = request.UltimoNome;
            usuario.Email = request.Email;
            usuario.Senha = request.Senha;

            _repository.Adicionar(usuario);

            return new Response(this);
        }
    }
}
