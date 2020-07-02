import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
/**
 * LongestSub
 */
public class LongestSub {

//     2. Longest Increasing Subsequence
// Let’s have a sequence of numbers S = {a 1 , a 2 , … a n }. An increasing subsequence is a sequence of numbers within S
// where each number is larger than the previous. We do not change the relative positions of the numbers, e.g. we do
// not move smaller elements to the left to obtain longer sequences. If several sequences with equal length exist, find
// the left-most of them

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int[] sequence = Arrays.stream(scanner.nextLine().split(" "))
        .mapToInt(x -> Integer.parseInt(x))
        .toArray();
        int[] previos = new int[sequence.length];
        int[] lenght = new int[sequence.length];

        Arrays.fill(previos, -1);
        int maxLength = 0;
        int maxIndex = -1;
        
        for (int i = 0; i < sequence.length; i++) {
            int current = sequence[i];
            int bestLength = 1;
            int bestIndex = -1;

            for (int j = 0; j <= i; j++) {
                if (sequence[j] < current && lenght[j] + 1 > bestLength) {
                    bestLength = lenght[j] + 1;
                    bestIndex = j;
                }
            }
            previos[i] = bestIndex;
            lenght[i] = bestLength;
            if (bestLength > maxLength) {
                maxLength = bestLength;
                maxIndex = i;
            }
        }
        List<Integer> LIS = new ArrayList<>();
        int index = maxIndex;

        while (index != -1) {
            LIS.add(sequence[index]);
            index = previos[index];
        }

        for (int f = LIS.size() - 1; f >= 0 ; f--) {
            System.out.print(LIS.get(f) + " ");
        }
    }
}