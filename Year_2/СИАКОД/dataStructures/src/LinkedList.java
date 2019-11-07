import java.util.Iterator;

public class LinkedList implements Iterable{


    private int size;
    private LinkedListNode head;

    public int getSize(){
        return this.size;
    }
    public LinkedListNode getHead(){
        return this.head;
    }

    public LinkedList(){
        this.size = 0;
        this.head = null;
    }

    public LinkedList(LinkedListNode elem){
        this.size = 1;
        this.head = elem;
    }

    @Override
    public Iterator iterator() {
        return new LinkedListNodeIterator();
    }


    private static class LinkedListNode{
        private Object value;
        private int index;
        private LinkedListNode next;

        public void setValue(Object value){
            this.value = value;
        }

        public Object getValue(){
            return  this.value;
        }

        public int getIndex(){
            return this.index;
        }

        public LinkedListNode getNext() {
            return next;
        }

        public void setNext(LinkedListNode next){
            this.next = next;
        }

        public LinkedListNode(Object value, int index){
            this.value = value;
            this.index = index;
        }


    }

    private static class LinkedListNodeIterator<Object> implements Iterator<Object>{

        LinkedListNode current;
        @Override
        public boolean hasNext() {
            return current != null;
        }

        @Override
        public Object next() {

        }
    }

}

