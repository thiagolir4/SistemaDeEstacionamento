
namespace sistema_de_estacionamento.models
{
    public class Veiculos
    {
       List<string> listaDeVeiculos = new();

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Qual o Placa do veiculo");
                string placa = Console.ReadLine().ToUpper();
                listaDeVeiculos.Add(placa);

        }
        public void ListarVeiculos()
        {
            Console.WriteLine("Lista de veiculos");
                foreach(string i in listaDeVeiculos)
                {
                    Console.WriteLine(i);
                }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Qual a placa do veiculo a ser removido");
                string placaRemover = Console.ReadLine().ToUpper();
                if (!listaDeVeiculos.Contains(placaRemover.ToUpper())) Console.WriteLine("Desculpe, o veiculo não está no nosso estacionaemnto!!");
                else{
                listaDeVeiculos.Remove(placaRemover);
                Console.WriteLine("Quantas horas o veiculos ficuou no estacionamento?");
                decimal horas = decimal.Parse(Console.ReadLine());
               
                
                Console.WriteLine($"O veiculo {placaRemover} saiu do estacionamento e o valor cobrado foi de R${horas  * 15,00}");
                }
        }
    }
}




















//     public class Veiculos
//     {
    
//         public void AdicionarVeiculos()
//         {

//         }
//         public void ListarVeiculos()
//         {

//         }
    
//         public void RemoverVeiculos()
//         {
            
//         }
//     }
// 