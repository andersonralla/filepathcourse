using System;
using System.IO;

namespace funcao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string diretorioEntrada = @"C:\Users\anderson.oliveira\Documents\Anderson\!\CursoC#\ExercicioCursoFilePath\Vendas.csv";
            string diretorioSaida = @"C:\Users\anderson.oliveira\Documents\Anderson\!\CursoC#\ExercicioCursoFilePath\Vendas2.csv";

            if (!File.Exists(diretorioEntrada))
            {
                Console.WriteLine("Arquivo de entrada não encontrado.");
                return; 
            }

            try
            {
                using (StreamReader leitor = new StreamReader(diretorioEntrada))
                {
                    using (StreamWriter escritor = new StreamWriter(diretorioSaida))
                    {
                        string linha;
                        while ((linha = leitor.ReadLine()) != null)
                        {
                            string[] dados = linha.Split(';');
                            string produto = dados[0];
                            double valorUnitario = double.Parse(dados[1]);
                            int quantidade = int.Parse(dados[2]);

                            Venda venda = new Venda(produto, quantidade, valorUnitario);

                            double totalVenda = venda.CalcularTotal();

                            escritor.WriteLine($"{produto},{totalVenda}");
                        }
                    }
                }

                Console.WriteLine("Processamento concluído. Verifique o arquivo vendas2.csv.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}
