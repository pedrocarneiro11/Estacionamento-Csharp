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
            // Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
             
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            var placa = Console.ReadLine();

            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            
            Console.WriteLine("Digite a placa do veículo para remover:");
            // Pedir para o usuário digitar a placa e armazenar na variável placa                         

            var placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                // Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado, OK
                // Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal OK                
                 
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
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // Realizar um laço de repetição, exibindo os veículos estacionados
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