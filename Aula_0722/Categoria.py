class Categoria:
  def __init__(self, id, descricao):
    self.id = id
    self.descricao = descricao
  def __str__(self):
    return f"{self.id} - {self.descricao}";
  @staticmethod
  def order_descricao(categoria):
    return categoria.descricao

if __name__ == "__main__":
  c1 = Categoria(1, "Teclado")
  c2 = Categoria(2, "Mouse")
  v = [c1, c2]
  v.sort(key = Categoria.order_descricao)
  print(v)
  for c in v:
    print(c)