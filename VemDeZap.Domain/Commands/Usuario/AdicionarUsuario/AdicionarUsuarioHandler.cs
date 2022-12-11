using MediatR;

namespace VemDeZap.Domain.Commands.Usuario.AdicionarUsuario
{
    public class AdicionarUsuarioHandler : IRequestHandler<AdicionarUsuarioRequest, Response>
    {
        public Task<Response> Handle(AdicionarUsuarioRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
