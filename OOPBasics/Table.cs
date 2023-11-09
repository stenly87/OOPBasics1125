namespace OOPBasics
{
    class Table
    {
        //globally unique identifier - для различия 
        // одинаковых объектов
        public string GUID { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public Material Material { get; set; }
        // Можно потратить много времени на 
        // поиск подходящего имени для свойства
        // потому что свойство ниже это может быть
        // цена покупки/продажи/разработки и тп
        public decimal Price { get; set; }
        // Наименование объектов/свойств/методов и тп
        // прямо влияют на качество разработки
        // в обозримом будущем, поскольку люди 
        // склонны интерпретировать одни и те же
        // термины по-разному

        // сильно притянуто за уши
        // но Hit - меняет состояние объекта
        // Hit - поведение

        public bool IsBroken { get; set; } = false;

        public void Hit()
        { 
            IsBroken = true;
        }
    }

    class BadHuman
    {
        public string Name { get; set; }
        // деструктивное действие асоциального
        // элемента
        public void Kick(Table obj)
        {
            Console.WriteLine("На, получи!");// боевой клич
            obj.Hit(); // ответ на действие (следствие удара)
        }
    }
}