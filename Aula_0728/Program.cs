using System;

class Program {
  private static bool adminLogado = false;
  private static Cliente clienteLogado = null;

  public static InserirAdmin() {
    Usuario u = new Usuario();
    u.Nome = "admin";
    u.Senha = "admin";
    u.Admin = true;
    NUsuario.Inserir(u);
  }
  
  public static void Main() {
    InserirAdmin();    
    Console.WriteLine("--- Bem-vindo ao IFShop ---");
    int op = 0;
    do {
      try {
        op = Menu();
        switch (op) {
            // Categoria
            case 01 : 
              if (Login()) { 
                if (adminLogado) MainAdmin();
                else MainCliente();
              }
              else 
                Console.WriteLine("Usuário ou senha inválidos");
              break;
            case 02 : Cadastrarse(); break;
        }
      }
      catch (Exception erro) {
        Console.WriteLine(erro.Message);      
      }
    } while (op != 99);
  }
    
  public static void MainAdmin() {
    int op = 0;
    do {
      try {
        op = MenuAdmin();
        switch (op) {
            // Categoria
            case 01 : CategoriaInserir(); break;
            case 02 : CategoriaListar(); break;
            case 03 : CategoriaAtualizar(); break;
            case 04 : CategoriaExcluir(); break;
            // Produto
            case 05 : ProdutoInserir(); break;
            case 06 : ProdutoListar(); break;
            case 07 : ProdutoAtualizar(); break;
            case 08 : ProdutoExcluir(); break;
          }
      }
      catch (Exception erro) {
        Console.WriteLine(erro.Message);      
      }
    } while (op != 99);
  }
  public static void MainCliente() {
    int op = 0;
    do {
      try {
        op = MenuCliente();
        switch (op) {
        }
      }
      catch (Exception erro) {
        Console.WriteLine(erro.Message);      
      }
    } while (op != 99);
  }  
  
  public static int Menu() {
    Console.WriteLine();
    Console.WriteLine("----- Selecione ------");
    Console.WriteLine("  01 - Login");
    Console.WriteLine("  02 - Cadastrar-se");
    Console.WriteLine("----------------------");
    Console.WriteLine("  99 - Sair");
    Console.WriteLine("----------------------");
    Console.Write("Opção: ");
    return int.Parse(Console.ReadLine());    
  }

  public static int MenuAdmin() {
    Console.WriteLine();
    Console.WriteLine("----- Categorias -----");
    Console.WriteLine("  01 - Inserir");
    Console.WriteLine("  02 - Listar");
    Console.WriteLine("  03 - Atualizar");
    Console.WriteLine("  04 - Excluir");
    Console.WriteLine("------ Produtos ------");
    Console.WriteLine("  05 - Inserir");
    Console.WriteLine("  06 - Listar");
    Console.WriteLine("  07 - Atualizar");
    Console.WriteLine("  08 - Excluir");
    Console.WriteLine("----------------------");
    Console.WriteLine("  99 - Logout");
    Console.WriteLine("----------------------");
    Console.Write("Opção: ");
    return int.Parse(Console.ReadLine());    
  }
  
  public static int MenuCliente() {
    Console.WriteLine();
    Console.WriteLine($"--- Bem-vindo: {clienteLogado.Nome} ---" );
    Console.WriteLine("----------------------");
    Console.WriteLine("  99 - Logout");
    Console.WriteLine("----------------------");
    Console.Write("Opção: ");
    return int.Parse(Console.ReadLine());    
  }

