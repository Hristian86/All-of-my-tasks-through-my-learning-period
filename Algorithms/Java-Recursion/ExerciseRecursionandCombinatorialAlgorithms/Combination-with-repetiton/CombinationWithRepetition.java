import java.util.Scanner;

/**
 * CombinationWithRepetition
 */
public class CombinationWithRepetition {

//     3. Combinations with Repetition
// Write a recursive program for generating and printing all combinations with duplicates of k elements from a set of n
// elements (k &lt;= n). In combinations, the order of elements doesn’t matter, therefore (1 2) and (2 1) are the same
// combination, meaning that once you print/obtain (1 2), (2 1) is no longer valid.
    private static int n;
    private static int[] numbers;    
    public static void main(String[] args) {
        
        Scanner scanner = new Scanner(System.in);
        n = Integer.parseInt(scanner.nextLine());
        int k = Integer.parseInt(scanner.nextLine());
        numbers = new int[k];
        Combination(1,0);
        scanner.close();
    }

    private static void Combination(int start, int index) {
        if (index == numbers.length) {
            Print();
        } else {   
            for (int i = start; i <= n; i++) {
                numbers[index] = i;
                Combination(i, index + 1);
            }
        }
    }

    private static void Print(){
        for (int i = 0; i < numbers.length; i++) {
            System.out.print(numbers[i] + " ");
        }
        System.out.println();
    }
}