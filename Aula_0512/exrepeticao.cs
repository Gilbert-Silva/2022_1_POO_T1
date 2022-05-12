using System;

class Program {
  public static void Main() {
    Console.WriteLine("while");
    int x = 1;
    while (x <= 10) {
      Console.WriteLine(x);
      x++; // x += 1;
    }

    Console.WriteLine("for");
    for (x = 1; x <= 10; x++) {
      Console.WriteLine(x);
    }
    
    Console.WriteLine("do-while");
    x = 1;
    do {
      Console.WriteLine(x);
      x++; // x += 1;
    } while (x <= 10);

    Console.WriteLine("for com break");
    x = 1;
    for (;;) {
      Console.WriteLine(x);
      x++; // x += 1;
      if (x > 10) break;
    }

    Console.WriteLine("foreach - string");
    string s = "Tecnologia";
    foreach(char c in s)
      Console.WriteLine(c);

    Console.WriteLine("foreach - Array");
    int[] v = { 5, 3, 2, 1, 9, 10 };
    Array.Sort(v);
    foreach(int i in v)
      Console.WriteLine(i);
    Console.WriteLine(v.GetType());
    
    
    
  }
}
