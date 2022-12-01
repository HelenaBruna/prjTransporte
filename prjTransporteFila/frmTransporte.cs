using prjTransporteFila.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjTransporteFila
{
    public partial class frmTransporte : Form
    {
        private Embarque classeEmbarque;

        private System.Timers.Timer _timer;
        private const int viagemIntervalo = 30 * 60 * 1000;
        public frmTransporte()
        {
            InitializeComponent();

            classeEmbarque = new Embarque();

            agendarViagens();
        }
        private void agendarViagens()
        {
            _timer = new System.Timers.Timer();
            _timer.AutoReset = false;
            _timer.Interval = viagemIntervalo; // Intervalo em milésimos
            _timer.Elapsed += new System.Timers.ElapsedEventHandler(executarTarefa);
            _timer.Enabled = true;
        }

        private void executarTarefa(object sender, System.Timers.ElapsedEventArgs e)
        {
            _timer.Enabled = false;
            realizarViagem();
            _timer.Enabled = true;
        }

        private void realizarViagem()
        {
            classeEmbarque.realizarViagem();
            alterarListaVeiculos();
            alterarListaVisitantes();
            MessageBox.Show("Viagem realizada");
        }

        private void alterarListaVisitantes()
        {
            lstEmbarque.Items.Clear();

            foreach (var visitante in classeEmbarque.Visitantes)
            {
                lstEmbarque.Items.Add(visitante.ToString());
            }
        }

        private void alterarListaVeiculos()
        {
            lstVeiculo.Items.Clear();

            foreach (var veiculo in classeEmbarque.Veiculos)
            {
                lstVeiculo.Items.Add(veiculo.ToString());
            }
        }
        private void limparCamposVeiculos()
        {
            txtVeiculo.Text = "";
            txtNomeMotorista.Text = "";
            nudVeiculo.Text = "";
        }

        private void limparCamposVisitantes()
        {
            txtInscricao.Text = "";
            txtNomeVisitante.Text = "";
        }

        private void btnAdicionarQtdVeic_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVeiculo.Text))
            {
                MessageBox.Show("Informe os valores do campo de placa");
                return;
            }

            if (string.IsNullOrEmpty(txtNomeMotorista.Text))
            {
                MessageBox.Show("Informe os valores do campo de nome do motorista");
                return;
            }

            if (string.IsNullOrEmpty(nudVeiculo.Text))
            {
                MessageBox.Show("Informe os valores do campo qtd de veículos");
                return;
            }

            Veiculo veiculo = new Veiculo(
                txtVeiculo.Text,
                txtNomeMotorista.Text,
                int.Parse(nudVeiculo.Text)
            );

            classeEmbarque.addVeiculo(veiculo);
            alterarListaVeiculos();
            limparCamposVeiculos();

            if (classeEmbarque.prontoParaViagem())
            {
                realizarViagem();
            } 
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInscricao.Text))
            {
                MessageBox.Show("Informe o valor da inscrição");
                return;
            }

            if (string.IsNullOrEmpty(txtNomeVisitante.Text))
            {
                MessageBox.Show("Informe o nome do visitante");
                return;
            }

            Visitante visitante = new Visitante(
                txtInscricao.Text,
                txtNomeVisitante.Text
            );

            classeEmbarque.checkInVisitante(visitante);
            alterarListaVisitantes();
            limparCamposVisitantes();

            if (classeEmbarque.prontoParaViagem())
            {
                realizarViagem();
            }
        }

        private void btnRemuneracao_Click(object sender, EventArgs e)
        {
            if (lstVeiculo.SelectedItems.Count > 0)
            {
                int indexSelected = lstVeiculo.SelectedIndex;

                if (indexSelected >= 0)
                {
                    var veiculo = classeEmbarque.Veiculos.ToList().ElementAt(indexSelected);

                    var remuneracaoVeiculo = classeEmbarque.remuneracaoVeiculo(veiculo);

                    MessageBox.Show($"O valor a ser recebido do veiculo com a placa {veiculo.Placa} é {remuneracaoVeiculo}");
                    return;
                }
            }

            MessageBox.Show("Selecione na lista o veiculo para visualizar a remuneração");
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            var frmHistorico = new frmHistorico(classeEmbarque);
            frmHistorico.Show();
        }
    }
}
