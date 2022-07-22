from Categoria import Categoria

class NCategoria:
  categorias = []

  @classmethod
  def inserir(cls, c):
    #calculando o id
    id = 0
    for obj in cls.categorias:
      if obj.id > id: id = obj.id
    id += 1
    c.id = id;
    cls.categorias.append(c)
  
  @classmethod
  def listar(cls):
    cls.categorias.sort(key = Categoria.order_descricao)
    return cls.categorias

  @classmethod
  def listar_id(cls, id):
    for obj in cls.categorias:
      if obj.id == id: return obj
    return None

  @classmethod
  def atualizar(cls, c):
    atual = cls.listar_id(c.id)
    if atual != None:
      atual.descricao = c.descricao

  @classmethod
  def excluir(cls, c):
    atual = cls.listar_id(c.id)
    if atual != None: 
      cls.categorias.remove(atual)

if __name__ == "__main__":
  c1 = Categoria(0, "Teclado")
  c2 = Categoria(0, "Mouse")

  n1 = NCategoria()
  n2 = NCategoria()
  
  
  NCategoria.inserir(c1)
  NCategoria.inserir(c2)
  for c in NCategoria.listar():
    print(c)
    