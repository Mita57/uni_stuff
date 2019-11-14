import java.util.LinkedList;

public class LinkedListStack <E>{
    int size;
    StackNode head;

    public void pop(){

    }

    public void push(){

    }

    public int getSize(){
        return this.size;
    }

    public LinkedListStack(StackNode head){
        this.head = head;
        int size = 0;
        StackNode node = head;
        while(node != null){
            node  = node.getNext();
            size++;
        }
    }





    private static class StackNode<E>{
        E value;
        StackNode next;

        public E getValue(){
            return this.value;
        }

        public StackNode getNext() {
            return next;
        }


    }
}
