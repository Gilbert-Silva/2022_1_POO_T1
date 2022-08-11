using System;
using System.Collections.Generic;
using System.IO;

static class NVenda {
  private static List<Venda> vendas;// = new List<Venda>();
  public static int Inserir(Venda v) {
    vendas = Abrir();
    int id = 0;
    foreach(Venda obj in vendas)
      if(obj.Id > id) id = obj.Id;
    id++;
    v.Id = id;
    vendas.Add(v);
    Salvar(vendas);
    return id;
  }
  public static List<Venda> Listar() {
    vendas = Abrir();
    vendas.Sort();
    return vendas;
  }  
  public static List<Venda> Listar(Cliente c) {
    vendas = Abrir();
    List<Venda> lista = new List<Venda>();
    foreach(Venda obj in vendas)
      if(obj.IdCliente == c.Id) lista.Add(obj);
    lista.Sort();
    return lista;
  }  
  public static Venda Listar(int id) {
    vendas = Abrir();
    foreach(Venda obj in vendas)
      if(obj.Id == id) return obj;
    return null;
  }  
  public static void Atualizar(Venda v) {
    Venda atual = Listar(v.Id);
    if (atual != null) {
      atual.Data = v.Data;
      atual.Carrinho = v.Carrinho;
      atual.Total = v.Total;
      atual.IdCliente = v.IdCliente;
      Salvar(vendas);
    }
  }  
  private static string arquivo = "./vendas.xml";
  private static List<Venda> Abrir() {
    try {
      return Arquivo< List<Venda> >.Abrir(arquivo);
    }
    catch (FileNotFoundException) {
      return new List<Venda>();
    }
  }
  private static void Salvar(List<Venda> obj) {
    Arquivo< List<Venda> >.Salvar(arquivo, obj);
  }
}
