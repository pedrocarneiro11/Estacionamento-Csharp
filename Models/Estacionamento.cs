namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
             
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            var placa = Console.ReadLine();

            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            
            Console.WriteLine("Digite a placa do veículo para remover:");                         

            var placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {              
                 
                int horas = 0;
                decimal valorTotal = 0;
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                horas = Convert.ToInt32(Console.ReadLine());

                valorTotal = precoInicial + (precoPorHora * horas);            

                Console.WriteLine("Preco Inicial: " + precoInicial);            
                Console.WriteLine("Preco Por Hora: " + precoPorHora);            
                Console.WriteLine("Horas: " + horas);            

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");

                veiculos.Remove(placa);

                var isNull="";

                if(isNull==""){
                    Console.WriteLine("Pressione Qualquer Tecla para continuar...");
                    isNull = Console.ReadLine();
                }             
                
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var placa in veiculos) {
                    Console.WriteLine(placa);
                }
                 
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}