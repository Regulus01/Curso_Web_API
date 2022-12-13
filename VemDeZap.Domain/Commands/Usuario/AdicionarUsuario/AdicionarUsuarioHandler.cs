using MediatR;
using prmToolkit.NotificationPattern;
using VemDeZap.Domain.Interfaces.Repositories;
using UsuarioDomain = VemDeZap.Domain.Entities.Usuario;

namespace VemDeZap.Domain.Commands.Usuario.AdicionarUsuario
{
    public class AdicionarUsuarioHandler : Notifiable, IRequestHandler<AdicionarUsuarioRequest, Response>
    {
        private readonly IMediator _mediator;
        private readonly IRepositoryUsuario _repository;

        public AdicionarUsuarioHandler(IMediator mediator = null, IRepositoryUsuario repository = null)
        {
            _mediator = mediator;
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

            var usuario = new UsuarioDomain(request.PrimeiroNome, request.UltimoNome, request.Email, request.Senha);

            AddNotifications(usuario);

            if (IsInvalid())
                return new Response(this);
            
            usuario = _repository.Adicionar(usuario);
            var response = new Response(this, usuario);

            var adicionarUsuarioNotification = new AdicionarUsuarioNotification(usuario);

            await _mediator.Publish(adicionarUsuarioNotification);
            
            return await Task.FromResult(response);
        }
    }
}
