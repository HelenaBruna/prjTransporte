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
    public partial class frmHistorico : Form
    {
        private Embarque classeEmbarque;

        public frmHistorico(Embarque embarque)
        {
            InitializeComponent();

            classeEmbarque = embarque;

            listaVeiculosViagem();
        }

        private void listaVeiculosViagem()
        {
            lstViagem.Items.Clear();

            foreach (var viagem in classeEmbarque.Viagens)
            {
                lstViagem.Items.Add(viagem.ToString());
            }
        }
        private void listaPassageiros(Queue<Visitante> passageiros)
        {
            lstPassageiro.Items.Clear();

            foreach (var passageiro in passageiros)
            {
                lstPassageiro.Items.Add(passageiro.ToString());
            }
        }

        private void lstViagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstViagem.SelectedItems.Count > 0)
            {
                int indexSelected = lstViagem.SelectedIndex;

                if (indexSelected >= 0)
                {
                    var viagem = classeEmbarque.Viagens[indexSelected];

                    listaPassageiros(viagem.Passageiros);
                }
            }
        }
    }
}
