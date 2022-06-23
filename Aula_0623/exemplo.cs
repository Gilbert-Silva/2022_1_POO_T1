using System;
using System.Collections;

class Program {
  public static void Main() {
    Jogador x = new Jogador("Zico", 10);
    object y = new Jogador("Ronaldinho", 9);
    Console.WriteLine(y.ToString());
//    Console.WriteLine(y.CompareTo(x));
    Console.WriteLine(x.CompareTo(y));
    
    /*
    int[] v = { 5, 8, 10, 1, 3, 40, 7 };
    Array.Sort(v);
    foreach (int i in v)
      Console.Write(i + " ");
    Console.WriteLine();
    // Lexicográfica
    string[] w = { "Python", "C#", "C++", "Java", "Escala", "Assembly", "10", "2" };
    Array.Sort(w);
    foreach (string s in w)
      Console.Write(s + " ");
    Console.WriteLine();
    */
    Jogador j1 = new Jogador("Nithael", 5);
    Jogador j2 = new Jogador("Eduardo", 15);
    Jogador j3 = new Jogador("Gilbert", 11);
    Jogador j4 = new Jogador("Hilquias", 10);
    Jogador j5 = new Jogador("Gabriel", 9);
    Jogador[] js = { j1, j2, j3, j4, j5 }; 

    Console.WriteLine("Java".CompareTo("C#"));
    Console.WriteLine("Java".CompareTo("Java"));
    Console.WriteLine("C#".CompareTo("Java"));

    Console.WriteLine(5.CompareTo(3));
    Console.WriteLine(5.CompareTo(5));
    Console.WriteLine(3.CompareTo(5));
    
    Console.WriteLine(j1.CompareTo(j2));

    Array.Sort(js); // IComparable
    foreach (Jogador j in js)
      Console.WriteLine(j);

    //ComparaCamisa comp = new ComparaCamisa();
    //Console.WriteLine(comp.Compare(j1, j2));
    //Array.Sort(js, comp); // IComparer

    Array.Sort(js, new ComparaCamisa(); // IComparer
    foreach (Jogador j in js)
      Console.WriteLine(j);
  }
}

class Jogador : IComparable {
  private string nome;
  private int camisa;
  public Jogador(string nome, int camisa) {
    this.nome = nome;
    this.camisa = camisa;
  }
  public int GetCamisa() {
    return camisa;
  }
  public int CompareTo(object obj) {
    // Type-cast
    // Jogador j = obj as Jogador;
    Jogador j = (Jogador) obj;
    /*
    if (this.camisa < j.camisa) return -1;
    else if (this.camisa == j.camisa) return 0;
    else return 1;
    */
    //return this.camisa.CompareTo(j.camisa);
    return this.nome.CompareTo(j.nome);
  }
  public override string ToString() {
    return $"{nome} - {camisa}";
  }
}

class ComparaCamisa : IComparer {
   public int Compare (object x, object y) {
      Jogador jx = (Jogador) x;
      Jogador jy = (Jogador) y;
      return jx.GetCamisa().CompareTo(jy.GetCamisa());
   }
}

class Treinador {
  
}

/*
interface IComparable {
  int CompareTo(object obj);
}
*/
