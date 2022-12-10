using VemDeZap.Domain.Entities.Base;

namespace VemDeZap.Domain.Entities;

public class Usuario : EntityBase
{
    public string PrimeiroNome { get; set; }
    public string UltimoNome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
}