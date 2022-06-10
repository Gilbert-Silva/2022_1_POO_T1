using System;

class Program {
  public static void Main() {
    PlayList lista1 = new PlayList();
    lista1.nome = "Rock";
    Musica m1 = new Musica();
    m1.titulo = "Another brick in the wall";
    Musica m2 = new Musica();
    m2.titulo = "Transilvania";    
    lista1.Inserir(m1);
    lista1.Inserir(m2);
    foreach(Musica m in lista1.musicas)
      if (m != null) Console.WriteLine(m.titulo);
  }
}

class PlayList {
  public string nome;
  private int k = 0;
  public Musica[] musicas = new Musica[10];
  public void Inserir(Musica m) {
    musicas[k] = m;
    k++;
  }
}

class Musica {
  public string titulo;  
}

