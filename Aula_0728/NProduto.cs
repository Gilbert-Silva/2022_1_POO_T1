using System;
using System.Collections.Generic;

static class NProduto {
  private static List<Produto> produtos = new List<Produto>();
  public static void Inserir(Produto p) {
    int id = 0;
    foreach(Produto obj in produtos)
      if(obj.Id > id) id = obj.Id;
    id++;
    p.Id = id;
    produtos.Add(p);
  }
  public static List<Produto> Listar() {
    produtos.Sort();
    return produtos;
  }
  public static Produto Listar(int id) {
    foreach(Produto obj in produtos)
      if (obj.Id == id) return obj;
    return null;
  }
  public static void Atualizar(Produto p) {
    Produto atual = Listar(p.Id);
    if (atual != null) 
      atual.Descricao = p.Descricao;
      atual.Preco = p.Preco;
      atual.Estoque = p.Estoque;
      atual.IdCategoria = p.IdCategoria;
  }
  public static void Excluir(Produto p) {
    Produto atual = Listar(p.Id);
    if (atual != null) 
      produtos.Remove(atual);
  }
}