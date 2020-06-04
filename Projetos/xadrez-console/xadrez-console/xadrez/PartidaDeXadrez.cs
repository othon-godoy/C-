using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using xadrez_console.tabuleiro;

namespace xadrez_console.xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        public int turno { get; private set; }
        public Cor jogadorAtual { get; private set; }
        public bool terminada { get; private set; }

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQtdMovimentos();

            Peca pecaCapturada = tab.retirarPeca(destino);

            tab.colocarPeca(p, destino);
        }

        public void realizaJogada(Posicao origem, Posicao destino)
        {
            executaMovimento(origem, destino);
            turno++;

            mudaJogador();
        }

        public void validarPosicaoDeOrigem(Posicao pos)
        {
            if (tab.peca(pos) == null)
            {
                throw new TabuleiroException("Não existe peça na posição de origem escolhida");
            }

            if (jogadorAtual != tab.peca(pos).cor)
            {
                throw new TabuleiroException("A peça de tabuleiro escolhida não é sua");
            }

            if (!tab.peca(pos).existeMovimentosPossiveis())
            {
                throw new TabuleiroException("Não há movimentos possíveis para a peça de origem escolhida");
            }
        }

        private void mudaJogador()
        {
            if (jogadorAtual == Cor.Branca)
            {
                jogadorAtual = Cor.Preta;
            }
            else
            {
                jogadorAtual = Cor.Branca;
            }
        }

        private void colocarPecas()
        {
            tab.colocarPeca(
                new Torre(Cor.Branca, tab), 
                new PosicaoXadrez('c', 1).paraPosicao());

            tab.colocarPeca(
                new Torre(Cor.Branca, tab),
                new PosicaoXadrez('c', 2).paraPosicao());

            tab.colocarPeca(
                new Torre(Cor.Branca, tab),
                new PosicaoXadrez('d', 2).paraPosicao());

            tab.colocarPeca(
                new Torre(Cor.Branca, tab),
                new PosicaoXadrez('e', 2).paraPosicao());

            tab.colocarPeca(
                new Torre(Cor.Branca, tab),
                new PosicaoXadrez('e', 1).paraPosicao());

            tab.colocarPeca(
                new Rei(Cor.Branca, tab),
                new PosicaoXadrez('d', 1).paraPosicao());

            // ----------

            tab.colocarPeca(
                new Torre(Cor.Preta, tab),
                new PosicaoXadrez('c', 7).paraPosicao());

            tab.colocarPeca(
                new Torre(Cor.Preta, tab),
                new PosicaoXadrez('c', 8).paraPosicao());

            tab.colocarPeca(
                new Torre(Cor.Preta, tab),
                new PosicaoXadrez('d', 7).paraPosicao());

            tab.colocarPeca(
                new Torre(Cor.Preta, tab),
                new PosicaoXadrez('e', 7).paraPosicao());

            tab.colocarPeca(
                new Torre(Cor.Preta, tab),
                new PosicaoXadrez('e', 8).paraPosicao());

            tab.colocarPeca(
                new Rei(Cor.Preta, tab),
                new PosicaoXadrez('d', 8).paraPosicao());
        }
    }
}
