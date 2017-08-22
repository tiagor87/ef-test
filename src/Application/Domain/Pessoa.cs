using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Application.Domain
{
  [Table("Pessoa")]
  public class Pessoa
  {
    [Key, Column("IdPessoa")]
    public string Identificador { get; set; }

    public static Pessoa ObterPorIdentificador(Context context, string id)
    {
      return context.Pessoas.FirstOrDefault(p => p.Identificador.Equals(id));
    }
  }
}