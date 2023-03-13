//QuickSort Algoritması 
static void QuickSort(int[] arr, int left, int right) {
    if (left < right) {
        int pivot = Partition(arr, left, right);
        if (pivot > 1) {
            QuickSort(arr, left, pivot - 1);
        }
        if (pivot + 1 < right) {
            QuickSort(arr, pivot + 1, right);
        }
    }
}

 static int Partition(int[] arr, int left, int right) {
    int pivot = arr[left];
    while (true) {
        while (arr[left] < pivot) {
            left++;
        }
        while (arr[right] > pivot) {
            right--;
        }
        if (left < right) {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
        } else {
            return right;
        }
    }
}
//BruteForce Algortiması 

 static void BruteForceSort(int[] arr) {
    for (int i = 0; i < arr.Length - 1; i++) {
        for (int j = i + 1; j < arr.Length; j++) {
            if (arr[j] < arr[i]) {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
}
