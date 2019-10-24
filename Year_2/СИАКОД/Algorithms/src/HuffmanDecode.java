import java.util.ArrayList;
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
        System.out.println("Enter the encoded string");
        char[] encodedStringAr = sca.nextLine().toCharArray();
        StringBuilder strB = new StringBuilder();
        ArrayList<String> codes = new ArrayList<String>(); //list of HuffmanNodes codes to use with the get() method
        for(int i = 0; i < k; i++){
            codes.add(HuffmanNode.allElements.get(i).code);
        }
        for (int i = 0; i < encodedStringAr.length; i++){
            strB.append(encodedStringAr[i]);
            if(codes.contains(strB.toString())){
                System.out.print(HuffmanNode.allElements.get(codes.indexOf(strB.toString())).c);
            }
        }

    }
}