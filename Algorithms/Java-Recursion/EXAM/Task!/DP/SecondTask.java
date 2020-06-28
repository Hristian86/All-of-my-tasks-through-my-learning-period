import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

/**
 * SecondTask
 */
public class SecondTask {

    private static int[] numbers;
    private static List<Integer> counter;
    private static List<Integer> DP;

    public static void main(String[] args) {
        numbers = new int[] {1,2,3,4,5,6,7,8,9,10};
        int coints = 10;
        counter = new ArrayList<>();
        DP= new ArrayList<>();

        Calculate(coints,0,0);
    }

    private static void Calculate(int coints,int index,int start) {
        
        if (index == numbers.length - 1 / 2) {
            return;
        }

        for (int i = start; i < numbers.length / 2; i++) {

            int sum = counter.stream().mapToInt(Integer::intValue).sum();
            
            if (sum == coints) {
                for (var f : counter) {
                    if (counter.size() > 2 && counter.size() < (numbers.length - 1) / 2) {   
                        if (f % 2 == 0) {
                            int total = f / 2;
                            System.out.print(total + " " + total);
                        } else {
                            System.out.print(f + " ");
                        }
                    }
                }
                counter.clear();
                return;
            } else {
                counter.add(numbers[i]);
                Calculate(coints, index + 1, start + 1);
            }
        }
    }
}