  public static bool Login() {
    Console.WriteLine("Informe o nome");
    string nome = Console.ReadLine();
    Console.WriteLine("Informe a senha");
    string senha = Console.ReadLine();
    Usuario u = NUsuario.Autenticar(nome, senha);
    if (u != null) {
      // Alguém logou! true -> admin, false -> cliente
      adminLogado = u.Admin;
      // Cliente logado se estiver no cadastro de clientes
      // o id do usuário informado
      clienteLogado = NCliente.Listar(u.Id); 
      return true;
    }
    return false;
  }
  public static void Cadastrarse() {
    Console.WriteLine("Informe o nome");
    string nome = Console.ReadLine();
    Console.WriteLine("Informe a senha");
    string senha = Console.ReadLine();
    // Usuario
    Usuario u = new Usuario();
    u.Nome = nome;
    u.Senha = senha;
    u.Admin = false;
    int idUsuario = NUsuario.Inserir(u);
    // Cliente
    Cliente c = new Cliente();
    c.Nome = nome;
    c.IdUsuario = idUsuario; 
    NCliente.Inserir(c);
    Console.WriteLine("Cliente cadastrado com sucesso");
  }
  
  public static void CategoriaInserir() {
    Console.WriteLine("----- Nova Categoria -----");

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
    Console.WriteLine("----- Lista de Categorias -----");
    foreach(Categoria obj in NCategoria.Listar())
      Console.WriteLine(obj);
  }
  public static void CategoriaAtualizar() {
    Console.WriteLine("----- Atualizar Categoria -----");

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
    Console.WriteLine("----- Excluir Categoria -----");
    foreach(Categoria obj in NCategoria.Listar())
      Console.WriteLine(obj);

    Console.WriteLine("Informe o id da categoria a ser excluída");
    int id = int.Parse(Console.ReadLine());
    
    Categoria c = new Categoria();
    c.Id = id;

    NCategoria.Excluir(c);

    Console.WriteLine("Categoria excluída com sucesso");
  }

  public static void ProdutoInserir() {
    Console.WriteLine("----- Novo Produto -----");

    Console.WriteLine("Informe a descrição do produto");
    string desc = Console.ReadLine();
    Console.WriteLine("Informe o preço");
    double preco = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe o estoque");
    int estoque = int.Parse(Console.ReadLine());

    CategoriaListar();
    Console.WriteLine("Informe o id da categoria");
    int idCategoria = int.Parse(Console.ReadLine());
    
    Produto c = new Produto();
    c.Descricao = desc;
    c.Preco = preco;
    c.Estoque = estoque;
    c.IdCategoria = idCategoria;

    NProduto.Inserir(c);

    Console.WriteLine("Produto inserido com sucesso");
  }
  public static void ProdutoListar() {
    Console.WriteLine("----- Lista de Produtos -----");
    foreach(Produto obj in NProduto.Listar())
      Console.WriteLine(obj + " - Categoria: " +
        NCategoria.Listar(obj.IdCategoria).Descricao);
  }
  public static void ProdutoAtualizar() {
    Console.WriteLine("----- Atualizar Produto -----");

    foreach(Produto obj in NProduto.Listar())
      Console.WriteLine(obj);
    
    Console.WriteLine("Informe o id da produto a ser atualizado");
    int id = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe a nova descrição da produto");
    string desc = Console.ReadLine();
    Console.WriteLine("Informe o preço");
    double preco = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe o estoque");
    int estoque = int.Parse(Console.ReadLine());

    CategoriaListar();
    Console.WriteLine("Informe o id da categoria");
    int idCategoria = int.Parse(Console.ReadLine());
    
    Produto c = new Produto();
    c.Id = id;
    c.Descricao = desc;
    c.Preco = preco;
    c.Estoque = estoque;
    c.IdCategoria = idCategoria;

    NProduto.Atualizar(c);

    Console.WriteLine("Produto atualizado com sucesso");
  }
  public static void ProdutoExcluir() {
    Console.WriteLine("----- Produto Excluir -----");
    foreach(Produto obj in NProduto.Listar())
      Console.WriteLine(obj);

    Console.WriteLine("Informe o id do produto a ser excluído");
    int id = int.Parse(Console.ReadLine());
    
    Produto c = new Produto();
    c.Id = id;

    NProduto.Excluir(c);

    Console.WriteLine("Produto excluído com sucesso");
  }
}