﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_avaliacao_cs
{
    public partial class frmSnake : Form
    {
        //var globais
        const int TAMANHO = 30;
        string direcao;
        PictureBox[] snake = new PictureBox[TAMANHO];
        PictureBox bonus = new PictureBox();

        public frmSnake()
        {
            InitializeComponent();
            this.KeyPreview = true;
            //bonus
            bonus = new PictureBox();
            bonus.Size = new Size(10, 10);
            bonus.Visible = true;
            bonus.BorderStyle = BorderStyle.FixedSingle;
            bonus.BackColor = Color.BlueViolet;
            this.Controls.Add(bonus);
            //criar a snake e colocar fora do form
            for (int i = 0; i < TAMANHO; i++)
            {
                snake[i] = new PictureBox();
                this.Controls.Add(snake[i]);
            }
            resetSnake();
        }

        void resetSnake()
        {
            int posY = 50;
            for (int i = 0; i < TAMANHO; i++)
            {
                snake[i].Size = new Size(10, 10);
                snake[i].Visible = true;
                snake[i].Location = new Point(900, posY);
                snake[i].BorderStyle = BorderStyle.FixedSingle;
                if (i == 0)
                    snake[i].BackColor = Color.Red;
                else
                    snake[i].BackColor = Color.DarkGreen;
                snake[i].BringToFront();
                posY = posY + 10;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            resetSnake();
            //define a posição inicial e direçao
            int posX = 100;
            int comprimento = 5;
            for (int i = 0; i < 5; i++)
            {
                snake[i].Location = new Point(posX, 100);
                posX= posX - 10;
            }
            direcao = "direita";
            PosicionarBonus(comprimento);
            Movimentar(comprimento);
        }



        async void Movimentar(int comprimento)
        {
            int velocidade = 100;
            while (Perder(comprimento) == 0)
            {
                switch (direcao)
                {
                    case "direita":
                        await Task.Delay(velocidade);
                        for (int i = comprimento - 1; i > 0; i--)
                        {
                            snake[i].Location = new Point(snake[i - 1].Location.X, snake[i-1].Location.Y);
                        }
                        snake[0].Location = new Point(snake[0].Location.X + 10, snake[0].Location.Y);
                        break;
                    case "esquerda":
                        await Task.Delay(velocidade);
                        for (int i = comprimento - 1; i > 0; i--)
                        {
                            snake[i].Location = new Point(snake[i - 1].Location.X, snake[i-1].Location.Y);
                        }
                        snake[0].Location = new Point(snake[0].Location.X - 10, snake[0].Location.Y);
                        break;
                    case "cima":
                        await Task.Delay(velocidade);
                        for (int i = comprimento - 1; i > 0; i--)
                        {
                            snake[i].Location = new Point(snake[i - 1].Location.X, snake[i - 1].Location.Y);
                        }
                        snake[0].Location = new Point(snake[0].Location.X, snake[0].Location.Y - 10);
                        break;
                    case "baixo":
                        await Task.Delay(velocidade);
                        for (int i = comprimento - 1; i > 0; i--)
                        {
                            snake[i].Location = new Point(snake[i - 1].Location.X, snake[i - 1].Location.Y);
                        }
                        snake[0].Location = new Point(snake[0].Location.X, snake[0].Location.Y + 10);
                        break;
                    default:
                        break;
                }
                comprimento = Comer(comprimento);
            }
            MessageBox.Show("Perdeu!");
        }

        int Comer(int comprimento)
        {
            if (snake[0].Left == bonus.Left && snake[0].Top == bonus.Top)
            {
                comprimento++;
                PosicionarBonus(comprimento);
                return comprimento;
            }
            return comprimento;
        }

        void PosicionarBonus(int comprimento)
        {
            //criar objeto
            int posX;
            int posY;
            bool ocupado = true;

            //posicionar aleatoriamente
            Random rnd = new Random();
            do
            {
                //seleciona 2 valores multiplos de 10
                posX = rnd.Next(1, 55);
                posY = rnd.Next(5, 43);
                posX = posX * 10;
                posY = posY * 10;
                //ve se as pos sao iguais à posiçao da snake
                for (int i = 0; i < comprimento; i++)
                {
                    if (posX == snake[i].Left && posY == snake[i].Top)
                    {
                        ocupado = true;
                    }
                    else
                    {
                        ocupado = false;
                    }
                }
            } while (ocupado);
            bonus.Location = new Point(posX, posY);
            bonus.BringToFront();
        }

        int Perder(int comprimento)
        {
            if (snake[0].Left < picTabuleiro.Left)
            {
                return 1;
            }
            if (snake[0].Right > picTabuleiro.Right)
            {
                return 1;
            }
            if (snake[0].Top < picTabuleiro.Top)
            {
                return 1;
            }
            if (snake[0].Bottom > picTabuleiro.Bottom)
            {
                return 1;
            }
            for (int i = 1; i < comprimento; i++)
            {
                if (snake[0].Top == snake[i].Top && snake[0].Left == snake[i].Left)
                {
                    return 1;
                }
            }
            return 0;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //fecha este form e volta para o form de escolha de jogo
            this.Close();
            frmPricipal frmPricipal = new frmPricipal();
            frmPricipal.Show();
        }

        private void frmSnake_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                if (direcao != "direita")
                {
                    direcao = "esquerda";
                }
            }
            if (e.KeyCode == Keys.D)
            {
                if (direcao != "esquerda")
                {
                    direcao = "direita";
                }
            }
            if (e.KeyCode == Keys.W)
            {
                if (direcao != "baixo")
                {
                    direcao = "cima";
                }
            }
            if (e.KeyCode == Keys.S)
            {
                if (direcao != "cima")
                {
                    direcao = "baixo";
                }
            }
        }
    }
}
