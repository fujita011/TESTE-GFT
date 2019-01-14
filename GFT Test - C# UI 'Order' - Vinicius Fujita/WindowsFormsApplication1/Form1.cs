using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label6.Visible = false;
            comboBox1.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;

        }
        
        String pedido;
        String entrada, acomp, bebida, sobremesa;
        String periodo;
        int qtde;
        int numItem;


        //Ínicio 21:10 (13/01/2019)


        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            periodo = comboBox4.Text;

            switch (periodo)
            {
                case "Manhã":
                    {
                        MessageBox.Show("Você selecionou 'Manhã'!","Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        label6.Visible = true;
                        label6.Text = "Manhã";
                        textBox5.Visible = false;
                        comboBox1.Visible = true;
                        entrada = "Ovos";
                        acomp = "Torradas";
                        bebida = "Café";
                        sobremesa = "Erro. Não disponível.";
                        comboBox4.Enabled = false;
                        label11.Visible = true;
                        label12.Visible = true;
                        label13.Visible = true;
                        label14.Visible = true;
                        label11.Text = entrada;
                        label12.Text = acomp;
                        label13.Text = bebida;
                        label14.Text = sobremesa;
                        break;
                    }
                case "Noite":
                    {
                        MessageBox.Show("Você selecionou 'Noite'!", "Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        label6.Visible = true;
                        label6.Text = "Noite";
                        textBox5.Visible = false;
                        comboBox1.Visible = true;
                        entrada = "Beef";
                        acomp = "Batatas";
                        bebida = "Vinho";
                        sobremesa = "Bolo";
                        comboBox4.Enabled = false;
                        label11.Visible = true;
                        label12.Visible = true;
                        label13.Visible = true;
                        label14.Visible = true;
                        label11.Text = entrada;
                        label12.Text = acomp;
                        label13.Text = bebida;
                        label14.Text = sobremesa;
                        break;
                    }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pedido = comboBox1.Text;

            switch (pedido)
            {
                case "Entrada":
                    {
                        MessageBox.Show("Gostaria de " +entrada + "?", "Order", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        textBox1.Text = "1";
                        textBox1.ReadOnly = true;
                        break;
                    }
                case "Acompanhamentos":
                    {
                        if (label6.Text == "Noite")
                        {
                            MessageBox.Show("Gostaria de " + acomp + "?", "Order", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            textBox1.ReadOnly = false;
                        }
                        else
                        {
                            MessageBox.Show("Gostaria de " + acomp + "?", "Order", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            textBox1.Text = "1";
                            textBox1.ReadOnly = true;
                        }
                        break;
                    }
                case "Bebida":
                    {
                        if (label6.Text == "Manhã")
                        {
                            MessageBox.Show("Gostaria de " + bebida + "?", "Order", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            textBox1.ReadOnly = false;
                        }
                        else {
                            MessageBox.Show("Gostaria de " + bebida + "?", "Order", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            textBox1.Text = "1";
                            textBox1.ReadOnly = true;
                        }
                        break;
                        
                    }
                case "Sobremesa":
                    {
                        MessageBox.Show("Gostaria de " + sobremesa + "?", "Order", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        textBox1.Text = "1";
                        textBox1.ReadOnly = true;
                        break;

                    }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            qtde = Convert.ToInt16(textBox1.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você adicionou um item","Carrinho",MessageBoxButtons.OK, MessageBoxIcon.Information);
            numItem++;
            dataGridView1.Rows.Add(numItem, pedido, qtde);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado!");
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }







        //Termino 00:30 (14/01/2019)


    }
}
