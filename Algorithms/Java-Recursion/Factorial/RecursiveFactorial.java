import java.util.Scanner;

/**
 * Recursive-Factorial
 */
public class RecursiveFactorial {

//     4. Recursive Factorial
// Write a program that finds the factorial of a given number. Use recursion.
// Note: In practice this recursion should not be used here (instead use an iterative solution), this is just an exercise.

    public static void main(String[] args) {
        // Scanner scanner = new Scanner(System.in);
        // int number = Integer.parseInt(scanner.nextLine());
        int number = 5;

        int sum = Factorial(number);
        System.out.print(sum);
    }

    private static int Factorial(int number) {
        if (number == 0) {
            return 1;
        }

        return number * Factorial(number - 1);
    }
}