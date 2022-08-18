using System;
using System.Collections.Generic;
using System.IO;

static class NUsuario {
  private static List<Usuario> usuarios;// = new List<Usuario>();
  public static Usuario Autenticar(string nome, string senha) {
    usuarios = Abrir();
    foreach(Usuario obj in usuarios)
      if (obj.Nome == nome && obj.Senha == senha) return obj;
    return null;
  }
  public static int Inserir(Usuario u) {
    usuarios = Abrir();
    int id = 0;
    foreach(Usuario obj in usuarios)
      if(obj.Id > id) id = obj.Id;
    id++;
    u.Id = id;
    usuarios.Add(u);
    Salvar(usuarios);
    return id;
  }
  private static string arquivo = "./usuarios.xml";
  private static List<Usuario> Abrir() {
    try {
      return Arquivo< List<Usuario> >.Abrir(arquivo);
    }
    catch (FileNotFoundException) {
      return new List<Usuario>();
    }
  }
  private static void Salvar(List<Usuario> obj) {
    Arquivo< List<Usuario> >.Salvar(arquivo, obj);
  }  
}