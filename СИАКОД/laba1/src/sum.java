import java.util.ArrayList;
import java.util.Comparator;
import java.util.HashSet;
import java.util.Scanner;
public class sum {
    public static void main(String[] args) {
        ArrayList<Integer> list = new ArrayList<Integer>();
        Scanner sca = new Scanner(System.in);
        System.out.println("Введите количество элементов");
        int amount = Integer.parseInt(sca.nextLine());
        for (int i = 0; i < amount; i++){
            System.out.println("Введите элемент " + i);
            list.add(Integer.parseInt(sca.nextLine()));
        }
        list = new ArrayList<Integer>(new HashSet<>(list));
        list.sort(Comparator.naturalOrder());
        System.out.println("Введите число");
        int sum = Integer.parseInt(sca.nextLine());
        checkMother(list, sum);

        //avgOfPositivies
        System.out.println("----------------------------------Среднее положительных----------------------------------");
        System.out.println("Введите размерность массива");
        int [] avgOfPositivesAr = new int[Integer.parseInt(sca.nextLine())];
        for (int i = 0; i< avgOfPositivesAr.length; i++){
            avgOfPositivesAr[i] = Integer.parseInt(sca.nextLine());
        }
        System.out.println(avgOfPositives(avgOfPositivesAr));
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

     private static void checkMother(ArrayList<Integer> list, int sum){
        boolean found = false;
        for(int i = 0; i < list.size(); i++){
            for (int j = 0; j < list.size(); j++){
                if ((list.get(i) + list.get(j)) == sum){
                    System.out.println("Элементы: " + i+ j);
                    found = true;
                    break;
                }
                if(found){
                    break;
                }
            }
        }
    }
}
