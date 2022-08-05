using System;
using System.Collections.Generic;
using System.IO;

static class NProduto {
  private static List<Produto> produtos;
  public static void Inserir(Produto p) {
    produtos = Abrir();
    int id = 0;
    foreach(Produto obj in produtos)
      if(obj.Id > id) id = obj.Id;
    id++;
    p.Id = id;
    produtos.Add(p);
    Salvar(produtos);
  }
  public static List<Produto> Listar() {
    produtos = Abrir();
    produtos.Sort();
    return produtos;
  }
  public static Produto Listar(int id) {
    produtos = Abrir();
    foreach(Produto obj in produtos)
      if (obj.Id == id) return obj;
    return null;
  }
  public static void Atualizar(Produto p) {
    Produto atual = Listar(p.Id);
    if (atual != null) {
      atual.Descricao = p.Descricao;
      atual.Preco = p.Preco;
      atual.Estoque = p.Estoque;
      atual.IdCategoria = p.IdCategoria;
      Salvar(produtos);
    }
  }
  public static void Excluir(Produto p) {
    Produto atual = Listar(p.Id);
    if (atual != null) {
      produtos.Remove(atual);
      Salvar(produtos);
    }
  }
  private static string arquivo = "./produtos.xml";
  private static List<Produto> Abrir() {
    try {
      return Arquivo< List<Produto> >.Abrir(arquivo);
    }
    catch (FileNotFoundException) {
      return new List<Produto>();
    }
    /*
    XmlSerializer xml = new
      XmlSerializer(typeof(List<Produto>));
    StreamReader f = new StreamReader(arquivo);
    List<Produto> obj = 
      (List<Produto>) xml.Deserialize(f);
    f.Close();
    return obj;
    */
  }
  private static void Salvar(List<Produto> obj) {
    Arquivo< List<Produto> >.Salvar(arquivo, obj);
    /*
    XmlSerializer xml = new
      XmlSerializer(typeof(List<Produto>));
    StreamWriter f = new StreamWriter(arquivo, false);
    xml.Serialize(f, obj);
    f.Close();
    */
  }  
}