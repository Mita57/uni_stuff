import java.util.ArrayList;
import java.util.Scanner;


public class duplicates {
    public static void main(String[] args){
        System.out.println("Введите длину массива");
        Scanner sca = new Scanner(System.in);
        int [] cock = new int[Integer.parseInt(sca.nextLine())];
        for (int i = 0; i< cock.length;i++){
            System.out.println("Введите элемент " + i);
            cock[i] = Integer.parseInt(sca.nextLine());
        }
        ArrayList<Integer> unique = new ArrayList<Integer>();

        for(int x: cock){
            if(!unique.contains(x)){
                unique.add(x);
            }
            else {
                System.out.println(x + " is a duplicate");
            }
        }

    }
}
