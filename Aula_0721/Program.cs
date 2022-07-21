using System;

class Program {
  public static void Main() {
    Console.WriteLine("--- Bem-vindo ao IFShop ---");
    Console.WriteLine();
    int op = 0;
    do {
      try {
        op = Menu();
        switch (op) {
            case 01 : CategoriaInserir(); break;
            case 02 : CategoriaListar(); break;
            case 03 : CategoriaAtualizar(); break;
            case 04 : CategoriaExcluir(); break;
          }
      }
      catch (Exception erro) {
        Console.WriteLine(erro.Message);      
      }
    } while (op != 99);
  }
  public static int Menu() {
    Console.WriteLine("----- Categorias -----");
    Console.WriteLine("  01 - Inserir");
    Console.WriteLine("  02 - Listar");
    Console.WriteLine("  03 - Atualizar");
    Console.WriteLine("  04 - Excluir");
    Console.WriteLine("----------------------");
    Console.WriteLine("  99 - Fim");
    Console.WriteLine("----------------------");
    Console.Write("Opção: ");
    return int.Parse(Console.ReadLine());    
  }
  public static void CategoriaInserir() {
    Console.WriteLine("----- Categoria Inserir -----");

    //Console.WriteLine("Informe o id da categoria");
    //int id = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe a descrição da categoria");
    string desc = Console.ReadLine();

    Categoria c = new Categoria();
    //c.Id = id;
    c.Descricao = desc;

    NCategoria.Inserir(c);

    Console.WriteLine("Categoria inserida com sucesso");
  }
  public static void CategoriaListar() {
    Console.WriteLine("----- Categoria Listar -----");
    foreach(Categoria obj in NCategoria.Listar())
      Console.WriteLine(obj);
  }
  public static void CategoriaAtualizar() {
    Console.WriteLine("----- Categoria Atualizar -----");

    foreach(Categoria obj in NCategoria.Listar())
      Console.WriteLine(obj);
    
    Console.WriteLine("Informe o id da categoria a ser atualizada");
    int id = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe a nova descrição da categoria");
    string desc = Console.ReadLine();
    
    Categoria c = new Categoria();
    c.Id = id;
    c.Descricao = desc;

    NCategoria.Atualizar(c);

    Console.WriteLine("Categoria atualizada com sucesso");
  }
  public static void CategoriaExcluir() {
    Console.WriteLine("----- Categoria Excluir -----");
    foreach(Categoria obj in NCategoria.Listar())
      Console.WriteLine(obj);

    Console.WriteLine("Informe o id da categoria a ser excluída");
    int id = int.Parse(Console.ReadLine());
    
    Categoria c = new Categoria();
    c.Id = id;

    NCategoria.Excluir(c);

    Console.WriteLine("Categoria excluída com sucesso");
  }
}