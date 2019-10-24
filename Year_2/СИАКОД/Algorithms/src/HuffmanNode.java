import java.util.ArrayList;

// node class is the basic structure
// of each node present in the Huffman - tree.
class HuffmanNode {

    int data;
    char c;
    String code;
    static ArrayList<HuffmanNode> allElements= new ArrayList<HuffmanNode>();

    HuffmanNode left;
    HuffmanNode right;

}