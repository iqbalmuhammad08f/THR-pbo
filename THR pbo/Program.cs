class Karyawan
{
    private string nama;
    private string id;
    private double gaji_pokok;

    public string _nama
    {
        get { return nama; }
        set { nama = value; }
    }

    public string _id
    {
        get { return id; }
        set { id = value; }
    }

    public double _gaji_pokok
    {
        get { return gaji_pokok; }
        set { gaji_pokok = value; }
    }
    public virtual double hitungGaji()
    {
        return gaji_pokok;
    }
}

class KaryawanTetap : Karyawan
{
    
    public override double hitungGaji()
    {
        return _gaji_pokok + 500000;
    }
}

class KaryawanKontrak : Karyawan
{
    public override double hitungGaji()
    {
        return _gaji_pokok - 200000;
    }
}

class KaryawanMagang : Karyawan
{
    public override double hitungGaji()
    {
        return _gaji_pokok;
    }
}

class Program
{
    public static void Main()
    {
        KaryawanTetap karyawanTetap = new KaryawanTetap();
        KaryawanKontrak karyawanKontrak = new KaryawanKontrak();
        KaryawanMagang karyawanMagang = new KaryawanMagang();

        Console.WriteLine("=====Karyawan Tetap=====");
        Console.Write("Masukkan nama: ");
        karyawanTetap._nama = Console.ReadLine();
        Console.Write("Masukkan id: ");
        karyawanTetap._id = Console.ReadLine();
        Console.Write("Masukkan gaji pokok: ");
        karyawanTetap._gaji_pokok = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Gaji akhir: {karyawanTetap.hitungGaji()}");

        Console.WriteLine("\n=====Karyawan Kontrak=====");
        Console.Write("Masukkan nama: ");
        karyawanKontrak._nama = Console.ReadLine();
        Console.Write("Masukkan id: ");
        karyawanKontrak._id = Console.ReadLine();
        Console.Write("Masukkan gaji pokok: ");
        karyawanKontrak._gaji_pokok = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Gaji akhir: {karyawanKontrak.hitungGaji()}");

        Console.WriteLine("\n=====Karyawan Magang=====");
        Console.Write("Masukkan nama: ");
        karyawanMagang._nama = Console.ReadLine();
        Console.Write("Masukkan id: ");
        karyawanMagang._id = Console.ReadLine();
        Console.Write("Masukkan gaji pokok: ");
        karyawanMagang._gaji_pokok = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Gaji akhir: {karyawanMagang.hitungGaji()}");




    }
}