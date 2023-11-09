namespace OOPBasics
{
    // данный класс отметим как абстрактный, поскольку нет
    // конкретики, что это именно за материал
    // абстрактные классы могут содержать абстрактные методы
    // это методы без реализации
    public abstract class Material
    {
        protected int someValue;
        public double Durable { get; set; }

        // абстрактный метод (без реализации)
        protected abstract void Burn();

        public void TryBurn()
        {
            Burn();
        }
    }
    // пример наследования
    // Material - родитель
    // WoodMaterial - наследник
    public class WoodMaterial : Material
    {
        void SomeTestMethod()
        { // доступ к состоянию родительского класса
            someValue = 1;
        }
        // реализация абстрактного метода родительского класса
        // путем переопределения метода
        protected override void Burn()
        {
            Console.WriteLine("Горит великолепно!");
        }
    }

    public class MetalMaterial : Material
    {
        // иная реализация абстрактного метода
        // родительского класса
        protected override void Burn()
        {
            Console.WriteLine("Не горит");
        }
    }
}