public class AVL {
    private AVLNode head;
    private int height;

    public AVLNode getHead() {
        return this.head;
    }

    public void setHead(AVLNode value) {
        this.head = value;
    }

    public int getHeight() {
        return this.height;
    }

    private void setHeight() {

    }

    public AVL(AVLNode head) {
        this.head = head;
        setHeight();
    }

    public addElement(AVLNode element) {

    }

    public Number findElement(Number value) {

    }

    public void printTree() {

    }



    class AVLNode<Number> {
        private AVLNode left;
        private int leftBalance;
        private int rightBalance;
        private AVLNode right;
        private Number value;

        public AVLNode getLeft() {
            return this.left;
        }

        public void setLeft(AVLNode node) {
            this.left = node;
        }

        public AVLNode getRight() {
            return this.right;
        }

        public void setRight(AVLNode node) {
            this.right = node;
        }

        public Number getValue() {
            return this.value;
        }

        public void setValue(Number value) {
            this.value = value;
        }

        public int getLeftBalance() {
            return this.leftBalance;
        }

        public int getRightBalance() {
            return this.rightBalance;
        }


        private void setLeftBalance() {
            int counter = 0;
            AVLNode node = head;
            while(node != null){
                counter++;
                node = node.getRight();
            }
        }

        private void setRightBalance() {

        }

        private int countBalance() {
            return this.rightBalance - this.leftBalance;
        }





        public AVLNode(AVLNode left, AVLNode right, Number value){
            this.left = left;
            this.right = right;
            this.value = value;
        }
    }

}

