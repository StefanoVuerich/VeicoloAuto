namespace VeicoloAuto
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Auto : Veicolo
    {
        public int NumeroPorte { get; set; }

        public override void Descrizione()
        {
            Console.WriteLine($"{Marca}, {Modello}, {Anno}, {VelocitaMassima}, {NumeroPorte}");
        }
    }
}
