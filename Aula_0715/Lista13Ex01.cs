using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

public class Pais {
  private string nome;
  private int ouro, prata, bronze;
  public string Nome { 
    get { return nome; }
    set { nome = value; }
  }
  public int Ouro { 
    get { return ouro; }
    set { ouro = value; }
  }
  public int Prata { 
    get { return prata; }
    set { prata = value; }
  }
  public int Bronze { 
    get { return bronze; }
    set { bronze = value; }
  }
  public Pais() { }
  public Pais(string nome, int ouro, int prata, int bronze) {
    this.nome = nome;
    this.ouro = ouro;
    this.prata = prata;
    this.bronze = bronze;
  }
  public override string ToString() {
    return $"{nome} - {ouro} - {prata} - {bronze}";
  }
  public string ToCSV() {
    return $"{nome};{ouro};{prata};{bronze}";
  }
  public void FromCSV(string s) {
    string[] v = s.Split(';');
    nome = v[0];
    ouro = int.Parse(v[1]);      
    prata = int.Parse(v[2]);      
    bronze = int.Parse(v[3]);      
  }
}

public class QuadroMedalhas {
  private List<Pais> paises = new List<Pais>();
  public int Ano { get; set; }
  public Pais Sede { get; set; }
  public List<Pais> Paises {
    get { return paises; }
    set { paises = value; }
  }
  public void Inserir(Pais p) {
    paises.Add(p);
  }
  public List<Pais> Listar() {
    return paises;
  }
  public void SalvarXML(string arquivo) {
    StreamWriter f = new StreamWriter(arquivo);
    XmlSerializer xml = new XmlSerializer(typeof(QuadroMedalhas));
    xml.Serialize(f, this);
    f.Close();
  }
  public void SalvarCSV(string arquivo) {
    StreamWriter f = new StreamWriter(arquivo);
    f.WriteLine(Sede.ToCSV());
    f.WriteLine(Ano.ToString());
    foreach (Pais p in paises)
      f.WriteLine(p.ToCSV());
    f.Close();
  }
  public void AbrirCSV(string arquivo) {
    StreamReader f = new StreamReader(arquivo);
    string s = f.ReadLine();
    Sede = new Pais();
    Sede.FromCSV(s);
    Ano = int.Parse(f.ReadLine());
    s = f.ReadLine();
    while (s != null) {
      Pais p = new Pais();
      p.FromCSV(s);
      paises.Add(p);
      s = f.ReadLine();
    }
    f.Close();
  }
}

class Program {
  public static void Main2() {
    QuadroMedalhas q = new QuadroMedalhas();
    q.AbrirCSV("olimp.csv");    
    Console.WriteLine(q.Sede.Nome);
    Console.WriteLine(q.Ano);
    foreach (Pais p in q.Listar())
      Console.WriteLine(p);
  }
  public static void Main() {
    Pais p1 = new Pais("Brasil", 10, 5, 3);
    Pais p2 = new Pais("Japão", 12, 4, 4);
    Pais p3 = new Pais("Argentina", 8, 15, 3);
    QuadroMedalhas q = new QuadroMedalhas();
    q.Sede = p2;
    q.Ano = 2021;
    q.Inserir(p1);
    q.Inserir(p2);
    q.Inserir(p3);
    Console.WriteLine(q.Sede.Nome);
    Console.WriteLine(q.Ano);
    foreach (Pais p in q.Listar())
      Console.WriteLine(p);
    q.SalvarCSV("olimp.csv");
    q.SalvarXML("olimp.xml");
  }
}
