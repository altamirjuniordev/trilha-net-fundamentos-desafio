using System.ComponentModel;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;     // privada Variável decimal nomedavar recebe 0;
        private decimal precoPorHora = 0;     // privada variável decimal nomedavar recebe 0;
        private List<string> veiculos = new List<string>(); // criaListaPrivada privada tipoDeDados nome recebe inicialização; 

        public Estacionamento(decimal precoInicial, decimal precoPorHora)     // (construtor da classe Estacionamento) Publica nomeClasser (tipo nome, tipo nome)
        {
            this.precoInicial = precoInicial;     // instanciaAtualDaCkasse.Nome recebe nome
            this.precoPorHora = precoPorHora;     // instanciaAtualDaClasse.Nome recebe nome
        }

        public void AdicionarVeiculo()     // métodoPublico
        {
            
            
            Console.WriteLine("Digite a placa do veículo para estacionar:"); // Mensagem
            string  addPlaca = Console.ReadLine();      // tipoDado nome recebe entradaDado();

            veiculos.Add(addPlaca);     // listaVeiculos.Adiciona(dadoEntradaAcima)

            Console.Write($"Veículo de placa {addPlaca} adicionado");     // mensagemConfirmacao

        }

        public void RemoverVeiculo()     // métodoPúblico
        {
            Console.WriteLine("Digite a placa do veículo para remover:");     // mensagem

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            
            string placa = "";     // criaDado nome recebe vazio;
            placa = Console.ReadLine();    // variadaCriada recebe entradaDado;
            
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))     // se (nomeLista.Algum (x => x.Maiúsculo() forIgual dadoPedidoAcima.Maiúsculo))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");      // mensagem

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                int horas = int.Parse(Console.ReadLine());     // salvaEntradaConvertidoInteiro - tipo nome recebe inteiro.Passar(entrada());
                
                decimal valorTotal = precoInicial + (precoPorHora * horas);      // cálculoHoraSalvando

                Console.WriteLine($"O valor de sua permanência ficou R$: {valorTotal}");      // mensagem          

                // TODO: Remover a placa digitada da lista de veículos
                veiculos.Remove(placa);     // lista.Remover(entradaConfirmadaNaLista)



                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");     // mensagem
            }
            else     // senao
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");     // mensagem
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                for (int contador = 0; contador < veiculos.Count; contador++ )
                {
                    Console.WriteLine($"Veículo {contador}: {veiculos[contador] }"
                    );
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
