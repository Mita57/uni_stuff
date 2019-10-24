import java.util.Scanner;

public class HuffmanDecode{
    public static void main(String [] args){
        System.out.println("Enter the amount of letters and size of the string");
        Scanner sca = new Scanner(System.in);
        String [] kl= sca.nextLine().split(" ");
        int k = Integer.parseInt(kl[0]);//amount of chars
        int l = Integer.parseInt(kl[1]);//string length
        System.out.println("Enter the key and code values:");
        for (int i = 0; i < k; i++){
            String [] comb = sca.nextLine().split(":");
            HuffmanNode node = new HuffmanNode();
            node.c = comb[0].charAt(0);
            node.code = comb[1];
            HuffmanNode.allElements.add(node);
        }

    }
}