import java.util.ArrayList;
import java.util.Arrays;

public class SortingAlgorithms<E extends Number> {
    public void quickSort(E[] array, int low, int high) {
        if (low < high) {
            int parted = partition(array, low, high);
            quickSort(array, low, parted - 1);
            quickSort(array, parted + 1, high);
        }
    }

    private int partition(E[] arr, int low, int high) {
        E pivot = arr[high];
        int i = (low - 1);
        for (int j = low; j < high; j++) {
            if (arr[j].doubleValue() < pivot.doubleValue()) {
                i++;
                E temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        E temp = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp;
        return i + 1;
    }


    public void mergeSort(E[] array, int l, int r) {
        if (l < r) {
            int m = (l + r) / 2;
            mergeSort(array, l, m);
            mergeSort(array,m + 1, r);
            merge(array, l, m, r);
        }
    }

    private void merge(E[] arr, int l, int m, int r) {
        int n1 = m - l + 1;
        int n2 = r - m;
        ArrayList<E> L = new ArrayList<E>();
        ArrayList<E> R = new ArrayList<E>();
        for (int i = 0; i < n1; i++) {
            L.add(arr[l + i]);
        }
        for (int j = 0; j < n2; j++) {
            R.add(arr[m + 1 + j]);
        }
        int i = 0;
        int j = 0;

        int k = l;
        while (i < n1 && j < n2) {
            if ((double) L.get(i) <= (double) R.get(j)) {
                arr[k] = L.get(i);
                i++;
            } else {
                arr[k] = R.get(j);
                j++;
            }
            k++;
        }

        while (i < n1) {
            arr[k] = L.get(i);
            i++;
            k++;
        }

        while (j < n2) {
            arr[k] = R.get(j);
            j++;
            k++;
        }
    }


    void cocktailSort(int a[]) {
        boolean swapped = true;
        int start = 0;
        int end = a.length;
        while (swapped) {
            swapped = false;
            for (int i = start; i < end - 1; ++i) {
                if (a[i] > a[i + 1]) {
                    int temp = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped) {
                break;
            }
            swapped = false;
            end = end - 1;
            for (int i = end - 1; i >= start; i--) {
                if (a[i] > a[i + 1]) {
                    int temp = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = temp;
                    swapped = true;
                }
            }
            start++;
        }
    }



    public void bogoSortLul(E[] array) {
        while (!isSorted(array)) {
            shuffle(array);
        }
    }

    private void shuffle(E[] array) {
        for (int i = 1; i <= array.length - 1; i++) {
            swap(array, i, (int) (Math.random() * i));
        }
    }

    private boolean isSorted(E[] array) {
        for (int i = 1; i < array.length - 1; i++) {
            if ((double) array[i] < (double) array[i - 1]) {
                return false;
            }
        }
        return true;
    }


    void swap(E[] array, int i, int j) {
        E temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

}
