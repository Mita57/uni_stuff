public class RedBlackTree<E extends Number> {
    private Node<E> head;

    public RedBlackTree(Node<E> head) {
        this.head = head;
    }

    private void rotateLeft(Node<E> root, Node<E> node) {
        Node<E> nodeRight = node.right;
        node.right = nodeRight.left;
        if (node.right != null) {
            node.right.parent = node;
        }
        nodeRight.parent = node.parent;
        if (node.parent == null) {
            root = nodeRight;
        } else {
            if (node == node.parent.left) {
                node.parent.left = nodeRight;
            } else {
                node.parent.right = nodeRight;
            }
        }
        node.right.left = node;
        node.parent = nodeRight;
    }

    private void rotateRight(Node<E> root, Node<E> node) {
        Node<E> nodeLeft = node.left;
        node.left = nodeLeft.right;
        if (node.left != null) {
            node.left.parent = node;
        }
        nodeLeft.parent = node.parent;
        if (node.parent == null) {
            root = nodeLeft;
        } else {
            if (node == node.parent.left) {
                node.parent.left = nodeLeft;
            } else {
                node.parent.right = nodeLeft;
            }
        }
        nodeLeft.right = node;
        node.parent = nodeLeft;
    }


    private void fixViolation(Node<E> root, Node<E> node) {
        Node<E> parent = null;
        Node<E> grandParent = null;
        while ((node != root) && (node.color != Color.BLACK) && (node.parent.color == Color.RED)) {
            parent = node.parent;
            grandParent = node.parent.parent;
            if (parent == grandParent.left) {
                Node<E> uncle = grandParent.right;
                if (uncle != null && uncle.color == Color.RED) {
                    grandParent.color = Color.RED;
                    parent.color = Color.BLACK;
                    uncle.color = Color.BLACK;
                    node = grandParent;
                } else {
                    if (node == parent.right) {
                        rotateLeft(root, parent);
                        node = parent;
                        parent = node.parent;
                    }
                    rotateRight(root, grandParent);
                    Color temp = parent.color;
                    parent.color = grandParent.color;
                    grandParent.color = temp;
                    node = parent;
                }
            } else {
                Node<E> uncle = grandParent.left;
                if (uncle != null && uncle.color == Color.RED) {
                    grandParent.color = Color.RED;
                    parent.color = Color.BLACK;
                    uncle.color = Color.BLACK;
                    node = grandParent;
                }
                else {
                    if(node == parent.left) {
                        rotateRight(root, parent);
                        node = parent;
                        parent = node.parent;
                    }
                    rotateLeft(root, grandParent);
                    Color temp = parent.color;
                    grandParent.color = parent.color;
                    parent.color = temp;
                    node = parent;
                }
            }
        }
        this.head.color = Color.BLACK;
    }

    private Node<E> BSTInsert(Node<E> root, Node<E> node) {
        if(root == null) {
            return node;
        }
        if(root.value.doubleValue() > node.value.doubleValue()) {
            root.left = BSTInsert(root.left, node);
            root.left.parent = root;
        }
        else {
            if(node.value.doubleValue() > root.value.doubleValue()) {
                root.right = BSTInsert(root.right, node);
                root.right.parent = root;
            }
        }
        return root;
    }

    private void insert(E value) {
        Node<E> node = new Node<E>(value);
        head = BSTInsert(head, node);
        fixViolation(head, node);
    }

    public void printTree(Node<E> node) {
        if (node != null) {
            System.out.print(node.value + ", ");
            printTree(node.left);
            printTree(node.right);
        }
    }

    public Node<E> findElement(Node<E> node, E value) {
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


    enum Color {RED, BLACK};

    static class Node<E> {
        E value;
        Color color;
        Node<E> left;
        Node<E> right;
        Node<E> parent;

        public Node(E value) {
            this.value = value;
            left = null;
            right = null;
            parent = null;
            this.color = Color.RED;
        }
    }


    public static void main(String[] args) {
        Node<Integer> meme = new Node<>(23);
        meme.left = new Node<Integer>(10);
        meme.right = new Node<Integer>(33);
        RedBlackTree<Integer> tree = new RedBlackTree<Integer>(meme);
        tree.insert(34);
        tree.printTree(tree.head);
    }


}