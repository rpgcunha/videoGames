using projeto_avaliacao_cs.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_avaliacao_cs
{
    public partial class frmGalo : Form
    {
        string level = string.Empty;
        int empate;
        string jogador;
        string vitoria=string.Empty;
        string[] posBack = new string[9];
        PictureBox[] picPos = new PictureBox[9];



        public frmGalo()
        {
            InitializeComponent();
            //inicia o array com vazio
            for (int i = 0; i < 9; i++)
            {
                posBack[i] = "vazio";
            }

            //cria as imagens para os simbolos
            for (int i = 0; i < picPos.Length; i++)
            {
                picPos[i] = new PictureBox();
                picPos[i].Size = new Size(70, 70);
                picPos[i].SizeMode = PictureBoxSizeMode.Zoom;
                picPos[i].BringToFront();
                picPos[i].Visible = false;
                this.Controls.Add(picPos[i]);
            }
            //posiciona as imagens
            picPos[0].Location = new Point(149, 172);
            picPos[1].Location = new Point(234, 172);
            picPos[2].Location = new Point(317, 172);
            picPos[3].Location = new Point(149, 263);
            picPos[4].Location = new Point(234, 263);
            picPos[5].Location = new Point(317, 263);
            picPos[6].Location = new Point(149, 355);
            picPos[7].Location = new Point(234, 355);
            picPos[8].Location = new Point(317, 355);

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //fecha este form e volta para o form de escolha de jogo
            this.Close();
            frmPricipal frmPricipal= new frmPricipal();
            frmPricipal.Show();
        }

        public void jogada(int pos, string dificuldade)
        {
            bool livre = false;
            //verifica de é a vez do user
            if (jogador=="user")
            {
                //atribui o x ao quadrado que o user escolheu
                posBack[pos] = "x";
                //escolhe a imagem e torna a visivel
                picPos[pos].Visible = true;
                picPos[pos].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\x.png");
                //conta o numero de jogadas
                empate=empate+1;
                //verifica se ja nao existe mais jogadas possiveis
                if (empate==9)
                {
                    //executa a funcao fimdejogo para ver se algum jogador venceu
                    fimDoJogo();
                    //verifica se o user foi vencedor
                    if (vitoria == "user")
                    {
                        System.Windows.Forms.MessageBox.Show("Parabens! Você Venceu!!");
                        return;
                    }
                    //verifica se o cpu foi vencedor
                    if (vitoria == "cpu")
                    {
                        System.Windows.Forms.MessageBox.Show("Que pena, você perdeu!!");
                        return;
                    }
                    //se nao houve vencedores apresenta mensagem de empate
                    System.Windows.Forms.MessageBox.Show("Empataram!!");
                    return;
                }
                else
                {
                    //se houver mais jogadas passa a vez ao cpu
                    jogador = "cpu";
                }
            }
            //executa a funcao fimdejogo para ver se algum jogador venceu
            fimDoJogo();
            //verifica se o user foi vencedor
            if (vitoria == "user")
            {
                System.Windows.Forms.MessageBox.Show("Parabens! Você Venceu!!");
                return;
            }
            //verifica se o cpu foi vencedor
            if (vitoria == "cpu")
            {
                System.Windows.Forms.MessageBox.Show("Que pena, você perdeu!!");
                return;
            }
            //verifica se é a vez do cpu
            if (jogador == "cpu")
            {
                //verifica qual a dificuldade do jogo
                if (dificuldade == "facil")
                {
                    Random random = new Random();
                    livre = false;
                    TentarVencer();
                    fimDoJogo();
                    //verifica se o user foi vencedor
                    if (vitoria == "user")
                    {
                        System.Windows.Forms.MessageBox.Show("Parabens! Você Venceu!!");
                        return;
                    }
                    //verifica se o cpu foi vencedor
                    if (vitoria == "cpu")
                    {
                        System.Windows.Forms.MessageBox.Show("Que pena, você perdeu!!");
                        return;
                    }
                    //sorteia uma posição até encontrar uma posiçao livre
                    while (livre == false)
                    {
                        pos = random.Next(0, 8);
                        if (posBack[pos] =="vazio")
                        {
                            livre = true;
                        }
                    }
                    //coloca o simbolo no array
                    posBack[pos] = "o";
                    //escolhe a imagem e torna a visivel
                    picPos[pos].Visible = true;
                    picPos[pos].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                    //passa a vez ao user
                    jogador = "user";
                    //conta o numero de jogadas
                    empate = empate + 1;
                }
                if (dificuldade== "normal")
                {
                    Random random = new Random();
                    livre = false;
                    TentarVencer();
                    fimDoJogo();
                    //verifica se o user foi vencedor
                    if (vitoria == "user")
                    {
                        System.Windows.Forms.MessageBox.Show("Parabens! Você Venceu!!");
                        return;
                    }
                    //verifica se o cpu foi vencedor
                    if (vitoria == "cpu")
                    {
                        System.Windows.Forms.MessageBox.Show("Que pena, você perdeu!!");
                        return;
                    }
                    if (posBack[0] == "x" && posBack[1]== "x" && posBack[2]=="vazio")
                    {
                        posBack[2] = "o";
                        picPos[2].Visible = true;
                        picPos[2].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                        jogador = "user";
                        empate = empate + 1;
                    }
                    else
                    {
                        if (posBack[1] == "x" && posBack[2] == "x" && posBack[0] == "vazio")
                        {
                            posBack[0] = "o";
                            picPos[0].Visible = true;
                            picPos[0].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                            jogador = "user";
                            empate = empate + 1;
                        }
                        else
                        {
                            if (posBack[0] == "x" && posBack[2] == "x" && posBack[1] == "vazio")
                            {
                                posBack[1] = "o";
                                picPos[1].Visible = true;
                                picPos[1].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                jogador = "user";
                                empate = empate + 1;
                            }
                            else
                            {
                                if (posBack[0] == "x" && posBack[3] == "x" && posBack[6] == "vazio")
                                {
                                    posBack[6] = "o";
                                    picPos[6].Visible = true;
                                    picPos[6].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                    jogador = "user";
                                    empate = empate + 1;
                                }
                                else
                                {
                                    if (posBack[3] == "x" && posBack[6] == "x" && posBack[0] == "vazio")
                                    {
                                        posBack[0] = "o";
                                        picPos[0].Visible = true;
                                        picPos[0].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                        jogador = "user";
                                        empate = empate + 1;
                                    }
                                    else
                                    {
                                        if (posBack[0] == "x" && posBack[6] == "x" && posBack[3] == "vazio" )
                                        {
                                            posBack[3] = "o";
                                            picPos[3].Visible = true;
                                            picPos[3].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                            jogador = "user";
                                            empate = empate + 1;
                                        }
                                        else
                                        {
                                            if (posBack[6] == "x" && posBack[7] == "x" && posBack[8] == "vazio" )
                                            {
                                                posBack[8] = "o";
                                                picPos[8].Visible = true;
                                                picPos[8].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                jogador = "user";
                                                empate = empate + 1;
                                            }
                                            else
                                            {
                                                if (posBack[7] == "x" && posBack[8] == "x" && posBack[6] == "vazio" )
                                                {
                                                    posBack[6] = "o";
                                                    picPos[6].Visible = true;
                                                    picPos[6].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                    jogador = "user";
                                                    empate = empate + 1;
                                                }
                                                else
                                                {
                                                    if (posBack[6] == "x" && posBack[8] == "x" && posBack[7] == "vazio")
                                                    {
                                                        posBack[7] = "o";
                                                        picPos[7].Visible = true;
                                                        picPos[7].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                        jogador = "user";
                                                        empate = empate + 1;
                                                    }
                                                    else
                                                    {
                                                        if (posBack[2] == "x" && posBack[5] == "x" && posBack[8] == "vazio")
                                                        {
                                                            posBack[8] = "o";
                                                            picPos[8].Visible = true;
                                                            picPos[8].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                            jogador = "user";
                                                            empate = empate + 1;
                                                        }
                                                        else
                                                        {
                                                            if (posBack[5] == "x" && posBack[8] == "x" && posBack[2] == "vazio" )
                                                            {
                                                                posBack[2] = "o";
                                                                picPos[2].Visible = true;
                                                                picPos[2].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                jogador = "user";
                                                                empate = empate + 1;
                                                            }
                                                            else
                                                            {
                                                                if (posBack[2] == "x" && posBack[8] == "x" && posBack[5] == "vazio")
                                                                {
                                                                    posBack[5] = "o";
                                                                    picPos[5].Visible = true;
                                                                    picPos[5].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                    jogador = "user";
                                                                    empate = empate + 1;
                                                                }
                                                                else
                                                                {
                                                                    while (livre == false)
                                                                    {
                                                                        pos = random.Next(0, 8);
                                                                        if (posBack[pos] == "vazio")
                                                                        {
                                                                            livre = true;
                                                                        }
                                                                    }
                                                                    //coloca o simbolo no array
                                                                    posBack[pos] = "o";
                                                                    //escolhe a imagem e torna a visivel
                                                                    picPos[pos].Visible = true;
                                                                    picPos[pos].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                    //passa a vez ao user
                                                                    jogador = "user";
                                                                    //conta o numero de jogadas
                                                                    empate = empate + 1;
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (dificuldade=="dificil")
                {
                    Random random = new Random();
                    livre = false;
                    TentarVencer();
                    fimDoJogo();
                    //verifica se o user foi vencedor
                    if (vitoria == "user")
                    {
                        System.Windows.Forms.MessageBox.Show("Parabens! Você Venceu!!");
                        return;
                    }
                    //verifica se o cpu foi vencedor
                    if (vitoria == "cpu")
                    {
                        System.Windows.Forms.MessageBox.Show("Que pena, você perdeu!!");
                        return;
                    }
                    if (posBack[0] == "x" && posBack[1] == "x" && posBack[2] == "vazio")
                    {
                        posBack[2] = "o";
                        picPos[2].Visible = true;
                        picPos[2].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                        jogador = "user";
                        empate = empate + 1;
                    }
                    else
                    {
                        if (posBack[1] == "x" && posBack[2] == "x" && posBack[0] == "vazio")
                        {
                            posBack[0] = "o";
                            picPos[0].Visible = true;
                            picPos[0].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                            jogador = "user";
                            empate = empate + 1;
                        }
                        else
                        {
                            if (posBack[0] == "x" && posBack[2] == "x" && posBack[1] == "vazio")
                            {
                                posBack[1] = "o";
                                picPos[1].Visible = true;
                                picPos[1].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                jogador = "user";
                                empate = empate + 1;
                            }
                            else
                            {
                                if (posBack[0] == "x" && posBack[3] == "x" && posBack[6] == "vazio")
                                {
                                    posBack[6] = "o";
                                    picPos[6].Visible = true;
                                    picPos[6].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                    jogador = "user";
                                    empate = empate + 1;
                                }
                                else
                                {
                                    if (posBack[3] == "x" && posBack[6] == "x" && posBack[0] == "vazio")
                                    {
                                        posBack[0] = "o";
                                        picPos[0].Visible = true;
                                        picPos[0].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                        jogador = "user";
                                        empate = empate + 1;
                                    }
                                    else
                                    {
                                        if (posBack[0] == "x" && posBack[6] == "x" && posBack[3] == "vazio")
                                        {
                                            posBack[3] = "o";
                                            picPos[3].Visible = true;
                                            picPos[3].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                            jogador = "user";
                                            empate = empate + 1;
                                        }
                                        else
                                        {
                                            if (posBack[6] == "x" && posBack[7] == "x" && posBack[8] == "vazio")
                                            {
                                                posBack[8] = "o";
                                                picPos[8].Visible = true;
                                                picPos[8].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                jogador = "user";
                                                empate = empate + 1;
                                            }
                                            else
                                            {
                                                if (posBack[7] == "x" && posBack[8] == "x" && posBack[6] == "vazio")
                                                {
                                                    posBack[6] = "o";
                                                    picPos[6].Visible = true;
                                                    picPos[6].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                    jogador = "user";
                                                    empate = empate + 1;
                                                }
                                                else
                                                {
                                                    if (posBack[6] == "x" && posBack[8] == "x" && posBack[7] == "vazio")
                                                    {
                                                        posBack[7] = "o";
                                                        picPos[7].Visible = true;
                                                        picPos[7].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                        jogador = "user";
                                                        empate = empate + 1;
                                                    }
                                                    else
                                                    {
                                                        if (posBack[2] == "x" && posBack[5] == "x" && posBack[8] == "vazio")
                                                        {
                                                            posBack[8] = "o";
                                                            picPos[8].Visible = true;
                                                            picPos[8].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                            jogador = "user";
                                                            empate = empate + 1;
                                                        }
                                                        else
                                                        {
                                                            if (posBack[5] == "x" && posBack[8] == "x" && posBack[2] == "vazio")
                                                            {
                                                                posBack[2] = "o";
                                                                picPos[2].Visible = true;
                                                                picPos[2].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                jogador = "user";
                                                                empate = empate + 1;
                                                            }
                                                            else
                                                            {
                                                                if (posBack[2] == "x" && posBack[8] == "x" && posBack[5] == "vazio")
                                                                {
                                                                    posBack[5] = "o";
                                                                    picPos[5].Visible = true;
                                                                    picPos[5].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                    jogador = "user";
                                                                    empate = empate + 1;
                                                                }
                                                                else
                                                                {
                                                                    if (posBack[1] == "x" && posBack[4] == "x" && posBack[7] == "vazio")
                                                                    {
                                                                        posBack[7] = "o";
                                                                        picPos[7].Visible = true;
                                                                        picPos[7].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                        jogador = "user";
                                                                        empate = empate + 1;
                                                                    }
                                                                    else
                                                                    {
                                                                        if (posBack[4] == "x" && posBack[7] == "x" && posBack[1] == "vazio")
                                                                        {
                                                                            posBack[1] = "o";
                                                                            picPos[1].Visible = true;
                                                                            picPos[1].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                            jogador = "user";
                                                                            empate = empate + 1;
                                                                        }
                                                                        else
                                                                        {
                                                                            if (posBack[1] == "x" && posBack[7] == "x" && posBack[4] == "vazio")
                                                                            {
                                                                                posBack[4] = "o";
                                                                                picPos[4].Visible = true;
                                                                                picPos[4].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                                jogador = "user";
                                                                                empate = empate + 1;
                                                                            }
                                                                            else
                                                                            {
                                                                                if (posBack[3] == "x" && posBack[4] == "x" && posBack[5] == "vazio")
                                                                                {
                                                                                    posBack[5] = "o";
                                                                                    picPos[5].Visible = true;
                                                                                    picPos[5].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                                    jogador = "user";
                                                                                    empate = empate + 1;
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (posBack[3] == "x" && posBack[5] == "x" && posBack[4] == "vazio")
                                                                                    {
                                                                                        posBack[4] = "o";
                                                                                        picPos[4].Visible = true;
                                                                                        picPos[4].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                                        jogador = "user";
                                                                                        empate = empate + 1;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        if (posBack[4] == "x" && posBack[5] == "x" && posBack[3] == "vazio")
                                                                                        {
                                                                                            posBack[3] = "o";
                                                                                            picPos[3].Visible = true;
                                                                                            picPos[3].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                                            jogador = "user";
                                                                                            empate = empate + 1;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            if (posBack[0] == "x" && posBack[4] == "x" && posBack[8] == "vazio")
                                                                                            {
                                                                                                posBack[8] = "o";
                                                                                                picPos[8].Visible = true;
                                                                                                picPos[8].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                                                jogador = "user";
                                                                                                empate = empate + 1;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                if (posBack[4] == "x" && posBack[8] == "x" && posBack[0] == "vazio")
                                                                                                {
                                                                                                    posBack[0] = "o";
                                                                                                    picPos[0].Visible = true;
                                                                                                    picPos[0].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                                                    jogador = "user";
                                                                                                    empate = empate + 1;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    if (posBack[0] == "x" && posBack[8] == "x" && posBack[4] == "vazio")
                                                                                                    {
                                                                                                        posBack[4] = "o";
                                                                                                        picPos[4].Visible = true;
                                                                                                        picPos[4].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                                                        jogador = "user";
                                                                                                        empate = empate + 1;
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        if (posBack[2] == "x" && posBack[4] == "x" && posBack[6] == "vazio")
                                                                                                        {
                                                                                                            posBack[6] = "o";
                                                                                                            picPos[6].Visible = true;
                                                                                                            picPos[6].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                                                            jogador = "user";
                                                                                                            empate = empate + 1;
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            if (posBack[4] == "x" && posBack[6] == "x" && posBack[2] == "vazio")
                                                                                                            {
                                                                                                                posBack[2] = "o";
                                                                                                                picPos[2].Visible = true;
                                                                                                                picPos[2].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                                                                jogador = "user";
                                                                                                                empate = empate + 1;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                if (posBack[2] == "x" && posBack[6] == "x" && posBack[4] == "vazio")
                                                                                                                {
                                                                                                                    posBack[4] = "o";
                                                                                                                    picPos[4].Visible = true;
                                                                                                                    picPos[4].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                                                                    jogador = "user";
                                                                                                                    empate = empate + 1;
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    while (livre == false)
                                                                                                                    {
                                                                                                                        pos = random.Next(0, 8);
                                                                                                                        if (posBack[pos] == "vazio")
                                                                                                                        {
                                                                                                                            livre = true;
                                                                                                                        }
                                                                                                                    }
                                                                                                                    //coloca o simbolo no array
                                                                                                                    posBack[pos] = "o";
                                                                                                                    //escolhe a imagem e torna a visivel
                                                                                                                    picPos[pos].Visible = true;
                                                                                                                    picPos[pos].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                                                                    //passa a vez ao user
                                                                                                                    jogador = "user";
                                                                                                                    //conta o numero de jogadas
                                                                                                                    empate = empate + 1;
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //executa a funcao fimdejogo para ver se algum jogador venceu
            fimDoJogo();
            //verifica se o user foi vencedor
            if (vitoria == "user")
            {
                System.Windows.Forms.MessageBox.Show("Parabens! Você Venceu!!");
                return;
            }
            //verifica se o cpu foi vencedor
            if (vitoria == "cpu")
            {
                System.Windows.Forms.MessageBox.Show("Que pena, você perdeu!!");
                return;
            }
        }

        private void TentarVencer()
        {
            if (posBack[0] == "o" && posBack[1] == "o" && posBack[2] == "vazio")
            {
                posBack[2] = "o";
                picPos[2].Visible = true;
                picPos[2].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                jogador = "user";
                empate = empate + 1;
            }
            else
            {
                if (posBack[1] == "o" && posBack[2] == "o" && posBack[0] == "vazio")
                {
                    posBack[0] = "o";
                    picPos[0].Visible = true;
                    picPos[0].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                    jogador = "user";
                    empate = empate + 1;
                }
                else
                {
                    if (posBack[0] == "o" && posBack[2] == "o" && posBack[1] == "vazio")
                    {
                        posBack[1] = "o";
                        picPos[1].Visible = true;
                        picPos[1].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                        jogador = "user";
                        empate = empate + 1;
                    }
                    else
                    {
                        if (posBack[0] == "o" && posBack[3] == "o" && posBack[6] == "vazio")
                        {
                            posBack[6] = "o";
                            picPos[6].Visible = true;
                            picPos[6].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                            jogador = "user";
                            empate = empate + 1;
                        }
                        else
                        {
                            if (posBack[3] == "o" && posBack[6] == "o" && posBack[0] == "vazio")
                            {
                                posBack[0] = "o";
                                picPos[0].Visible = true;
                                picPos[0].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                jogador = "user";
                                empate = empate + 1;
                            }
                            else
                            {
                                if (posBack[0] == "o" && posBack[6] == "o" && posBack[3] == "vazio")
                                {
                                    posBack[3] = "o";
                                    picPos[3].Visible = true;
                                    picPos[3].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                    jogador = "user";
                                    empate = empate + 1;
                                }
                                else
                                {
                                    if (posBack[6] == "o" && posBack[7] == "o" && posBack[8] == "vazio")
                                    {
                                        posBack[8] = "o";
                                        picPos[8].Visible = true;
                                        picPos[8].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                        jogador = "user";
                                        empate = empate + 1;
                                    }
                                    else
                                    {
                                        if (posBack[7] == "o" && posBack[8] == "o" && posBack[6] == "vazio")
                                        {
                                            posBack[6] = "o";
                                            picPos[6].Visible = true;
                                            picPos[6].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                            jogador = "user";
                                            empate = empate + 1;
                                        }
                                        else
                                        {
                                            if (posBack[6] == "o" && posBack[8] == "o" && posBack[7] == "vazio")
                                            {
                                                posBack[7] = "o";
                                                picPos[7].Visible = true;
                                                picPos[7].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                jogador = "user";
                                                empate = empate + 1;
                                            }
                                            else
                                            {
                                                if (posBack[2] == "o" && posBack[5] == "o" && posBack[8] == "vazio")
                                                {
                                                    posBack[8] = "o";
                                                    picPos[8].Visible = true;
                                                    picPos[8].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                    jogador = "user";
                                                    empate = empate + 1;
                                                }
                                                else
                                                {
                                                    if (posBack[5] == "o" && posBack[8] == "o" && posBack[2] == "vazio")
                                                    {
                                                        posBack[2] = "o";
                                                        picPos[2].Visible = true;
                                                        picPos[2].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                        jogador = "user";
                                                        empate = empate + 1;
                                                    }
                                                    else
                                                    {
                                                        if (posBack[2] == "o" && posBack[8] == "o" && posBack[5] == "vazio")
                                                        {
                                                            posBack[5] = "o";
                                                            picPos[5].Visible = true;
                                                            picPos[5].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                            jogador = "user";
                                                            empate = empate + 1;
                                                        }
                                                        else
                                                        {
                                                            if (posBack[1] == "o" && posBack[4] == "o" && posBack[7] == "vazio")
                                                            {
                                                                posBack[7] = "o";
                                                                picPos[7].Visible = true;
                                                                picPos[7].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                jogador = "user";
                                                                empate = empate + 1;
                                                            }
                                                            else
                                                            {
                                                                if (posBack[4] == "o" && posBack[7] == "o" && posBack[1] == "vazio")
                                                                {
                                                                    posBack[1] = "o";
                                                                    picPos[1].Visible = true;
                                                                    picPos[1].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                    jogador = "user";
                                                                    empate = empate + 1;
                                                                }
                                                                else
                                                                {
                                                                    if (posBack[1] == "o" && posBack[7] == "o" && posBack[4] == "vazio")
                                                                    {
                                                                        posBack[4] = "o";
                                                                        picPos[4].Visible = true;
                                                                        picPos[4].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                        jogador = "user";
                                                                        empate = empate + 1;
                                                                    }
                                                                    else
                                                                    {
                                                                        if (posBack[3] == "o" && posBack[4] == "o" && posBack[5] == "vazio")
                                                                        {
                                                                            posBack[5] = "o";
                                                                            picPos[5].Visible = true;
                                                                            picPos[5].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                            jogador = "user";
                                                                            empate = empate + 1;
                                                                        }
                                                                        else
                                                                        {
                                                                            if (posBack[3] == "o" && posBack[5] == "o" && posBack[4] == "vazio")
                                                                            {
                                                                                posBack[4] = "o";
                                                                                picPos[4].Visible = true;
                                                                                picPos[4].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                                jogador = "user";
                                                                                empate = empate + 1;
                                                                            }
                                                                            else
                                                                            {
                                                                                if (posBack[4] == "o" && posBack[5] == "o" && posBack[3] == "vazio")
                                                                                {
                                                                                    posBack[3] = "o";
                                                                                    picPos[3].Visible = true;
                                                                                    picPos[3].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                                    jogador = "user";
                                                                                    empate = empate + 1;
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (posBack[0] == "o" && posBack[4] == "o" && posBack[8] == "vazio")
                                                                                    {
                                                                                        posBack[8] = "o";
                                                                                        picPos[8].Visible = true;
                                                                                        picPos[8].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                                        jogador = "user";
                                                                                        empate = empate + 1;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        if (posBack[4] == "o" && posBack[8] == "o" && posBack[0] == "vazio")
                                                                                        {
                                                                                            posBack[0] = "o";
                                                                                            picPos[0].Visible = true;
                                                                                            picPos[0].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                                            jogador = "user";
                                                                                            empate = empate + 1;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            if (posBack[0] == "o" && posBack[8] == "o" && posBack[4] == "vazio")
                                                                                            {
                                                                                                posBack[4] = "o";
                                                                                                picPos[4].Visible = true;
                                                                                                picPos[4].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                                                jogador = "user";
                                                                                                empate = empate + 1;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                if (posBack[2] == "o" && posBack[4] == "o" && posBack[6] == "vazio")
                                                                                                {
                                                                                                    posBack[6] = "o";
                                                                                                    picPos[6].Visible = true;
                                                                                                    picPos[6].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                                                    jogador = "user";
                                                                                                    empate = empate + 1;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    if (posBack[4] == "o" && posBack[6] == "o" && posBack[2] == "vazio")
                                                                                                    {
                                                                                                        posBack[2] = "o";
                                                                                                        picPos[2].Visible = true;
                                                                                                        picPos[2].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                                                        jogador = "user";
                                                                                                        empate = empate + 1;
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        if (posBack[2] == "o" && posBack[6] == "o" && posBack[4] == "vazio")
                                                                                                        {
                                                                                                            posBack[4] = "o";
                                                                                                            picPos[4].Visible = true;
                                                                                                            picPos[4].Image = Image.FromFile("C:\\Users\\rpcun\\source\\repos\\projeto_avaliacao_cs\\Resources\\o.jpg");
                                                                                                            jogador = "user";
                                                                                                            empate = empate + 1;
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void fimDoJogo()
        {
            //testa as combinações para ver se ha alguma sequencia de 3 e qual o simbulo que fez a sequncia
            if (posBack[0] == posBack[1] && posBack[0] == posBack[2])
            {
                switch (posBack[0])
                {
                    case "x":
                        vitoria = "user";
                        return;
                    case "o":
                        vitoria = "cpu";
                        return;
                    default:
                        break;
                }
            }
            if (posBack[3] == posBack[4] && posBack[3] == posBack[5])
            {
                switch (posBack[3])
                {
                    case "x":
                        vitoria = "user";
                        return;
                    case "o":
                        vitoria = "cpu";
                        return;
                    default:
                        break;
                }
            }
            if (posBack[6] == posBack[7] && posBack[6] == posBack[8])
            {
                switch (posBack[6])
                {
                    case "x":
                        vitoria = "user";
                        return;
                    case "o":
                        vitoria = "cpu";
                        return;
                    default:
                        break;
                }
            }
            if (posBack[0] == posBack[3] && posBack[0] == posBack[6])
            {
                switch (posBack[0])
                {
                    case "x":
                        vitoria = "user";
                        return;
                    case "o":
                        vitoria = "cpu";
                        return;
                    default:
                        break;
                }
            }
            if (posBack[1] == posBack[4] && posBack[1] == posBack[7])
            {
                switch (posBack[1])
                {
                    case "x":
                        vitoria = "user";
                        return;
                    case "o":
                        vitoria = "cpu";
                        return;
                    default:
                        break;
                }
            }
            if (posBack[2] == posBack[5] && posBack[2] == posBack[8])
            {
                switch (posBack[2])
                {
                    case "x":
                        vitoria = "user";
                        return;
                    case "o":
                        vitoria = "cpu";
                        return;
                    default:
                        break;
                }
            }
            if (posBack[0] == posBack[4] && posBack[0] == posBack[8])
            {
                switch (posBack[0])
                {
                    case "x":
                        vitoria = "user";
                        return;
                    case "o":
                        vitoria = "cpu";
                        return;
                    default:
                        break;
                }
            }
            if (posBack[2] == posBack[4] && posBack[2] == posBack[6])
            {
                switch (posBack[2])
                {
                    case "x":
                        vitoria = "user";
                        return;
                    case "o":
                        vitoria = "cpu";
                        return;
                    default:
                        break;
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //inicia as var
            empate = 0;
            jogador = "user";
            //verifica qual a dificuldade escolhida
            if (rbtFacil.Checked)
            {
                level = "facil";
            }
            if (rbtNormal.Checked)
            {
                level = "normal";
            }
            if (rbtDificil.Checked)
            {
                level = "dificil";
            }
            if (level==string.Empty)
            {
                System.Windows.Forms.MessageBox.Show("Escolha uma dificuldade!");
            }               


        }


        private void frmGalo_MouseClick(object sender, MouseEventArgs e)
        {
            //define as vars para a posiçao de click do rato
            int clickX = e.X;
            int clickY= e.Y;
            int quadrado=-1;
            try
            {
                //verifica se foi escolhido algum nivel
                if (level == string.Empty)
                {
                    return;
                }
                else
                {
                    //verifica em que posiçao foi dado o clique e atribui à variavel quadrado a sua posiçao
                    if (clickY > 157 && clickY < 250)
                    {
                        if (clickX > 143 && clickX < 226)
                        {
                            quadrado = 0;
                        }
                        if (clickX > 226 && clickX < 310)
                        {
                            quadrado = 1;
                        }
                        if (clickX > 310 && clickX < 394)
                        {
                            quadrado = 2;
                        }
                    }
                    if (clickY > 250 && clickY < 344)
                    {
                        if (clickX > 143 && clickX < 226)
                        {
                            quadrado = 3;
                        }
                        if (clickX > 226 && clickX < 310)
                        {
                            quadrado = 4;
                        }
                        if (clickX > 310 && clickX < 394)
                        {
                            quadrado = 5;
                        }
                    }
                    if (clickY > 344 && clickY < 436)
                    {
                        if (clickX > 143 && clickX < 226)
                        {
                            quadrado = 6;
                        }
                        if (clickX > 226 && clickX < 310)
                        {
                            quadrado = 7;
                        }
                        if (clickX > 310 && clickX < 394)
                        {
                            quadrado = 8;
                        }
                    }
                    //executa a funçao jogada com o quadrado escolhido e a dificuldade
                    jogada(quadrado, level);
                }
            }
            catch (Exception)
            {
                return;
            }
            
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            //reinicia as vars
            level = string.Empty;
            vitoria = string.Empty;
            //esconde os simbolos
            for (int i = 0; i < 9; i++)
            {
                picPos[i].Visible = false;
            }
            //limpa o array
            for (int i = 0; i < 9; i++)
            {
                posBack[i] = "vazio";
            }
            //inicia as var
            empate = 0;
            jogador = "user";
            //verifica a dificuldade
            if (rbtFacil.Checked)
            {
                level = "facil";
            }
            if (rbtNormal.Checked)
            {
                level = "normal";
            }
            if (rbtDificil.Checked)
            {
                level = "dificil";
            }
        }
    }
}
