import java.util.Arrays;
import java.util.Scanner;

/**
 * RecursiveArraySum
 */
public class RecursiveArraySum {

//     1. Recursive Array Sum
// Write a program that finds the sum of all elements in an integer array. Use recursion.
// Note: In practice this recursion should not be used here (instead use an iterative solution), this is just an exercise.

    public static void main(String[] args) {
        
        Scanner scanner = new Scanner(System.in);

        int[] numbers  = Arrays.stream(scanner.nextLine().split(" "))
                        .mapToInt(Integer::parseInt)
                        .toArray();

        // int[] numbers = new int[]{1,2,3,4};
        int num = RecursiveArr(numbers,0);
        System.out.print(num);
    }

    private static int RecursiveArr(int[] numbers,int index) {
        if (index >= numbers.length) {
            return 0;
        }
        return numbers[index] + RecursiveArr(numbers, index + 1);
    }
}