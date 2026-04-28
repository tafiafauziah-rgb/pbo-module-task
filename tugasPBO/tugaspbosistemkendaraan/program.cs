namespace tugaspbosistemkendaraan
{
    public class Kendaraan
    {

        public string nama;
        public int kecepatan;

        public void TampilkanInformasi()
        {
            Console.WriteLine($"Kendaraan ini bernama {nama} sedang melaju dengan kecepatan {kecepatan} km/jam.");
        }
        public virtual void Bergerak()
        {

        }

    }
    // Class Darat
    public class Darat : Kendaraan
    {
        public int jumlahRoda;
        public void HitungRoda()
        {
            Console.WriteLine($"terdapat mobil {nama} memiliki total{ jumlahRoda } roda.");
        }
        public override void Bergerak()
        {
            Console.WriteLine($"kendaraan di darat bergerak");
        }
    }

    // Class Air
    public class Air : Kendaraan
    {
        public string jenisAir;

        public void CekKondisiAir()
        {
            Console.WriteLine($"sebuah mobil {nama}daerah memiliki kondisi yang{jenisAir}.");
        }
        public override void Bergerak()
        {
            Console.WriteLine($"kendaraan di air bergerak");
        }
    }

    // Class Mobil
    public class Mobil : Darat
    {
        public void TampilkanInformasi()
        {
            Console.WriteLine($"Kendaraan ini bernama {nama} sedang melaju dengan kecepatan {kecepatan} km/jam dan jumlah roda {jumlahRoda}.");
        }
        public void Klakson()
        {
            Console.WriteLine($"{nama} berbunyi: Tin! Tin!");
        }
        public override void Bergerak()
        {
            Console.WriteLine($"kendaraan bergerak");
        }
    }

    // Class Motor
    public class Motor : Darat
    {
        public void GasPol()
        {
            Console.WriteLine($"{nama} melaju dengan kecepatan maksimum!");
        }
        public override void Bergerak()
        {
            Console.WriteLine($"kendaraan motor bergerak");
        }
    }


    // Class Kapal
    public class Kapal : Air
    {
        public void Berlayar()
        {
            Console.WriteLine($"{nama} sedang berlayar menuju Indonesia.");
        }
        public override void Bergerak()
        {
            Console.WriteLine($"kendaraan kapal bergerak");
        }
    }

    // Class Perahu
    public class Perahu : Air
    {
        public void Dayung()
        {
            Console.WriteLine($"{nama} sedang didayung di sungai.");
        }
        public override void Bergerak()
        {
            Console.WriteLine($"kendaraan perahu mulai bergerak");
        }
    }

    // Class Garasi
    public class Garasi
    {
        public List<Kendaraan> daftarKendaraan = new List<Kendaraan>();

        public void TambahKendaraan(Kendaraan kendaraan)
        {
            daftarKendaraan.Add(kendaraan);
        }

        public void TampilkanSemuaKendaraan()
        {
            Console.WriteLine("\n=== Daftar Kendaraan di Garasi ===");
            foreach (Kendaraan kendaraan in daftarKendaraan)
            {
                kendaraan.TampilkanInformasi();
            }
        }
    }

    class program
    {
        static void Main(string[] args)
        {
          
            Mobil mobil = new Mobil();
            mobil.nama = "Honda HRV";
            mobil.kecepatan = 180;
            mobil.jumlahRoda = 4;
            mobil.TampilkanInformasi();
            mobil.Klakson();
        
          
            Motor motor = new Motor();
            motor.nama = "Yamaha R15";
            motor.jumlahRoda = 2;
            mobil.HitungRoda();
            motor.GasPol();


            Kapal kapal = new Kapal();
            kapal.nama = "Kapal Pesiar";
            kapal.kecepatan = 70;
            kapal.jenisAir = "laut";
            kapal.CekKondisiAir();


            Perahu perahu = new Perahu();
            perahu.nama = "Perahu Nelayan";
            perahu.kecepatan = 20;
            perahu.jenisAir = "sungai";
            perahu.Dayung();

            Kendaraan kendaraan = new Mobil();
            Kendaraan kendaraan1 = new Motor();
            Kendaraan kendaraan2 = new Perahu();
            Kendaraan kendaraan3 = new Kapal();
            kendaraan.Bergerak();
            kendaraan1.Bergerak();
            kendaraan2.Bergerak();
            kendaraan3.Bergerak();

            Garasi garasi = new Garasi();
            garasi.TambahKendaraan(mobil);
            garasi.TambahKendaraan(motor);
            garasi.TambahKendaraan(kapal);
            garasi.TambahKendaraan(perahu);
            garasi.TampilkanSemuaKendaraan();
        }
    }
}



        

