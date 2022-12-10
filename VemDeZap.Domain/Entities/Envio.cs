namespace VemDeZap.Domain.Entities;

public class Envio
{
    public Guid Id { get; set; }
    public Campanha Campanha { get; set; }
    public Grupo Grupo { get; set; }
    public Contato Contato { get; set; }
    public bool Enviado { get; set; }
}