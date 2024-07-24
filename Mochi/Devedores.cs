namespace Mochi;
public class Devedores:Cliente
{
    string pedido;
    public void Setvalor(string pedido) 
{
    this.pedido =pedido;
}
public string Getpedido()
{
    return pedido;
}
}
