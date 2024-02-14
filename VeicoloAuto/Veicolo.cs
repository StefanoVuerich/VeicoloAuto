namespace VeicoloAuto
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Veicolo
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
        public int Anno { get; set; }
        public int VelocitaMassima { get; set; }

        public void GetPropprietario()
        {

        }

        public virtual void Descrizione()
        {
            Console.WriteLine($"{Marca}, {Modello}, {Anno}, {VelocitaMassima}");
        }
    }
}
