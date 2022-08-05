using System;
using System.Collections.Generic;
using System.IO;

static class NVendaItem {
  private static List<VendaItem> vendaItens;// = new List<VendaItem>();
  public static void Inserir(VendaItem vi) {
    vendaItens = Abrir();
    int id = 0;
    foreach(VendaItem obj in vendaItens)
      if(obj.Id > id) id = obj.Id;
    id++;
    vi.Id = id;
    vendaItens.Add(vi);
    Salvar(vendaItens);
  }
  public static List<VendaItem> Listar(Venda v) {
    vendaItens = Abrir();
    List<VendaItem> lista = new List<VendaItem>();
    foreach(VendaItem obj in vendaItens)
      if(obj.IdVenda == v.Id) lista.Add(obj);
    lista.Sort();
    return lista;
  }  
  private static string arquivo = "./vendaitens.xml";
  private static List<VendaItem> Abrir() {
    try {
      return Arquivo< List<VendaItem> >.Abrir(arquivo);
    }
    catch (FileNotFoundException) {
      return new List<VendaItem>();
    }
  }
  private static void Salvar(List<VendaItem> obj) {
    Arquivo< List<VendaItem> >.Salvar(arquivo, obj);
  }
  
}