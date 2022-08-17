using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

static class NCategoria {
  // private static List<Categoria> categorias = new List<Categoria>();
  private static List<Categoria> categorias;
  public static void Inserir(Categoria c) {
    // Versão original recebendo o id
    // categorias.Add(c);
    // Nova versão calculando o id
    categorias = Abrir();
    int id = 0;
    foreach(Categoria obj in categorias)
      if(obj.Id > id) id = obj.Id;
    id++;
    c.Id = id;
    categorias.Add(c);
    Salvar(categorias);
  }
  public static List<Categoria> Listar() {
    categorias = Abrir();
    categorias.Sort();
    return categorias;
    //return categorias.OrderBy(obj => obj.Descricao);
  }
  public static Categoria Listar(int id) {
    categorias = Abrir();
    foreach(Categoria obj in categorias)
      if (obj.Id == id) return obj;
    // categorias.Where(obj => obj.Id = id);
    return null;
  }
  public static void Atualizar(Categoria c) {
    Categoria atual = Listar(c.Id);
    if (atual != null) {
      atual.Descricao = c.Descricao;
      Salvar(categorias);
    }
  }
  public static void Excluir(Categoria c) {
    Categoria atual = Listar(c.Id);
    if (atual != null) {
      categorias.Remove(atual);
      Salvar(categorias);
    }
  }
  private static string arquivo = "./categorias.xml";

  private static List<Categoria> Abrir() {
    XmlSerializer xml = new XmlSerializer(typeof(List<Categoria>));
    StreamReader f = null;
    List<Categoria> obj;
    try {
      f = new StreamReader(arquivo);
      obj = (List<Categoria>) xml.Deserialize(f);
    }
    catch(FileNotFoundException) {
      obj = new List<Categoria>();
    }
    finally {
     if (f != null) f.Close();
    }
    return obj;
  }
  private static void Salvar(List<Categoria> obj) {
    XmlSerializer xml = new
      XmlSerializer(typeof(List<Categoria>));
    StreamWriter f = new StreamWriter(arquivo, false);
    xml.Serialize(f, obj);
    f.Close();
  }  
}
