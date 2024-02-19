// See https://aka.ms/new-console-template for more information
using AbstractClassExample;

Console.WriteLine("Hello, World!");

var m = new Mucca();
m.NumeroZampe = 4;
m.Colore = "Bianco";
m.FaiVerso();
m.Salta();

var c = new Cane();
c.FaiVerso();
c.Salta();

Console.ReadKey();
