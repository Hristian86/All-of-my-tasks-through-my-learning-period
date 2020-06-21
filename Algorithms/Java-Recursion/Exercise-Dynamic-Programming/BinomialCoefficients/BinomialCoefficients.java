import java.util.Scanner;

/**
 * BinomialCoefficients
 */
public class BinomialCoefficients {
    //         1. Binomial Coefficients
// Write a program that finds the binomial coefficient for given non-negative integers n and k. The coefficient can be
// found recursively by adding the two numbers above using the formula:

// However, this leads to calculating the same coefficient multiple times (a problem which also occurs when solving the
// Fibonacci problem recursively). Use memoization to improve performance.
// You can check your answers using the picture below (row and column indices start from 0):
    private static long[][] pascal;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());
        int k = Integer.parseInt(scanner.nextLine());
        pascal = new long[n + 1][k + 1];

        long result = Pascal(n,k);
        System.out.println(result);
    }

    private static long Pascal(int n, int k) {
        if (k == 0 || k == n) {
            return 1;
        }

        if (pascal[n][k] != 0) {
            return pascal[n][k];
        }

        return pascal[n][k] = Pascal(n - 1, k) + Pascal(n - 1, k - 1);
    }
}