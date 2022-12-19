namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        private List<string> clientes = new List<string>();
  

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {   
           
            Console.WriteLine("Digite o nome do cliente:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a placa do veículo:");
            string placa = Console.ReadLine();
            
            string[] placaNome = new string[2];
            placaNome[0] = placa;
            placaNome[1] = nome;

            if(veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Hm... Este veículo já está aqui!");
            }
            else
            {
        
                veiculos.Add(placa);
                clientes.Add(placaNome[0] + " " + placaNome[1]);

            }
           
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite o nome do cliente:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();
           

           
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas;
                
                veiculos.Remove(placa);
                clientes.Remove(placa + " " + nome);
                Console.WriteLine($"O cliente {nome} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            int i = 1;
            if (veiculos.Any())
            {
                Console.WriteLine("Os clientes do estacionamento são:");
                foreach (string cliente in clientes)
                {
                    Console.WriteLine($"{i}° {cliente}");
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
