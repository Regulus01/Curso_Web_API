using VemDeZap.Domain.Entities.Base;
using VemDeZap.Domain.Enums;

namespace VemDeZap.Domain.Entities;

public class Grupo : EntityBase
{
    public Usuario Usuario { get; set; }
    public string Nome { get; set; }
    public EnumNicho Nicho { get; set; }
}