import java.util.Scanner;

/**
 * LoopsToRecursion
 */
public class LoopsToRecursion {

//     2. Nested Loops To Recursion
// Write a program that simulates the execution of n nested loops from 1 to n which prints the values of all its iteration
// variables at any given time on a single line. Use recursion.
    private static int[] arr;
    private static int n;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        n = Integer.parseInt(scanner.nextLine());
        arr = new int[n];
        NestedLoops(0);
        scanner.close();
    }

    private static void NestedLoops(int Index) {
        if (Index == arr.length) {
            PrintArr();
        } else {
            for (int i = 1; i <= n; i++) {
                arr[Index] = i;
                NestedLoops(Index + 1);
            }
        }
    }

    private static void PrintArr() {
        for (int i = 0; i < arr.length; i++) {
            System.out.print(arr[i] + " ");
        }
        System.out.println();
    }
}