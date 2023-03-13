//Bir dizi içindeki en büyük sayıyıen hızlı bulmak için Yazdığım Algoritma
static int EnBuyukSayi(int[] dizi)
{
    int n = dizi.Length;
    int k = n - 1; // En büyük sayı sıralı dizinin son elemanıdır
    int sol = 0;
    int sag = n - 1;

    while (sol <= sag)
    {
        int pivotIndex = Partition(dizi, sol, sag);

        if (pivotIndex == k)
        {
            return dizi[pivotIndex];
        }
        else if (pivotIndex > k)
        {
            sag = pivotIndex - 1;
        }
        else
        {
            sol = pivotIndex + 1;
        }
    }

    return -1; // Bulunamadı
}

static int Partition(int[] dizi, int sol, int sag)
{
    int pivotValue = dizi[sag];
    int pivotIndex = sol;

    for (int i = sol; i < sag; i++)
    {
        if (dizi[i] > pivotValue)
        {
            Swap(dizi, i, pivotIndex);
            pivotIndex++;
        }
    }

    Swap(dizi, pivotIndex, sag);

    return pivotIndex;
}

static void Swap(int[] dizi, int x, int y)
{
    int temp = dizi[x];
    dizi[x] = dizi[y];
    dizi[y] = temp;
}


//Dizideki En Büyük Sayıyı bulan BruteForce Algoritma

static int EnBuyukSayi(int[] dizi)
{
    int enBuyukSayi = dizi[0];

    for (int i = 1; i < dizi.Length; i++)
    {
        if (dizi[i] > enBuyukSayi)
        {
            enBuyukSayi = dizi[i];
        }
    }

    return enBuyukSayi;
}
