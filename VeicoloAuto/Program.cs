//creo un veicolo e assegno prop

using VeicoloAuto;

Veicolo veicolo = new Veicolo()
{
    Marca = "Fiat",
    Modello = "Panda",
    Anno = 2010,
    VelocitaMassima = 150
};
veicolo.Descrizione();

Auto auto = new Auto()
{
    Marca = "VW",
    Modello = "Caddy",
    Anno = 2015,
    VelocitaMassima = 150,
    NumeroPorte = 5    
};
auto.Descrizione();
