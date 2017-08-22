using System.Collections.Generic;
using System.Linq;
using Application.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
  [Route("api/[controller]")]
  public class PessoasController : Controller
  {
    private Context context;

    public PessoasController(Context context)
    {
      this.context = context;
    }

    [HttpGet]
    public List<Pessoa> ObterPessoas()
    {
      return this.context.Pessoas.Where(p => !string.IsNullOrWhiteSpace(p.Identificador)).ToList();
    }
  }
}