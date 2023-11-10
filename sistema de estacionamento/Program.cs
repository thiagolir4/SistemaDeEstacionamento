using sistema_de_estacionamento.models;
 
Veiculos veiculos = new();

while(true) {
     Console.WriteLine("-------------------------\nA - Adicionar\nL - Listar\nR - Remover\nS - Sair\n-------------------------");

     Console.WriteLine("Escolha uma opcao de menu: ");
     string opcao = Console.ReadLine();
    
          if (opcao == "A" || opcao =="a")
          {
               veiculos.AdicionarVeiculo();
          }
          else if (opcao == "L" || opcao =="l")
          {
               veiculos.ListarVeiculos();
          }
          else if (opcao == "R" || opcao =="r")
          {
               veiculos.RemoverVeiculo();
          }
          else if (opcao == "S" || opcao =="s") break;

          else {
               throw new Exception("\n Insira uma das opções do menu, encerrando programa");
          }
    
}