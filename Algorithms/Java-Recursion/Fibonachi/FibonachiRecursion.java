import java.util.Scanner;

/**
 * Fibonachi
 */
public class FibonachiRecursion {

//     7. Recursive Fibonacci
// Each member of the Fibonacci sequence is calculated from the sum of the two previous members. The first two
// elements are 1, 1. Therefore the sequence goes as 1, 1, 2, 3, 5, 8, 13, 21, 34…

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int number = Integer.parseInt(scanner.nextLine());
        // int number = 5;

        System.out.print(Fibonachi(number));
    }

    private static long Fibonachi(int number) {
        if (number <= 1) {
            return 1;
        }

        return Fibonachi(number - 1) + Fibonachi(number - 2);
    }
}