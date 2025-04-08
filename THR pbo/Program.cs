// Kelas utama untuk mendefinisikan atribut dan metode dasar karyawan
class Karyawan
{
    // Atribut privat untuk menyimpan data karyawan
    private string nama;
    private string id;
    private double gaji_pokok;

    // Properti untuk mengakses dan mengubah atribut 'nama'
    public string _nama
    {
        get { return nama; }
        set { nama = value; }
    }

    // Properti untuk mengakses dan mengubah atribut 'id'
    public string _id
    {
        get { return id; }
        set { id = value; }
    }

    // Properti untuk mengakses dan mengubah atribut 'gaji_pokok'
    public double _gaji_pokok
    {
        get { return gaji_pokok; }
        set { gaji_pokok = value; }
    }

    // Metode virtual untuk menghitung gaji, dapat di-override oleh kelas turunan
    public virtual double hitungGaji()
    {
        return gaji_pokok;
    }
}

// Kelas turunan untuk karyawan tetap
class KaryawanTetap : Karyawan
{
    // Override metode hitungGaji untuk menambahkan tunjangan tetap
    public override double hitungGaji()
    {
        return _gaji_pokok + 500000; // Tambahan tunjangan sebesar 500.000
    }
}

// Kelas turunan untuk karyawan kontrak
class KaryawanKontrak : Karyawan
{
    // Override metode hitungGaji untuk mengurangi potongan kontrak
    public override double hitungGaji()
    {
        return _gaji_pokok - 200000; // Potongan sebesar 200.000
    }
}

// Kelas turunan untuk karyawan magang
class KaryawanMagang : Karyawan
{
    // Override metode hitungGaji tanpa perubahan (gaji pokok tetap)
    public override double hitungGaji()
    {
        return _gaji_pokok;
    }
}

// Kelas Program untuk menjalankan aplikasi
class Program
{
    public static void Main()
    {
        // Membuat objek untuk masing-masing jenis karyawan
        KaryawanTetap karyawanTetap = new KaryawanTetap();
        KaryawanKontrak karyawanKontrak = new KaryawanKontrak();
        KaryawanMagang karyawanMagang = new KaryawanMagang();

        // Input dan output untuk karyawan tetap
        Console.WriteLine("=====Karyawan Tetap=====");
        Console.Write("Masukkan nama: ");
        karyawanTetap._nama = Console.ReadLine(); // Input nama
        Console.Write("Masukkan id: ");
        karyawanTetap._id = Console.ReadLine(); // Input id
        Console.Write("Masukkan gaji pokok: ");
        karyawanTetap._gaji_pokok = Convert.ToDouble(Console.ReadLine()); // Input gaji pokok
        Console.WriteLine($"Gaji akhir: {karyawanTetap.hitungGaji()}"); // Output gaji akhir

        // Input dan output untuk karyawan kontrak
        Console.WriteLine("\n=====Karyawan Kontrak=====");
        Console.Write("Masukkan nama: ");
        karyawanKontrak._nama = Console.ReadLine(); // Input nama
        Console.Write("Masukkan id: ");
        karyawanKontrak._id = Console.ReadLine(); // Input id
        Console.Write("Masukkan gaji pokok: ");
        karyawanKontrak._gaji_pokok = Convert.ToDouble(Console.ReadLine()); // Input gaji pokok
        Console.WriteLine($"Gaji akhir: {karyawanKontrak.hitungGaji()}"); // Output gaji akhir

        // Input dan output untuk karyawan magang
        Console.WriteLine("\n=====Karyawan Magang=====");
        Console.Write("Masukkan nama: ");
        karyawanMagang._nama = Console.ReadLine(); // Input nama
        Console.Write("Masukkan id: ");
        karyawanMagang._id = Console.ReadLine(); // Input id
        Console.Write("Masukkan gaji pokok: ");
        karyawanMagang._gaji_pokok = Convert.ToDouble(Console.ReadLine()); // Input gaji pokok
        Console.WriteLine($"Gaji akhir: {karyawanMagang.hitungGaji()}"); // Output gaji akhir
    }
}
