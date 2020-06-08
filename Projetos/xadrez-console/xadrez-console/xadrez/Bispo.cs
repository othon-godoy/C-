﻿using System;
using System.Collections.Generic;
using System.Text;
using xadrez_console.tabuleiro;

namespace xadrez_console.xadrez
{
    class Bispo : Peca
    {
        public Bispo(Cor cor, Tabuleiro tab) : base(cor, tab) { }

        public override string ToString()
        {
            return "B";
        }
        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            // no
            pos.definirValores(posicao.linha - 1, posicao.coluna - 1);

            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }

                pos.definirValores(pos.linha - 1, pos.coluna - 1);
            }

            // ne
            pos.definirValores(posicao.linha - 1, posicao.coluna + 1);

            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }

                pos.definirValores(pos.linha - 1, pos.coluna + 1);
            }

            // se
            pos.definirValores(posicao.linha + 1, posicao.coluna + 1);

            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }

                pos.definirValores(pos.linha + 1, pos.coluna + 1);
            }

            // so
            pos.definirValores(posicao.linha + 1, posicao.coluna - 1);

            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }

                pos.definirValores(pos.linha + 1, pos.coluna - 1);
            }

            return mat;
        }
    }
}