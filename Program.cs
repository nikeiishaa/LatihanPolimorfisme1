using System.ComponentModel.Design;
ImageProcessor imageProcessor = new ImageProcessor();

imageProcessor.Resize(-20);
imageProcessor.Resize(25);
imageProcessor.Resize(90);
imageProcessor.Resize(500, 200);
imageProcessor.Resize("A4");

class ImageProcessor
{
    public void Resize(int persen)
    {
        if (persen <= 0)
        {
            Console.Write("Error! Peresntase tidak boleh nol atau negatif");
        }
        else if (persen < 100)
        {
            Console.WriteLine($"Mengecilkan gambar sebesar {persen}%");
        }
        else if (persen > 100)
        {
            Console.WriteLine($"Memperbesar gambar sebesar {persen}%");
        }
        else
        {
            Console.WriteLine("Ukuran tetap (100%)! Tidak ada perubahan");
        }
    }
    public void Resize(int panjang, int lebar)
    {
        Console.WriteLine($"Mengubah ukuran gambar menjadi {panjang} px X {lebar}");
    }

    public void Resize (string UkuranKertas)
    {
        Console.WriteLine($"Menyesuaikan ke format kertas {UkuranKertas}");
    }
}
