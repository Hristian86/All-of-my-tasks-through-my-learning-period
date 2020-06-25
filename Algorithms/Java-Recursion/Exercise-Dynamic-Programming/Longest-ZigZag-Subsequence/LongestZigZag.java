import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

/**
 * LongestZigZag
 */
public class LongestZigZag {

//     2. Longest Zigzag Subsequence
// A zigzag sequence is one that alternately increases and decreases. More formally, such a sequence has to comply
// with one of the two rules below:
// 1) Every even element is smaller than its neighbors and every odd element is larger than its neighbors, or
// 2) Every odd element is smaller than its neighbors and every even element is larger than its neighbors
// 1 3 2 is a zigzag sequence, but 1 2 3 is not. Any sequence of one or two elements is zig zag.
// Find the longest zigzag subsequence in a given sequence.

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int[] numbers = Arrays.stream(scanner.nextLine().split(" "))
        .mapToInt(x -> Integer.parseInt(x))
        .toArray();
        List<Integer> odds = new ArrayList<>();

        for (int i = 0; i < numbers.length; i++) {
            // for (int s = 0; s < 3; s++) {
                if (i % 2 == 1) { // odd number
                    if (numbers[i] <= numbers[i - 1]) {
                        if (i >= numbers.length - 1) {
                            if (numbers[i] <= numbers[i - 1]) {
                                odds.add(numbers[i]);
                            }
                        } else {
                            if (numbers[i] <= numbers[i + 1]) {
                                
                                odds.add(numbers[i]);

                            }
                        }
                    }
                } else {
                    if (i == 0) {
                        if (numbers[i] >= numbers[i + 1]) {
                            odds.add(numbers[i]);
                        }
                    } else {
                        if (numbers[i] >= numbers[i - 1]) {
                            if (i >= numbers.length - 1) {
                                odds.add(numbers[i]);
                            } else {
                                if (numbers[i] >= numbers[i + 1]) {
                                    
                                    odds.add(numbers[i]);
    
                                }
                            }
                        }
                    }
                }
            // }
        }

        for (var f : odds) {
            System.out.print(f + " ");
        }

    }
}