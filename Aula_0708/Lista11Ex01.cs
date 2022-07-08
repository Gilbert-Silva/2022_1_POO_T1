using System;
using System.Collections.Generic;

class Program {
  public static void Main() {
    int n = 0x401;         // 1025 em Hexa
    int k = 0b10000000001; // 1025 em Binário
    Console.WriteLine(n);
    Console.WriteLine(k);
    Console.WriteLine($"{k:X}");
    Conversor c = new Conversor();
    c.SetNum(1025);
    Console.WriteLine(c.GetNum());
    Console.WriteLine(c.Binario());
  }
}

class Conversor {
  private int num;
  private Stack<int> pilha = new Stack<int>();
  public void SetNum(int num) {
    if (num > 0) this.num = num;
  }
  public int GetNum() {
    return num;
  }
  public string Binario() {
    pilha.Clear();
    int x = num;
    while (x != 0) {
      pilha.Push(x % 2);
      x = x / 2;
    }
    string r = "";
    while (pilha.Count > 0) {
      r = r + pilha.Pop().ToString();
    }
    return r;
  }
}