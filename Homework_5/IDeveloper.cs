namespace Homework_5
{
    public interface IDeveloper
    {
        string Tool { get; set; }

        void Create();
        void Destroy();
    }
    class Programmer : IDeveloper
    {
        public string Language { get; set; }

        public string Tool { get; set; }

        public void Create()
        {
            Console.WriteLine("Програмiст пише код");
        }

        public void Destroy()
        {
            Console.WriteLine("Програмiст видаляє код");
        }
    }

    class Builder : IDeveloper
    {
        public string Equipment { get; set; }

        public string Tool { get; set; }

        public void Create()
        {
            Console.WriteLine("Будiвельник щось будує");
        }

        public void Destroy()
        {
            Console.WriteLine("Будiвельник щось руйнує");
        }
    }

}

