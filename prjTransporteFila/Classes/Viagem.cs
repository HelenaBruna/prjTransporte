using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTransporteFila.Classes
{
    public class Viagem
    {
        public Veiculo Veiculo { get; set; }
        public Queue<Visitante> Passageiros { get; set; }
        public DateTime DtViagem { get; set; }

        public Viagem(Veiculo veiculo, Queue<Visitante> passageiros, DateTime dtViagem)
        {
            Veiculo = veiculo;
            Passageiros = passageiros;
            DtViagem = dtViagem;
        }

        public int QtdPassageiros()
        {
            return Passageiros.Count();
        }

        public override string ToString()
        {
            return $"{Veiculo.ToString()} - {DtViagem.ToString("yyyy/MM/dd HH:mm:ss")}";
        }
    }
}
