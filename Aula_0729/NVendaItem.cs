using System;
using System.Collections.Generic;

static class NVendaItem {
  private static List<VendaItem> vendaItens = new List<VendaItem>();
  public static void Inserir(VendaItem vi) {
    int id = 0;
    foreach(VendaItem obj in vendaItens)
      if(obj.Id > id) id = obj.Id;
    id++;
    vi.Id = id;
    vendaItens.Add(vi);
  }
  public static List<VendaItem> Listar(Venda v) {
    List<VendaItem> lista = new List<VendaItem>();
    foreach(VendaItem obj in vendaItens)
      if(obj.IdVenda == v.Id) lista.Add(obj);
    lista.Sort();
    return lista;
  }  
}