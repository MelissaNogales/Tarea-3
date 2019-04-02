using System;
using System.Collections.Generic;

namespace Figura
{
    class Vector2d
    {
        public int x, y;

        public Vector2d(int x, int y)
        {
            this.x = x; 
            this.y = y;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}", x, y);
        }
    }
    class Figura
    {
        public Vector2d position;
        public string color;

        public Figura(): this(new Vector2d(100, 100))
        {
        
        }

        public Figura(Vector2d pos)
        {
            position = pos;
        }

        public virtual void Dibuja()
        {
            Console.WriteLine("Se dibuja una figura en la posición {0}, color {1}", position, color);
        }
    }

    class Rectangulo: Figura
    {
        public Rectangulo(Vector2d pos): base(pos)
        {
            color = "Blanco";
        }

        public Rectangulo(): base()
        {
        
        }
    }

    class Cuadrado: Figura
    {
        public Cuadrado(Vector2d pos): base(pos)
        {
            color = "Gris";
        }

        public Cuadrado(): base()
        {
        
        }
    }

    class Triangulo: Figura
    {
        public Triangulo(Vector2d pos): base(pos)
        {
            color = "Verde";
        }

        public Triangulo(): base()
        {
        
        }
    }

    class Trapecio: Figura
    {
        public Trapecio(Vector2d pos): base(pos)
        {
            color = "Morado";
        }

        public Trapecio(): base()
        {
        
        }
    }

    class Rombo: Figura
    {
        public Rombo(Vector2d pos): base(pos)
        {
            color = "Rojo";
        }

        public Rombo(): base()
        {
        
        }
    }

    class Circulo: Figura
    {
        private int radio;

        public Circulo(Vector2d pos, int radio): base(pos)
        {
            this.radio = radio;
        }

        public Circulo (): base()
        {
            this.radio = 10;
            color = "Negro";
        }

        public override void Dibuja() 
        {
            Console.WriteLine("Se dibuja un Circulo en la posición {0}, color {1}", position, color);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();
            figuras.Add(new Circulo());
            figuras.Add(new Rectangulo(new Vector2d(150, 150)));
            figuras.Add(new Cuadrado(new Vector2d(50, 50)));
            figuras.Add(new Triangulo(new Vector2d(500, 500)));
            figuras.Add(new Trapecio(new Vector2d(520, 520)));
            figuras.Add(new Rombo(new Vector2d(90, 90)));
            foreach(Figura f in figuras)
            f.Dibuja();
        }
    }
}