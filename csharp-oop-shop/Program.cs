using csharp_oop_shop;

Prodotto prodotto1 = new Prodotto("Fagioli", "Scatola da 300g", 2.65, 4);


Console.WriteLine(prodotto1.GetNome());
Console.WriteLine(prodotto1.GetDescrizione());
Console.WriteLine(prodotto1.GetPrezzo());
Console.WriteLine(prodotto1.GetIva());
Console.WriteLine(prodotto1.GetCodice());

prodotto1.CambiaNome("Fagioli rossi");
prodotto1.CambiaDescrizione("Scatola da 400g");
prodotto1.CambiaPrezzo(3.65);
prodotto1.CambiaIva(5);

Console.WriteLine(prodotto1.GetNome());
Console.WriteLine(prodotto1.GetDescrizione());
Console.WriteLine(prodotto1.GetPrezzo());
Console.WriteLine(prodotto1.GetIva());
