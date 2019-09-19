import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;
public class Main {
    public static void main(String[] args) {

        //sum of two elems in the array

        System.out.println("------------------------------Нахождение элементов------------------------------");
        Scanner sca = new Scanner(System.in);
        System.out.println("Введите количество элементов");
        int [] ara = new int[Integer.parseInt(sca.nextLine())];
        for (int i = 0; i < ara.length; i++){
            System.out.println("Введите элемент " + i);
            ara[i] = Integer.parseInt(sca.nextLine());
        }
        Arrays.sort(ara);
        System.out.println("Введите число");
        int sum = Integer.parseInt(sca.nextLine());
        sumOfElems(ara, sum);

        //avgOfPositives

        System.out.println("----------------------------------Среднее положительных----------------------------------");
        System.out.println("Введите размерность массива");
        ara = new int[Integer.parseInt(sca.nextLine())];
        for (int i = 0; i< ara.length; i++){
            ara[i] = Integer.parseInt(sca.nextLine());
        }
        System.out.println(avgOfPositives(ara));


        //rabotyagi s zavoda

        System.out.println("----------------------------------Height checker----------------------------------");
        System.out.println("Введите размерность массива");
        ara = new int[Integer.parseInt(sca.nextLine())];
        for (int i = 0; i< ara.length; i++){
            ara[i] = Integer.parseInt(sca.nextLine());
        }
        System.out.println(heightcheker(ara));

        //checking duplicates

        System.out.println("----------------------------------Checking duplicateZ----------------------------------");
        System.out.println("Введите размерность массива");
        ara = new int[Integer.parseInt(sca.nextLine())];
        for (int i = 0; i< ara.length; i++) {
            ara[i] = Integer.parseInt(sca.nextLine());
        }
        checkDuplicates(ara);

        //mins sum of subarray

        System.out.println("----------------------------------Min of subarrays----------------------------------");
        System.out.println("Введите размерность массива");
        ara = new int[Integer.parseInt(sca.nextLine())];
        for (int i = 0; i< ara.length; i++) {
            ara[i] = Integer.parseInt(sca.nextLine());
        }
        System.out.println(minOfSubarrays(ara));

    }


    private static void checkDuplicates(int[] ara){
        ArrayList<Integer> unique = new ArrayList<Integer>();
        for(int x: ara){
            if(!unique.contains(x)){
                unique.add(x);
            }
            else {
                System.out.println(x + " is a duplicate");
            }
        }

    }

    private static String avgOfPositives(int[] ar){
        int sum = 0;
        int counter = 0;
        for(Integer x:ar){
            if(x > 0 ){
                sum += x;
                counter++;
            }
        }
        if(counter != 0){
            return ("Avg of positives: " + sum/counter);
        }
        else {
            return("No positives");
        }
    }

     private static void sumOfElems(int[] ar, int sum){
        for(int i = 0; i < ar.length; i++){
            boolean flag = false;
            for (int j = ++i; j < ar.length; j++){
                if(ar[i] + ar[j] == sum){
                    System.out.println("Индексы: " + i + ", " + j);
                }
                if(ar[i] + ar[j] > sum){
                    break;
                }
                if (j == ++i){
                    flag = true;
                }
            }
            if(flag){
                break;
            }
        }
    }

    private static String heightcheker(int[] ara) {
        int temp = 0;
        int count = 0;
        for (int i = 0; i < ara.length; i++) {
            boolean lul = false;
            for (int j = 1; j < ara.length; j++) {
                if (ara[j - 1] > ara[j]) {
                    lul = true;
                    temp = ara[j - 1];
                    ara[j - 1] = ara[j];
                    ara[j] = temp;
                }
            }
            if(!lul){
                break;
            }
            count++;
        }
        return Integer.toString(++count);
    }


    private static int minOfSubarrays(int [] ara){
        ArrayList<Integer> list= new ArrayList<Integer>();
        int sum = 0;
        for (int i = 0; i <ara.length ; i++) {
            for (int grps = i; grps <=ara.length ; grps++) {
                for (int j = i ; j < grps ; j++) {
                    list.add(ara[j]);
                    sum += countMin(list);
                }
            }
        }
        return sum;
    }

    private static int countMin(ArrayList<Integer> list){
        int min = list.get(0);
        for(int x:list){
            if(x < min){
                min = x;
            }
        }
        return min;
    }

}
