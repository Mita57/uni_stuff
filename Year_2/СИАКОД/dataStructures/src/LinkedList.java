import java.util.Collection;
import java.util.Iterator;
import java.util.List;

public class LinkedList <E> implements Iterable<E> {


    private int size;
    private LinkedListNode head;

    public int getSize(){
        return this.size;
    }
    public LinkedListNode getHead(){
        return this.head;
    }

    public LinkedList(){
    }

    public LinkedList(LinkedListNode elem){
        LinkedListNode node = elem;
        while (node != null){
            node = node.getNext();
            this.size++;
        }
        this.head = elem;
    }


    public void push(LinkedListNode value){
        this.size++;
        this.head = value;
    }

    public void insert(E value, int index) throws OuttaRangeException{
        if(index > this.size){
            throw  new OuttaRangeException();
        }
        this.size++;
        LinkedListNode node = this.head;
        for (int i = 0; i < index; i++){
            node = node.getNext();
        }
        LinkedListNode newElem = new LinkedListNode(value, index, node);
        node.next = newElem;
    }

    public void remove(int index){
        LinkedListNode node = this.head;
        for(int i = 0; i < index + 1; i++){
            node = node.getNext();
        }
        node.next = node.getNext().getNext();
    }

    public E getByIndex(int index){
        LinkedListNode node = this.head;
        for(int i = 0; i < index + 1; i++){
            node = node.getNext();
        }
        return (E) node.value;
    }








    public boolean contains(E compare){
        LinkedListNode node = this.head;
        for(int i = 0; i < this.size; i++){
            if(node.value == compare){
                return true;
            }
            node = node.getNext();
        }
        return false;
    }

    public void addLast(E newValue){
        this.size++;
        LinkedListNode node = this.head;
        for(int i = 0; i < this.size; i++){
            node = node.getNext();
        }
        LinkedListNode <E> newNode = new LinkedListNode(newValue, this.size, null);
        node.next = newNode;
    }

    public int indexOf(E compareValue){
        LinkedListNode node = this.head;
        for(int i = 0; i < this.size; i++){
            if(node.value == compareValue){
                return i;
            }
            node = node.getNext();
        }
        return -1;
    }

    public int lastIndexOf(E compareValue){
        LinkedListNode node = this.head;
        int index = -1;
        for(int i = 0; i < this.size; i++){
            if(node.value == compareValue){
                index= i;
            }
            node = node.getNext();
        }
        return index;
    }

    public void removeRange(int from, int to) throws OuttaRangeException{
        LinkedListNode fromNode = null;
        LinkedListNode toNode = null;
        LinkedListNode node = this.head;
        if(from > this.size){
            throw new OuttaRangeException();
        }
        for(int i = 0;i < this.size; i++){
            if(i == from){
                fromNode = node;
            }
            if(i == to){
                toNode = node;
                break;
            }
        }
        fromNode = toNode;
    }





    public LinkedList subList(int fromIndex, int toIndex){
        LinkedListNode head = this.head;
        LinkedListNode tail = null;
        for(int i = 0; i < toIndex;i++){
            head = head.next;
            if(i == toIndex){
                tail = head;
                tail.next = null;
            }
        }
        return new LinkedList(head);
    }

    public E Peek(){
        return (E) this.head.value;
    }



    //Iterator
    @Override
    public Iterator<E> iterator() {
        return new LinkedListNodeIterator<E>();
    }

//node ffs
    private static class LinkedListNode <E>{
        private E value;
        private int index;
        private LinkedListNode next;

        public void setValue(E value){
            this.value = value;
        }

        public E getValue(){
            return this.value;
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

        public LinkedListNode(E value, int index){
            this.value = value;
            this.index = index;
        }

        public LinkedListNode(E value, int index, LinkedListNode next){
            this.value = value;
            this.index = index;
            this.next = next;
        }



    }

    private static class LinkedListNodeIterator<E> implements Iterator<E>{

        LinkedListNode<E> current;
        @Override
        public boolean hasNext() {
            return current != null;
        }

        @Override
        public E next() {
            E data = current.getValue();
            current = current.getNext();
            return data;
        }
    }

}

class OuttaRangeException extends Exception{

}

