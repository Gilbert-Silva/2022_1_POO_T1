using System;

class Program {
  public static void Main() {
    /*
    Item a = new Item("TADS");
    Item b = new Item("Redes");
    Item c = new Item("InfoWeb");
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    a.SetProx(b);
    b.SetProx(c);
    Item aux = a;
    while (aux != null) {
      Console.WriteLine(aux);
      aux = aux.GetProx();
    }
    */
    Lista l = new Lista();
    l.Inserir("TADS");
    l.Inserir("Redes");
    l.Inserir("InfoWeb");
    l.Inserir("Manutenção");
    l.Inserir("Gestão");
    l.Imprimir();
  }
}
class Lista { // Lista Ligada ou Lista Encadeada
  private Item primeiro, ultimo;
  public void Inserir(string valor) {
    Item novo = new Item(valor);
    if (primeiro == null) {
      primeiro = novo;
      ultimo = novo;
    } else {
      ultimo.SetProx(novo);
      ultimo = novo;
    }
  }
  public void Imprimir() {
    Item aux = primeiro;
    while(aux != null) {
      Console.WriteLine(aux);
      aux = aux.GetProx();
    }
  }
  public int Quantidade() {
    
  }
  public int Indice(string valor) {
    
  }
  public void Remover(string valor) {
    
  }
}
class Item {
  private string valor;
  private Item prox;
  public Item(string valor) { this.valor = valor; }
  public void SetValor(string valor) { this.valor = valor; }
  public string GetValor() { return valor;  }
  public void SetProx(Item prox) { this.prox = prox; }
  public Item GetProx() { return prox; }
  public override string ToString() { return valor; }
}