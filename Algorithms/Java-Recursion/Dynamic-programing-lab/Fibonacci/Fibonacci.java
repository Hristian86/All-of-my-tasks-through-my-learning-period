import java.util.*;

/**
 * Fibonacci
 */
public class Fibonacci {
    
//     1. Fibonacci
// Write a dynamic programming solution for finding n th Fibonacci member.
    private static long[] memo;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int fibNumber = Integer.parseInt(scanner.nextLine());
        memo = new long[fibNumber + 1];

        long fib = CalFib(fibNumber);
        System.out.println(fib);
    }

    private static long CalFib(int fibNumber) {

        if (fibNumber <= 2) {
            return 1;
        }

        if (memo[fibNumber] != 0) {
            return memo[fibNumber];
        }

        return memo[fibNumber] = CalFib(fibNumber - 1) + CalFib(fibNumber - 2);
    }
}