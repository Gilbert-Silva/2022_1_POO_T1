class Frete:                           
  def __init__(self, distancia, peso):
    self.__distancia = distancia
    self.__peso = peso
  def get_distancia(self):
    return self.__distancia
  def get_peso(self):
    return self.__peso
  def set_distancia(self, distancia):
    self.__distancia = distancia
  def set_peso(self, peso):
    self.__peso = peso
  def calc_frete(self):
    return 0.01 * self.__distancia * self.__peso
  def __str__(self):
    return f"Distancia = {self.__distancia} km, Peso = {self.__peso} kg"


if __name__ == "__main__":
  f = Frete(100, 10)  
  print(f)
  print(f.get_distancia())
  print(f.get_peso())
  print(f.calc_frete())
  f.set_distancia(150)
  print(f)
  print(f.calc_frete())

