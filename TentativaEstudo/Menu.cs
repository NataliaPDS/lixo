using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TentativaEstudo
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bt_botao_Click(object sender, EventArgs e)
        {
            Multiplicacao multi = new Multiplicacao();
            multi.ShowDialog(); 
        }

        private void bt_botao2_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(tx_valor1.Text);
                int b = Convert.ToInt32(tx_valor2.Text);

                int result = a * b;
                label1.Text = result.ToString();
            }catch (Exception ex) 
            { 
                MessageBox.Show("Algo esta errado!");
            }
            finally
            {
                MessageBox.Show("Obrigado por usar!");
            }

        }
    }
}
