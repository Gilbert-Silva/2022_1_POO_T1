from Categoria import Categoria
from NCategoria import NCategoria

class Program:
  @staticmethod
  def main():
    print("--- Bem-vindo ao IFShop ---")
    print()
    op = 0
    while op != 99:
      try:
        op = Program.menu()
        if op == 1: Program.categoria_inserir()
        if op == 2 : Program.categoria_listar()
        if op == 3 : Program.categoria_atualizar()
        if op == 4 : Program.categoria_excluir()
      except Exception as erro:
        print(erro)

  @staticmethod
  def menu():
    print("----- Categorias -----")
    print("  01 - Inserir")
    print("  02 - Listar")
    print("  03 - Atualizar")
    print("  04 - Excluir")
    print("----------------------")
    print("  99 - Fim");
    print("----------------------")
    print("Opção: ", end="")
    return int(input())

  @staticmethod
  def categoria_inserir():
    print("----- Categoria Inserir -----")
    print("Informe a descrição da categoria")
    desc = input()
    c = Categoria(0, desc)
    NCategoria.inserir(c)
    print("Categoria inserida com sucesso")

  @staticmethod
  def categoria_listar():
    print("----- Categoria Listar -----");
    for obj in NCategoria.listar(): print(obj)

  @staticmethod
  def categoria_atualizar():
    print("----- Categoria Atualizar -----");
    for obj in NCategoria.listar(): print(obj)
    print("Informe o id da categoria a ser atualizada")
    id = int(input())
    print("Informe a nova descrição da categoria");
    desc = input()
    c = Categoria(id, desc)
    NCategoria.atualizar(c)
    print("Categoria atualizada com sucesso")

  def categoria_excluir():
    print("----- Categoria Excluir -----")
    for obj in NCategoria.listar(): print(obj)
    print("Informe o id da categoria a ser excluída")
    id = int(input())
    c = Categoria(id, "")
    NCategoria.excluir(c)
    print("Categoria excluída com sucesso")

if __name__ == "__main__":
  Program.main()