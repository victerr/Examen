using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PelotaRebota
{
    class Pelota
    {
        int dirX;
        int dirY;
        int x;
        int y;
        string imagen;

        public Pelota(int dirX, int dirY, int x, int y)
        {
            this.x = 1;
            this.y = 1;
            this.dirX = dirX;
            this.dirY = dirY;
            this.imagen = "O";
        }

        public void Mover()
        {
            Borrar();
            y += dirY;
            x += dirX;
            Dibujar();
            Thread.Sleep(80);
        }

        public void Borrar()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }

        public void Dibujar()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(imagen);
        }

        public bool HayColision()
        {
            bool hayColision = false;

            if (ColisionAbajo()||ColisionArriba()||ColisionDerecha()||ColisionIzquierda())
            {
                hayColision = true;
            }

            return hayColision;
        }

        public void CambiarDireccion()
        {
            Random rnd = new Random();

            if (ColisionIzquierda())
            {
                this.dirX = 1;
                this.dirY = rnd.Next(-1, 1);
            }
            else if (ColisionDerecha())
            {
                this.dirX = -1;
                this.dirY = rnd.Next(-1, 1);
            }
            else if (ColisionArriba())
            {
                this.dirX = rnd.Next(-1, 1);
                this.dirY = 1;
            }
            else if (ColisionAbajo())
            {
                this.dirX = rnd.Next(-1, 1);
                this.dirY = -1;
            }
        }

        public bool ColisionDerecha()
        {
            bool colision=false;

            if(this.x == Console.WindowWidth-1)
            {
                colision = true;
            }

            return colision;
        }

        public bool ColisionIzquierda()
        {
            bool colision = false;

            if (this.x == Console.WindowLeft)
            {
                colision = true;
            }

            return colision;
        }

        public bool ColisionAbajo()
        {
            bool colision = false;

            if (this.y == Console.WindowHeight)
            {
                colision = true;
            }

            return colision;
        }
        public bool ColisionArriba()
        {
            bool colision = false;

            if (this.y == Console.WindowTop)
            {
                colision = true;
            }

            return colision;
        }
        public int GetDirX()
        {
            return this.dirX;
        }

        public void SetDirX(int dirX)
        {
            this.dirX = dirX;
        }

        public int GetDirY()
        {
            return this.dirY;
        }

        public void SetDirY(int dirY)
        {
            this.dirY = dirY;
        }

        public string GetImagen()
        {
            return this.imagen;
        }

        public void SetImagen(string imagen)
        {
            this.imagen = imagen;
        }
    }
}
