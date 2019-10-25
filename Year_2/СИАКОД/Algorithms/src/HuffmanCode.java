import java.util.*;

class MyComparator implements Comparator<HuffmanNode> {
    public int compare(HuffmanNode x, HuffmanNode y)
    {
        return x.data - y.data;
    }
}

class Huffman {
    private static void printCode(HuffmanNode root, String s)
    {
        if (root.left == null && root.right == null && Character.isLetter(root.c)) {

            // c is the character in the node
            System.out.println(root.c + ":" + s);
            root.code = s;
            HuffmanNode.allElements.add(root);
            return;
        }
        printCode(root.left, s + "0");
        printCode(root.right, s + "1");
    }

    // main function
    public static void main(String[] args)
    {
        Scanner sca = new Scanner(System.in);
        System.out.println("Enter your string, plizki");
        String userInput = sca.nextLine();
        char[] inputCharAr = userInput.toCharArray();
        HashSet<Character> charsSet = new HashSet<Character>();
        for(char X: inputCharAr){
            charsSet.add(X); //filling the charSet with unique chars
        }
        ArrayList<Character> charsList = new ArrayList<Character>(charsSet); // making an arraylist coz there's no get() method in hashsets
        char [] charArray = new char[charsSet.size()];
        for (int i = 0; i < charArray.length; i++){
            charArray[i] = charsList.get(i);
        }
        // number of characters.
        int[] charFreq = new int[charsSet.size()];
        for (int i = 0; i < charArray.length; i++){
            for (int j = 0; j < inputCharAr.length; j++){
                if(charArray[i] == inputCharAr[j]){
                    charFreq[i]++;
                }
            }
        }

        PriorityQueue<HuffmanNode> q = new PriorityQueue<HuffmanNode>(charFreq.length, new MyComparator());

        for (int i = 0; i < charFreq.length; i++){
            HuffmanNode hn = new HuffmanNode();

            hn.c = charArray[i];
            hn.data = charFreq[i];

            hn.left = null;
            hn.right = null;

            q.add(hn);
        }

        // create a root node
        HuffmanNode root = null;

        while (q.size() > 1) {

            // first min extract.
            HuffmanNode x = q.peek();
            q.poll();

            // second min extarct.
            HuffmanNode y = q.peek();
            q.poll();

            // new node f which is equal
            HuffmanNode f = new HuffmanNode();

            // to the sum of the frequency of the two nodes assigning values to the f node.
            f.data = x.data + y.data;
            f.c = '-';

            // first extracted node as left child.
            f.left = x;

            // second extracted node as the right child.
            f.right = y;

            // marking the f node as the root node.
            root = f;

            // add this node to the priority-queue.
            q.add(f);
        }

        printCode(root, "");
        //the final string output:
        System.out.println("______________________________________________________________ \n");
        StringBuilder finalCode = new StringBuilder();
        for(int i = 0 ; i < inputCharAr.length; i++){
            for(int j = 0; j < charArray.length; j++){
                if(inputCharAr[i] == inputCharAr[j]){
                    finalCode.append(HuffmanNode.allElements.get(j).code);
                }
            }
        }
        System.out.println("Amount of chars: " + charArray.length +  "; length of the string: "  + finalCode.length());
        System.out.println(finalCode);
    }
}