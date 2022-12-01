using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTransporteFila.Classes
{
    public class Embarque
    {
        private const double valorPassagem = 5;
        public Queue<Veiculo> Veiculos { get; set; }
        public Queue<Visitante> Visitantes { get; set; }
        public List<Viagem> Viagens { get; set; }
        public DateTime? DtUltimaViagem { get; set; }

        public Embarque()
        {
            Viagens = new List<Viagem>();
            Veiculos = new Queue<Veiculo>();
            Visitantes = new Queue<Visitante>();
        }

        public void addVeiculo(Veiculo veiculo)
        {
            Veiculos.Enqueue(veiculo);
        }
        public void checkInVisitante(Visitante visitante)
        {
            Visitantes.Enqueue(visitante);
        }
        public void realizarViagem()
        {
            var passageiros = new Queue<Visitante>();
            var veiculo = Veiculos.Dequeue();

            if (veiculo == null)
            { 
                throw new Exception("Sem veiculos cadastrados");
            }

            while (passageiros.Count() < veiculo.QtdeLotacaoVeiculo && Visitantes.Count() > 0)
            {
                passageiros.Enqueue(Visitantes.Dequeue());
            }

            DtUltimaViagem = DateTime.Now;
            var viagem = new Viagem(veiculo, passageiros, DateTime.Now);

            Viagens.Add(viagem);
            Veiculos.Enqueue(veiculo);
        }

        public bool prontoParaViagem()
        {
            return Visitantes.Count() >= Veiculos.Current()?.QtdeLotacaoVeiculo;
        }

        public double remuneracaoVeiculo(Veiculo veiculo)
        {
            double remuneracao = 0;

            Viagens
                .Where(v => v.Veiculo.Equals(veiculo))
                .ToList()
                .ForEach(viagem =>
                {
                    remuneracao += viagem.QtdPassageiros() * valorPassagem;
                });

            return remuneracao;
        }
    }
}
