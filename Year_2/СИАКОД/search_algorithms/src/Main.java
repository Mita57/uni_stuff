import java.time.Duration;
import java.time.Instant;

public class Main {
    public static void main(String[] args){
        int[] sizes = {1000, 2000, 4000, 8000, 16000};
        for(int i = 0; i < sizes.length; i++){
            System.out.println("Amount of elements: " + sizes[i]);
            Search search = new Search(sizes[i]);
            Instant start = Instant.now();
            search.linearSearch();
            Instant finish = Instant.now();
            long timeElapsed = Duration.between(start, finish).toMillis();
            System.out.println("Linear search: " + timeElapsed);
            start = Instant.now();
            search.binarySearch();
            finish = Instant.now();
            timeElapsed = Duration.between(start, finish).toMillis();
            System.out.println("Binary search " + timeElapsed);
            start = Instant.now();
            search.interpolationalSearch();
            finish = Instant.now();
            timeElapsed = Duration.between(start, finish).toMillis();
            System.out.println("Interpolation search " + timeElapsed);
        }
    }
}
