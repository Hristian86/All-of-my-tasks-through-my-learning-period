import java.util.*;

/**
 * Test2
 */
public class Test2 {
    
    private static int[] numbers;
    private static List<Integer> counter;
    private static List<Integer> DP;

    public static void main(String[] args) {
        numbers = new int[] {1,2,3,4,5,6,7,8,9,10};
        int coints = 10;
        counter = new ArrayList<>();
        DP= new ArrayList<>();

        Calculate(1,0,coints);
    }

    private static void Calculate(int start, int index, int coints) {
        int sum = counter.stream().mapToInt(Integer::intValue).sum();
        if (sum == coints) {
            for (var f : counter) {
                System.out.print(f + " ");
            }
        }

        if (index == coints) {
            return;
        } else {
            for (int i = start; i < numbers.length / 2; i++) {
                counter.add(numbers[index]);
                Calculate(start + 1, index + 1, coints);
            }
        }
    }
}