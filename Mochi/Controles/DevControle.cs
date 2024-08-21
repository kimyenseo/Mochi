
using Mochi;
using Mochi.Modelos;

namespace Controles;

public class DevControle : BaseControle
{
  //----------------------------------------------------------------------------

  public DevControle() : base()
  {
    NomeDaTabela = "Devedores";
  }

  //----------------------------------------------------------------------------


  public virtual List<Devedores>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Devedores>(NomeDaTabela);
    return new List<Devedores>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idDevedores)
  {
    var collection = liteDB.GetCollection<Devedores>(NomeDaTabela);
    collection.Delete(idDevedores);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Devedores devedores)
  {
    var collection = liteDB.GetCollection<Devedores>(NomeDaTabela);
    collection.Upsert(devedores);
  }

  //----------------------------------------------------------------------------
}