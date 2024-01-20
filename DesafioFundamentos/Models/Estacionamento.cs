using Microsoft.Win32.SafeHandles;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>(); // Lista para armazenar as placas dos veículos estacionados
<<<<<<< HEAD
        private int quantVeiculos;
        private int limite = 2;
=======
>>>>>>> 93b3c1cda610eeeabbda9d38050f02db0c0dacfb

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()  // Método para adicionar um veículo ao estacionamento
        {
            // *IMPLEMENTADO*
            
            Console.WriteLine("Digite a placa do veículo para estacionar:");  // Solicitar ao usuário digitar uma placa e adicionar à lista "veiculos"
<<<<<<< HEAD
              
            string placa = Console.ReadLine();
            
            if (quantVeiculos > limite)
            {
                Console.WriteLine("Execedeu o Limite de Veiculos no estacionamento!");
                
            }
            else
            {
                veiculos.Add(placa);
                quantVeiculos += 1 ;
                limite -= 1;
            }
=======
            
            string placa = Console.ReadLine();
            
            veiculos.Add(placa);
>>>>>>> 93b3c1cda610eeeabbda9d38050f02db0c0dacfb
        }

        public void RemoverVeiculo()  // Método para remover um veículo do estacionamento
        {
<<<<<<< HEAD
=======
            // *IMPLEMENTADO*
>>>>>>> 93b3c1cda610eeeabbda9d38050f02db0c0dacfb

            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine();  // Pedir ao usuário digitar a placa e armazenar na variável placa
            
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))  // Verifica se o veículo existe
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                
                // *IMPLEMENTADO
                
                if (int.TryParse(Console.ReadLine(),out int horas))   // Tenta converter a entrada do usuário em um valor inteiro        
                {
                    decimal valorTotal = precoInicial + (precoPorHora * horas);  // Calcular o valor total

<<<<<<< HEAD
                decimal valorTotal = int.TryParse(Console.ReadLine(), out int horas)? precoInicial + (precoPorHora * horas): 0 ;
                
                quantVeiculos -=1;  limite += 1;

                Console.WriteLine(valorTotal > 0 && veiculos.Remove(placa) ? $"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}" : "Por favor, insira um valor válido para as horas." );

=======
                    // *IMPLEMENTADO!*

                    veiculos.Remove(placa);  // Remover o veículo da lista
                
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");  // Exibir mensagem de remoção
                }
                else
                {
                    Console.WriteLine("Por favor, insira um valor válido para as horas.");
                }
>>>>>>> 93b3c1cda610eeeabbda9d38050f02db0c0dacfb
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()  // Método para listar os veículos estacionados
        {
            if (veiculos.Any())  // Verificar se há veículos no estacionamento
            {
<<<<<<< HEAD
                Console.WriteLine($"Veiculos estacionados: {quantVeiculos}" );
=======
                Console.WriteLine("Os veículos estacionados são:");
>>>>>>> 93b3c1cda610eeeabbda9d38050f02db0c0dacfb
                
                // *IMPLEMENTADO!
                
                foreach(string x in veiculos) // Iterar sobre a lista e exibir cada veículo
                {
                    Console.WriteLine($"Veiculo:{x}");
                }
<<<<<<< HEAD
                Console.WriteLine(limite == 0 ? $"Não há vagas disponiveis" : $"vagas disponiveis:{limite}");
=======
>>>>>>> 93b3c1cda610eeeabbda9d38050f02db0c0dacfb
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}





            /*if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))  // Verifica se o veículo existe
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                
                // *IMPLEMENTADO
                
                if (int.TryParse(Console.ReadLine(),out int horas))   // Tenta converter a entrada do usuário em um valor inteiro        
                {
                    decimal valorTotal = precoInicial + (precoPorHora * horas);  // Calcular o valor total

                    // *IMPLEMENTADO!*

                    veiculos.Remove(placa);  // Remover o veículo da lista
                
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");  // Exibir mensagem de remoção
                }
                else
                {
                    Console.WriteLine("Por favor, insira um valor válido para as horas.");
                }
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }*/
