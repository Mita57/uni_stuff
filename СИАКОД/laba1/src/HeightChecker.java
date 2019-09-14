import java.util.ArrayList;
import java.util.Scanner;

public class HeightChecker {

    public static void main(String[] args) {
        System.out.println("Введите количество работяг с завода");
        Scanner sca = new Scanner(System.in);
        int[] cock = new int[Integer.parseInt(sca.nextLine())];
        for (int i = 0; i < cock.length; i++) {
            cock[i] = (Integer.parseInt(sca.nextLine()));
        }
        int temp = 0;
        int count = 0;
        for (int i = 0; i < cock.length; i++) {
            boolean lul = false;
            for (int j = 1; j < cock.length; j++) {
                if (cock[j - 1] > cock[j]) {
                    lul = true;
                    temp = cock[j - 1];
                    cock[j - 1] = cock[j];
                    cock[j] = temp;
                }
            }
            if(!lul){
                break;
            }
            count++;
        }
        System.out.println(++count);
    }
}
