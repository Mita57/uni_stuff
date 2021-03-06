import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.PriorityQueue;

public class TaskScheduler {
    public int leastInterval(char[] tasks, int n) {
        int[] map = new int[26];
        for (char c: tasks)
            map[c - 'A']++;
        PriorityQueue<Integer> queue = new PriorityQueue <> (26, Collections.reverseOrder());
        for (int f: map){
            if (f > 0){
                queue.add(f);
            }
        }
        int time = 0;
        while (!queue.isEmpty()){
            int i = 0;
            List<Integer> temp = new ArrayList<>();
            while (i <= n) {
                if (!queue.isEmpty()){
                    if (queue.peek() > 1)
                        temp.add(queue.poll() - 1);
                    else
                        queue.poll();
                }
                time++;
                if (queue.isEmpty() && temp.size() == 0)
                    break;
                i++;
            }
            queue.clear();
            queue.addAll(temp);
        }
        return time;
    }
}

class TaskSchedulerTestDrive{
    public static void main(String[] args){
        TaskScheduler sch = new TaskScheduler();
        System.out.println(sch.leastInterval(new char[]{'A', 'A', 'A', 'B', 'B', 'B'}, 2));
    }
}
