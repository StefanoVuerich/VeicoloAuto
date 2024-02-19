namespace AbstractClassExample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Animal
    {
        public int NumeroZampe { get; set; }
        public string Colore { get; set; }

        public abstract void FaiVerso();

        public void Salta()
        {
            Console.WriteLine("Jump");
        }
    }
}
