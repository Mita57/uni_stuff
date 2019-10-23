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
            int k = 0;
            int p = 0;
            while (k + 1 <= cellsArray.length - 1 && cellsArray.length <= 3) {
                if (cellsArray[k + 1] == '"') {
                    k++;
                    p++;
                } else if (cellsArray[k + 1] == '.') {
                    k++;
                } else if (cellsArray[k + 1] == 'w') {
                    p = -1;
                    break;
                }

            }
            while (k + 1 < cellsArray.length && cellsArray.length <= 5 && cellsArray.length > 3 || k + 3 <= cellsArray.length - 1 && cellsArray.length <= 5 && cellsArray.length > 3) {
                if (cellsArray[k + 1] == '"') {
                    k++;
                    p++;
                } else if (k + 3 <= cellsArray.length - 1 && cellsArray[k + 3] == '"') {
                    k += 3;
                    p++;
                } else if (k + 3 <= cellsArray.length - 1 && cellsArray[k + 3] == '.') {
                    k += 3;
                } else if (cellsArray[k + 1] == '.') {
                    k++;
                } else if (cellsArray[k + 1] == 'w') {
                    p = -1;
                    break;
                } else {
                    p = -1;
                    break;
                }

            }
            while (k + 1 < cellsArray.length && cellsArray.length > 5 || k + 3 <= cellsArray.length - 1 && cellsArray.length > 5 || k + 5 <= cellsArray.length - 1 && cellsArray.length > 5) {
                if (cellsArray[k + 1] == '"') {
                    k++;
                    p++;
                } else if (k + 3 <= cellsArray.length - 1 && cellsArray[k + 3] == '"') {
                    k += 3;
                    p++;
                } else if (k + 5 <= cellsArray.length - 1 && cellsArray[k + 5] == '"') {
                    k += 5;
                    p++;
                } else if (cellsArray[k + 1] == '.') {
                    k++;
                } else if (k + 3 <= cellsArray.length - 1 && cellsArray[k + 3] == '.') {
                    k += 3;
                } else if (k + 5 <= cellsArray.length - 1 && cellsArray[k + 5] == '.') {
                    k += 5;
                } else {
                    p = -1;
                    break;
                }
            }
            System.out.println(p);
        } else
            System.out.println("Incorrect input, the amount cells must be between 2 and 1000");
        System.out.println();
    }
}
