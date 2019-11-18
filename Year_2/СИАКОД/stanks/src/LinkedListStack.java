import java.util.LinkedList;

public class LinkedListStack <E> {
    private int size;
    private StackNode<E> head;

    public void pop(){
        this.head = head.getNext();
        this.size--;
    }

    public void push(StackNode<E> node) {
        StackNode temp = this.head;
        this.head = node;
        this.head.next = temp;
        size++;
    }

    public E peek() {
        return this.head.value;
    }

    public void print() {
        StackNode node = this.head;
        while (node != null) {
            System.out.println(node.value);
            node = node.next;
        }
    }



    public int getSize(){
        return this.size;
    }

    public LinkedListStack(StackNode head) {
        this.head = head;
        int size = 0;
        StackNode node = head;
        while(node != null){
            node = node.getNext();
            size++;
        }
    }

    private static class StackNode<E>{
        E value;
        StackNode next;

        public StackNode(E value, StackNode next) {
            this.value = value;
            this.next = next;
        }

        public E getValue(){
            return this.value;
        }

        public void setValue(E value){
            this.value = value;
        }

        public StackNode<E> getNext() {
            return next;
        }
        public void setNext(StackNode next){
            this.next = next;
        }


    }
}
