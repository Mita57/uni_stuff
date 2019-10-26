import java.util.Scanner;

public class Rabbit {
    public static void main(String[] args) {
        Scanner sca = new Scanner(System.in);
        System.out.println("Enter the amount of cells (2 to 1000)");
        int cellsAmount = Integer.parseInt(sca.nextLine());
        if (cellsAmount >= 2 && cellsAmount <= 1000) {
            System.out.println("Enter the cells characters: 'w' - swamp; '\"' - grass; '.' - empty cell). The first and the last cells are empty");
            String cellsInput = sca.nextLine();
            char[] cellsArray = cellsInput.toCharArray();
            int[] a = new int[cellsAmount];
            a[0] = 0;
            for (int i = 1; i < a.length; i++) {
                a[i] = -1;
            }
            for (int i = 1; i < a.length; i++) {
                if (cellsArray[i] == 'w') {
                    continue;
                }
                if (i < 3) {
                    a[i] = a[i - 1];
                }
                else if (i < 5)
                    a[i] = Math.max(a[i - 1], a[i - 3]);
                else {
                    a[i] = Math.max(Math.max(a[i - 1], a[i - 3]), a[i - 5]);
                }
                if (cellsArray[i] == '"') {
                    a[i]++;
                }
            }
            System.out.println(a[cellsAmount - 1]);
        }
        else {
            System.out.println("Incorrect input, the amount cells must be between 2 and 1000");
        }
    }
}
