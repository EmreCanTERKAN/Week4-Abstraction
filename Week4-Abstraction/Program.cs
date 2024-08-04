using System;

class Program
{
    static void Main()
    {
        IGorev yazılımcı = new Yazılımcı("ali", "ata", "bak");
        yazılımcı.Gorev();
        IGorev yalaka = new Yalakayım("veli", "ipten", "atla");
        yalaka.Gorev();
        IGorev yönetici = new Yönetici("pelin", "topı", "tut.");
        yönetici.Gorev();
    }
}


class Person
{
    public string Adı { get; set; }
    public string Soyadı { get; set; }
    public string Departman { get; set; }


    public Person(string adı, string soyadı, string departman)
    {
        Adı = adı;
        Soyadı = soyadı;
        Departman = departman;

    }


}

class Yazılımcı : Person, IGorev
{
    public Yazılımcı(string a, string b, string c) : base(a, b, c)
    {
        Console.WriteLine($"Adım : {a}\nSoyadım: {b}\nDepartmanım : {c} ");
    }


    public void Gorev()
    {
        Console.WriteLine("Ben Yazılımcıyım...");
    }
}
class Yönetici : Person, IGorev
{
    public Yönetici(string a, string b, string c) : base(a, b, c)
    {
        Console.WriteLine($"Adım : {a}\nSoyadım: {b}\nDepartmanım : {c} ");
    }

    public void Gorev()
    {
        Console.WriteLine("Ben Yöneticiyim..");
    }
}

class Yalakayım : Person, IGorev
{
    public Yalakayım(string a, string b, string c) : base(a, b, c)
    {
        Console.WriteLine($"Adım : {a}\nSoyadım: {b}\nDepartmanım : {c} ");
    }

    public void Gorev()
    {
        Console.WriteLine("Tam Bir orr.. Yalakayım.. Şirkette var benden çok");
    }
}

interface IGorev
{
    void Gorev();
}