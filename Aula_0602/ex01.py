class Pais:
  def __init__(self, nome, populacao):
    self.__nome = "Nome do país"
    self.__populacao = 1
    if nome != "": self.__nome = nome
    if populacao > 0: self.__populacao = populacao
  def set_nome(self, nome):
    if nome != "": self.__nome = nome
  def set_populacao(self, populacao):
    if populacao > 0: self.__populacao = populacao
  def get_nome(self):
    return self.__nome
  def get_populacao(self):
    return self.__populacao
  def __str__(self):
    return f"Nome: {self.__nome} - {self.__populacao} habitante(s)"

if __name__ == "__main__":
  print("Informe o nome do 1º país e sua população")
  nome = input()
  pop = int(input())
  maispop = Pais(nome, pop)
  print(maispop)
  for i in range(2, 4):
    print(f"Informe o nome do {i}º país e sua população")
    nome = input()
    pop = int(input())
    p = Pais(nome, pop)
    print(p)
    if p.get_populacao() > maispop.get_populacao(): maispop = p
  print(f"País mais populoso: {maispop}")



