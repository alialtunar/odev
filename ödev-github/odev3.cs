//Big-O gösterimi açıklanan algoritma açıklama text dosyasında
static int DiziToplam(int[] dizi)
{
    int toplam = 0;
    for (int i = 0; i < dizi.Length; i++)
    {
        toplam += dizi[i];
    }
    return toplam;
}
