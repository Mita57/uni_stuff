import java.util.ArrayList;
import java.util.Stack;

public class AVL<E extends Number> {
    private AVLNode<E> head;
    private int height;

    public AVLNode<E> getHead() {
        return this.head;
    }

    public void setHead(AVLNode<E> value) {
        this.head = value;
    }

    private int height(AVLNode<E> node) {
        if (node == null) {
            return 0;
        }
        return node.height;
    }

    private int balance(AVLNode<E> node) {
        if (node == null) {
            return 0;
        }
        return (height(node.left) - height(node.right));
    }


    public AVL(AVLNode<E> head) {
        this.head = head;
    }

    private AVLNode<E> rightRotate(AVLNode<E> y) {
        AVLNode<E> x = y.left;
        AVLNode<E> T2 = x.right;
        x.right = y;
        y.left = T2;
        y.height = Math.max(height(y.left), height(y.right)) + 1;
        x.height = Math.max(height(x.left), height(x.right)) + 1;
        return x;
    }

    private AVLNode<E> leftRotate(AVLNode<E> x) {
        AVLNode<E> y = x.right;
        AVLNode<E> T2 = y.left;
        y.left = x;
        x.right = T2;
        x.height = Math.max(height(x.left), height(x.right)) + 1;
        y.height = Math.max(height(y.left), height(y.right)) + 1;
        return y;
    }

    public AVLNode<E> insert(AVLNode<E> node, E value) {
        if (node == null) {
            return (new AVLNode<E>(value));
        }
        if (value.doubleValue() < node.value.doubleValue()) {
            node.left = insert(node.left, value);
        } else {
            if (value.doubleValue() > node.value.doubleValue()) {
                node.right = insert(node.right, value);
            } else {
                return node;
            }
        }
        node.height = 1 + Math.max(height(node.left), height(node.right));
        int balance = balance(node);
        if (balance > 1 && value.doubleValue() < node.left.value.doubleValue()) {
            return rightRotate(node);
        }
        if (balance < -1 && value.doubleValue() > node.right.value.doubleValue()) {
            return leftRotate(node);
        }
        if (balance > 1 && value.doubleValue() > node.left.value.doubleValue()) {
            node.left = leftRotate(node.left);
            return rightRotate(node);
        }
        if (balance < -1 && value.doubleValue() < node.right.value.doubleValue()) {
            node.right = rightRotate(node.right);
            return leftRotate(node);
        }
        return node;
    }

    public AVLNode<E> findElement(AVLNode<E> node, E value) {
        if (value.doubleValue() < node.value.doubleValue()) {
            findElement(node.left, value);
        } else {
            if (value.doubleValue() > node.value.doubleValue()) {
                findElement(node.right, value);
            } else {
                return node;
            }
        }
        return null;
    }

    public void printTree(AVLNode<E> node) {
        if (node != null) {
            System.out.print(node.value + ", ");
            printTree(node.left);
            printTree(node.right);
        }
    }

    private int elementsAmount = 0;
    private double elementsSum = 0;
    private ArrayList<E> elements = new ArrayList<>();

    private void preOrder(AVLNode<E> node) {
        if (node != null) {
            elementsSum += node.value.doubleValue();
            elementsAmount++;
            elements.add(node.value);
            preOrder(node.left);
            preOrder(node.right);
        }
    }

    public double standartDeviation() {
        double avg = elementsSum / elementsAmount;
        double sum = 0;
        for (E X : elements) {
            sum += (X.doubleValue() - avg) * (X.doubleValue() - avg);
        }
        return Math.sqrt(sum / elementsAmount);
    }

    public void postOrderTraverse() {
        AVLNode<E> node = this.head;
        Stack<AVLNode<E>> s1 = new Stack<AVLNode<E>>();
        Stack<AVLNode<E>> s2 = new Stack<AVLNode<E>>();
        s1.push(node);
        while (!s1.isEmpty()) {
            AVLNode<E> temp = s1.pop();
            s2.push(temp);
            if (temp.left != null) {
                s1.push(temp.left);
            }
            if (temp.right != null) {
                s1.push(temp.right);
            }
        }
        System.out.println("Postorder Traversal: ");
        while (!s2.isEmpty()) {
            System.out.print(s2.pop());
        }
    }


    static class AVLNode<E extends Number> {
        private AVLNode<E> left;
        private AVLNode<E> right;
        private int height;
        private E value;

        public AVLNode<E> getLeft() {
            return this.left;
        }

        public int getHeight() {
            return this.height;
        }


        public E getValue() {
            return this.value;
        }

        public void setValue(E value) {
            this.value = value;
        }

        public AVLNode(E value) {
            this.value = value;
            this.height = 1;
        }

    }


}

