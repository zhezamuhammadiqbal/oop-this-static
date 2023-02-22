using App;

Rumus.tampil();

Rumus rumus = new Rumus();
Console.Write("masukkan jari - jari : ");   
int r = Convert.ToInt16(Console.ReadLine());
rumus.set(r);
Console.Write($"luas lingkaran dengan r : {r} adalah : ");
rumus.get();