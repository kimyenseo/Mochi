
using Mochi;
using Mochi.Modelos;

namespace Controles;

public class PagarControle : BaseControle
{
  //----------------------------------------------------------------------------

  public PagarControle() : base()
  {
    NomeDaTabela = "ContaPagar";
  }

  //----------------------------------------------------------------------------


  public virtual List<ContaPagar>? LerTodos()
  {
    var tabela = liteDB.GetCollection<ContaPagar>(NomeDaTabela);
    return new List<ContaPagar>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idContaPagar)
  {
    var collection = liteDB.GetCollection<ContaPagar>(NomeDaTabela);
    collection.Delete(idContaPagar);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(ContaPagar contapagar)
  {
    var collection = liteDB.GetCollection<ContaPagar>(NomeDaTabela);
    collection.Upsert(contapagar);
  }

  //----------------------------------------------------------------------------
}