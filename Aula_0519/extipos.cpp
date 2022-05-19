#include <iostream>

using namespace std;

class Aluno {
  public:
    string nome;       // Campo ou atributo
    string matricula;
    int idade;
};

int main() {
  int x = 5; // Tipo primitivo/fundamental
  int y = 15;
  string s = "Tecnologia";
  string r = "Analise e Desenvolvimento";
  int z = s.find('l');
  int w = r.find('l');
  cout << z << endl;     
  cout << &x << endl;
  cout << &y << endl;
  cout << &s << endl;

  Aluno a;
}