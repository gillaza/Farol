using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Farol_3i_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Boolean Stop = false;
        public CancellationTokenSource ts_Sequencia = new CancellationTokenSource();

        private void btn_verde_Click(object sender, EventArgs e)
        {
            lbl_Vermelho.BackColor = Color.White;
            lbl_Amarelo.BackColor = Color.White;
            lbl_Verde.BackColor = Color.Green;
        }

        private void btn_vermelho_Click(object sender, EventArgs e)
        {
            lbl_Vermelho.BackColor = Color.Red;
            lbl_Amarelo.BackColor = Color.White;
            lbl_Verde.BackColor = Color.White;
        }

        private void btn_amarelo_Click(object sender, EventArgs e)
        {
            lbl_Vermelho.BackColor = Color.White;
            lbl_Amarelo.BackColor = Color.Yellow;
            lbl_Verde.BackColor = Color.White;
        }

        private void btn_Automaçao_Click(object sender, EventArgs e)
        {
            var sw = new Stopwatch(); //Medir Tempo
            int i = 0; //Intervalo
            int t = 0; //Transição - Repetições
            while (t < 3)
            {
                //Vermelho
                sw.Reset();
                sw.Start();
                for (i = 0; i < 100 * (nud_Tempo.Value); i++)
                {
                    btn_vermelho.PerformClick();
                }
                sw.Stop();
                lbl_Tempo.Text = sw.ElapsedMilliseconds.ToString();
                MessageBox.Show(i.ToString()); //Observar, tempo
                                               //Amarelo
                sw.Reset();
                sw.Start();
                for (i = 0; i < 100; i++)
                {
                    btn_verde.PerformClick();
                }
                sw.Stop();
                lbl_Tempo.Text = sw.ElapsedMilliseconds.ToString();
                MessageBox.Show(i.ToString()); //Observar, tempo
                                               //Verde
                sw.Reset();
                sw.Start();
                for (i = 0; i < 100 * (nud_Tempo.Value); i++)
                {
                    btn_amarelo.PerformClick();
                    lbl_Tempo.Text = i.ToString();
                    //MessageBox.Show(i.ToString());
                }
                sw.Stop();
                lbl_Tempo.Text = sw.ElapsedMilliseconds.ToString();
                MessageBox.Show(i.ToString()); //Observar, tempo
                                               //Inc 1 em t (Transição - Repetição)
                t++;
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            Stop = true;
            ts_Sequencia.Cancel();
            //this.Close();
        }

        private async void  btn_Sequencial_Click(object sender, EventArgs e)
        {
            try
            {
                while (Stop == false)
                {
                    btn_vermelho.PerformClick();
                    await Task.Delay(10000, ts_Sequencia.Token); // 10 

                    btn_verde.PerformClick();
                    await Task.Delay(10000, ts_Sequencia.Token); // 10 

                    btn_amarelo.PerformClick();
                    await Task.Delay(3000, ts_Sequencia.Token); // 03 

                }
            }
            catch (TaskCanceledException ex)
            {
                MessageBox.Show("Sequencial Cancelada!", "Atenção");
                //MessageBox.Show("Sequencial: "+ex.Message);
            }
            catch (Exception erroX)
            {
                MessageBox.Show("Erro:" + erroX.Message);
            }
        }

        private void btn_amarelo_Click_1(object sender, EventArgs e)
        {
            lbl_Vermelho.BackColor = Color.White;
            lbl_Amarelo.BackColor = Color.Yellow;
            lbl_Verde.BackColor = Color.White;
        }

        private void btn_Automaçao_Click_1(object sender, EventArgs e)
        {
            var sw = new Stopwatch(); //Medir Tempo
            int i = 0; //Intervalo
            int t = 0; //Transição - Repetições
            while (t < 3)
            {
                //Vermelho
                sw.Reset();
                sw.Start();
                for (i = 0; i < 100 * (nud_Tempo.Value); i++)
                {
                    btn_vermelho.PerformClick();
                }
                sw.Stop();
                lbl_Tempo.Text = sw.ElapsedMilliseconds.ToString();
                MessageBox.Show(i.ToString()); //Observar, tempo
                                               //Amarelo
                sw.Reset();
                sw.Start();
                for (i = 0; i < 100; i++)
                {
                    btn_verde.PerformClick();
                }
                sw.Stop();
                lbl_Tempo.Text = sw.ElapsedMilliseconds.ToString();
                MessageBox.Show(i.ToString()); //Observar, tempo
                                               //Verde
                sw.Reset();
                sw.Start();
                for (i = 0; i < 100 * (nud_Tempo.Value); i++)
                {
                    btn_amarelo.PerformClick();
                    lbl_Tempo.Text = i.ToString();
                    //MessageBox.Show(i.ToString());
                }
                sw.Stop();
                lbl_Tempo.Text = sw.ElapsedMilliseconds.ToString();
                MessageBox.Show(i.ToString()); //Observar, tempo
                                               //Inc 1 em t (Transição - Repetição)
                t++;
            }
        }

        private async void btn_Sequencial_Click_1(object sender, EventArgs e)
        {
            try
            {
                while (Stop == false)
                {
                    btn_vermelho.PerformClick();
                    await Task.Delay(10000, ts_Sequencia.Token); // 10 

                    btn_verde.PerformClick();
                    await Task.Delay(10000, ts_Sequencia.Token); // 10 

                    btn_amarelo.PerformClick();
                    await Task.Delay(3000, ts_Sequencia.Token); // 03 
                }
            }
            catch (TaskCanceledException ex)
            {
                MessageBox.Show("Sequencial Cancelada!", "Atenção");
                //MessageBox.Show("Sequencial: "+ex.Message);
            }
            catch (Exception erroX)
            {
                MessageBox.Show("Erro:" + erroX.Message);
            }
        }
    }
}



    

