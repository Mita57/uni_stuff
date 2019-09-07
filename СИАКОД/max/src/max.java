import java.util.ArrayList;
import java.util.Comparator;
import java.util.HashSet;
import java.util.Scanner;
public class max {
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
    }

     private static void checkMother(ArrayList<Integer> list, int sum){
        int brIndex = 0;
        for (int i = 0; i < list.size(); i++){
            if (list.get(i) > Math.round((double)sum/2)){
                break;
            }
            else{
                brIndex = i+1;
            }

        }


        for(int i = 0; i < brIndex; i++){
            for (int j = list.size()-1; j > 0; j--){
                if ((list.get(i) + list.get(j)) == sum){
                    System.out.println("Числа: " + list.get(i) + ", " + list.get(j));
                }
            }
        }
    }
}
