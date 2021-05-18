using System;
using Xunit;
using Bowling;



namespace BowlingTest
{
    public class BowlingTest
    {
        [Fact]
        public void All_Zero()
        {
            Juego juego = new Juego();
            
            for (int i = 1; i <= 20; i++)
            {

                juego.Tirar(0);                         
                
            }

            Assert.Equal(0, juego.Score());
         
        }

        [Fact]
        public void All_One()
        {
            Juego juego = new Juego();

            for (int i = 1; i <= 20; i++)
            {

                juego.Tirar(1);

            }

            Assert.Equal(20, juego.Score());

        }

        [Fact]
        public void AtLeast_OneSpare()
        {
            Juego juego = new Juego();

            for (int i = 1; i <= 2; i++)
            {

                juego.Tirar(5);

            }

            for (int i = 1; i <= 18; i++)
            {

                juego.Tirar(1);

            }

            Assert.Equal(29, juego.Score());

        }

        [Fact]
        public void AtLeast_OneStrike()
        {
            Juego juego = new Juego();

            juego.Tirar(10);                  

            for (int i = 1; i <= 18; i++)
            {

                juego.Tirar(1);

            }

            Assert.Equal(30, juego.Score());

        }

        [Fact]
        public void PerfectGame()
        {
            Juego juego = new Juego();
            
            for (int i = 1; i <= 12; i++)
            {

                juego.Tirar(10);

            }

            Assert.Equal(300, juego.Score());

        }

    }
}
