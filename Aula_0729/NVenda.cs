using System;
using System.Collections.Generic;

static class NVenda {
  private static List<Venda> vendas = new List<Venda>();
  public static int Inserir(Venda v) {
    int id = 0;
    foreach(Venda obj in vendas)
      if(obj.Id > id) id = obj.Id;
    id++;
    v.Id = id;
    vendas.Add(v);
    return id;
  }
  public static List<Venda> Listar() {
    vendas.Sort();
    return vendas;
  }  
  public static List<Venda> Listar(Cliente c) {
    List<Venda> lista = new List<Venda>();
    foreach(Venda obj in vendas)
      if(obj.IdCliente == c.Id) lista.Add(obj);
    lista.Sort();
    return lista;
  }  
}