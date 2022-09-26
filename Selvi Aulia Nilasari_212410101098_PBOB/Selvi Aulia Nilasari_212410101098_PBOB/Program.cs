class Program
{
    static void Main(string[] args)
    {
        Nvidia nvidia = new Nvidia();
        Corei5 corei5 = new Corei5();   
        Laptop laptop1 = new Vivobook(nvidia, corei5);
        Amd amd = new Amd();
        Ryzen ryzen = new Ryzen();
        Corei7 corei7 = new Corei7();
        Laptop laptop2 = new IdeaPad(amd, ryzen);
        Predator predator = new Predator(amd, corei7);
        predator.BermainGame();
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();
        Console.WriteLine($"{laptop1.vga}, {laptop1.processor.Merk}, {laptop1.processor}");

    }
}
class Processor
{
    public string Merk;
    public string Tipe;

    public Processor (string merk, string tipe)
    {
        this.Merk = merk;
        this.Tipe = tipe;
    }
}


class Intel : Processor
{
    public Intel (string tipe) : base("Intel", tipe)
    {
        this.Tipe=tipe;
    }
}

class Corei3 : Intel
{
    public Corei3() : base("Corei3")
    {

    }
}

class Corei5 : Intel
{
    public Corei5() : base("Corei5")
    {

    }
}

class Corei7 : Intel
{
    public Corei7() : base("Corei7")
    {

    }
}

class AMD : Processor
{
    public AMD (string tipe) : base("AMD", tipe)
    {
        this.Tipe = tipe;
    }
}

class Ryzen : AMD
{
    public Ryzen() : base("Ryzen")
    {

    }
}

class Athlon : AMD
{
    public Athlon() : base("Athlon")
    {

    }
}
class Vga
{
    public string Merk;
    public Vga(string merk)
    {
        this.Merk = merk;
    }
}

class Nvidia : Vga
{
    public Nvidia() : base("Nvidia")
    {

    }
}

class Amd : Vga
{
    public Amd() : base("Amd")
    {

    }
}

class Laptop
{
    public string merk;
    public string tipe;
    public Vga vga;
    public Processor processor;

    public Laptop(string merk, string tipe, Vga vga, Processor processor)
    {
        this.merk = merk;
        this.tipe = tipe;
        this.vga = vga;
        this.processor = processor;
    }

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop bermerek {this.merk} bertipe {this.tipe} sedang dinyalakan");
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop bermerek {this.merk} bertipe {this.tipe} sedang dimatikan");

    }
}

class ASUS : Laptop
{
    public ASUS(string tipe, Vga vga, Processor processor) : base("ASUS", tipe, vga, processor)
    {
        this.tipe = tipe;
        this.vga=vga;
        this.processor = processor;
    }
}

class ROG : ASUS
{
    public ROG( Vga vga, Processor processor) : base("ROG", vga, processor)
    {
        this.vga = vga;
        this.processor = processor;
    }
}

class Vivobook : ASUS
{
    public Vivobook(Vga vga, Processor processor) : base("Vivobook ", vga, processor)
    {
        this.vga = vga;
        this.processor = processor;
    }
    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

class ACER : Laptop
{
    public ACER(string tipe, Vga vga, Processor processor) : base("ACER", tipe, vga, processor)
    {
        this.tipe = tipe;
        this.vga = vga;
        this.processor = processor;
    }
}

class Swift : ACER
{
    public Swift(Vga vga, Processor processor) : base("Swift", vga, processor)
    {
        this.vga = vga;
        this.processor = processor;
    }
}


class Predator : ACER
{
    public Predator( Vga vga, Processor processor) : base("Predator", vga, processor)
    {
        this.vga = vga;
        this.processor = processor;
    }
    public void BermainGame()
    {
        Console.WriteLine($"Laptop bermerk {this.merk} bertipe {this.tipe} sedang memainkan game");
    }
}

class Lenovo : Laptop
{
    public Lenovo(string tipe, Vga vga, Processor processor) : base("Lenovo", tipe, vga, processor)
    {
        this.tipe = tipe;
        this.vga = vga;
        this.processor = processor;
    }
}

class IdeaPad: Lenovo
{
    public IdeaPad(Vga vga, Processor processor) : base("IdeaPad", vga, processor)
    {
        this.vga = vga;
        this.processor = processor;
    }
}

class Legion : Lenovo
{
    public Legion (Vga vga, Processor processor) : base("Legion", vga, processor)
    {
        this.vga = vga;
        this.processor = processor;
    }
}
