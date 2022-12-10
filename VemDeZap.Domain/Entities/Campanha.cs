namespace VemDeZap.Domain.Entities;

public class Campanha
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public Usuario Usuario { get; set; }
}