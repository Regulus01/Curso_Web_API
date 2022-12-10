using VemDeZap.Domain.Entities.Base;

namespace VemDeZap.Domain.Entities;

public class Grupo : EntityBase
{
    public Usuario Usuario { get; set; }
    public string Nome { get; set; }
    public int Nicho { get; set; }
}