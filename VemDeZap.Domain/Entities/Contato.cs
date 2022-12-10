namespace VemDeZap.Domain.Entities;

public class Contato
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public int Nicho { get; set; }
}