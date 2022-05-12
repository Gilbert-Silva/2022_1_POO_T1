using System;

class Program {
  public static void Main() {
    string s = Console.ReadLine().ToUpper();
    while (s != "*") {
      bool ok = true;
      char c = s[0]; // Primeira letra do texto
      // K vai de 0 até o índice da última letra
      for (int k = 0; k < s.Length; k++) {
        if (s[k] == ' ') {
          if (s[k+1] != c) ok = false;
        }
      }
      //for (int k = 0; k < s.Length && ok; k++) 
      //  if (s[k] == ' ' && s[k+1] != c) ok = false;
      Console.WriteLine(ok ? "Y": "N");
      s = Console.ReadLine().ToUpper();
    }
  }
}