namespace VemDeZap.Domain.Entities;

public class Usuario
{
    public Guid Id { get; set; }
    public string PrimeiroNome { get; set; }
    public string UltimoNome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
}