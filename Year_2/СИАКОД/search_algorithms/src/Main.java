public class Main {
    public static void main(String[] args){
        int[] sizes = {1000, 2000, 4000, 8000, 16000};
        for(int i = 0; i < sizes.length; i++){
            System.out.println("Amount of elements: " + sizes[i]);
            Search search = new Search(sizes[i]);
            long timeElapsed;
            long start;
            long finish;
            start = System.nanoTime();
            finish = search.linearSearch();
            timeElapsed = finish - start;
            System.out.println("Linear search: " + timeElapsed);
            start = System.nanoTime();
            finish = search.binarySearch();
            timeElapsed = finish - start;
            System.out.println("Binary search " + timeElapsed);
            start = System.nanoTime();
            finish = search.interpolationalSearch();
            timeElapsed = finish - start;
            System.out.println("Interpolation search " + timeElapsed);
        }
    }
}
