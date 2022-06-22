class Frete:
  def __init__(self):
    self.__distancia = 0
    self.__peso = 0

  @property                               # get
  def Distancia(self):
    return self.__distancia
  
  @Distancia.setter                       # set
  def Distancia(self, distancia):
    if distancia > 0:
      self.__distancia = distancia

  @property
  def Peso(self):
    return self.__peso

  @Peso.setter
  def Peso(self, peso):
    if peso > 0:
      self.__peso = peso

  @property
  def ValorFrete(self):
    return 0.01 * self.__distancia * self.__peso
 
  def __str__(self):
    return f"Distancia = {self.__distancia}, Peso = {self.__peso}"

if __name__ == "__main__":
  f = Frete()
  f.Distancia = 10
  f.Peso = 50
  print(f)
  valor = f.ValorFrete
  print(f"Valor do frete = R$ {valor:0.2f}")
  