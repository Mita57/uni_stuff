import java.util.concurrent.ThreadLocalRandom;
import java.util.Scanner;

class ClosestPoints {
    private int[][] points;

    int[][] kClosest(int[][] points, int K) {
        this.points = points; //making the array dimensions the same
        sort(0, points.length - 1, K);
        return points;
    }

    private void sort(int i, int j, int K) {
        if (i >= j) return;
        int k = ThreadLocalRandom.current().nextInt(i, j);
        swap(i, k);

        int mid = separate(i, j);
        int leftLength = mid - i + 1;
        if (K < leftLength)
            sort(i, mid - 1, K);
        else if (K > leftLength)
            sort(mid + 1, j, K - leftLength);
    }

    private int separate(int i, int j) {
        int oi = i;
        double part = distance(i);
        i++;

        while (true) {
            while (i < j && distance(i) < part)
                i++;
            while (i <= j && distance(j) > part)
                j--;
            if (i >= j){
                break;
            }
            swap(i, j);
        }
        swap(oi, j);
        return j;
    }

    private double distance(int i) {
        return Math.sqrt(points[i][0] * points[i][0] + points[i][1] * points[i][1]);
    }

    private void swap(int i, int j) {
        int t0 = points[i][0], t1 = points[i][1];
        points[i][0] = points[j][0];
        points[i][1] = points[j][1];
        points[j][0] = t0;
        points[j][1] = t1;
    }

}

class ClosestPointsTestDrive{
    public static void main(String[] args){
        System.out.println("Enter the amount of points on the plane");
        Scanner sca = new Scanner(System.in);
        int pointAmount = Integer.parseInt(sca.nextLine());
        System.out.println("Enter the points divided by a comma");
        int[][] thisPoint = new int[pointAmount][2];
        for(int i = 0; i < pointAmount; i ++){
            String input = sca.nextLine();
            String[] inputAr = input.split(",");
            thisPoint[i][0] = Integer.parseInt(inputAr[0]);
            thisPoint[i][1] = Integer.parseInt(inputAr[1]);
        }
        System.out.println("Enter the amount of points to be found");
        int k = Integer.parseInt(sca.nextLine());
        ClosestPoints CP = new ClosestPoints();
        int[][] end = CP.kClosest(thisPoint, k);
        System.out.println("Here are (is) the dot(s)");
        for(int i = 0; i < k; i++){
            System.out.println(end[i][0] +", " + end[i][1]);
        }
    }
}