using System;

namespace Decorator.YalynkaExample
{
    class MainApp
    {
        static void Main()
        {
            // Create a basic Christmas tree
            Yalynka yalynka = new BasicYalynka();

            // Decorate the tree with ornaments
            yalynka = new OrnamentsDecorator(yalynka);

            // Decorate the tree with garlands
            yalynka = new GarlandsDecorator(yalynka);

            // Display the decorated Christmas tree
            yalynka.Display();

            // Wait for user
            Console.Read();
        }
    }

    // Component - Інтерфейс для ялинки
    interface Yalynka
    {
        void Display();
    }

    // ConcreteComponent - Базовий клас ялинки
    class BasicYalynka : Yalynka
    {
        public void Display()
        {
            Console.WriteLine("Basic Christmas Tree");
        }
    }

    // Decorator - Абстрактний декоратор
    abstract class YalynkaDecorator : Yalynka
    {
        protected Yalynka yalynka;

        public YalynkaDecorator(Yalynka yalynka)
        {
            this.yalynka = yalynka;
        }

        public virtual void Display()
        {
            yalynka.Display();
        }
    }

    class OrnamentsDecorator : YalynkaDecorator
    {
        public OrnamentsDecorator(Yalynka yalynka) : base(yalynka) { }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("With Ornaments");
        }
    }

    class GarlandsDecorator : YalynkaDecorator
    {
        public GarlandsDecorator(Yalynka yalynka) : base(yalynka) { }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("With Garlands (Lights On)");
        }
    }
}
