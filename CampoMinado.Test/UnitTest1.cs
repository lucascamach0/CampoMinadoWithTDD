using System;
using Xunit;

namespace CampoMinado.Test
{
    public class UnitTest1
    {
        [Fact]
        public void DeveIniciarUmJogoComOTamanhoDoGrid()
        {
            Jogo jogo = new Jogo();
            jogo.IniciarJogo(5);
            Assert.Equal(new string[5, 5], jogo.Grid);
        }

        [Fact]
        public void DevePreencherBombasPelaCoordenada()
        {
            Jogo jogo = new Jogo();
            var grid = jogo.IniciarJogo(5);

            jogo.PreencherBomba(1, 3);
            var esperado = new string[5, 5];
            esperado[1, 3] = "*";

            Assert.Equal(esperado[1, 3], jogo.Grid[1, 3]);
        }

        [Fact]
        public void DevePreencherONumeroDeBombasEmVolta()
        {
            Jogo jogo = new Jogo();
            var grid = jogo.IniciarJogo(5);

            jogo.PreencherBomba(0,1);
            jogo.PreencherBomba(0,2);
            jogo.PreencherBomba(0,3);
            jogo.PreencherBomba(1,1);
            jogo.PreencherBomba(1,3);
            jogo.PreencherBomba(2,1);
            jogo.PreencherBomba(2,2);
            jogo.PreencherBomba(2,3);

            jogo.PreencherValores();

            Assert.Equal("8", jogo.Grid[1, 2]);
        }

        
    }
}
