import java.util.Arrays;
import java.util.Scanner;

/**
 * task1
 */
public class task1 {
    private static int[] numbers;
    private static int[] exit;
    private static boolean[] visited;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        numbers = Arrays.stream(scanner.nextLine().split(" "))
        .mapToInt(x -> Integer.parseInt(x))
        .toArray();

        int n = Integer.parseInt(scanner.nextLine());
        exit = new int[n];
        visited = new boolean[numbers.length];

        Variations(0,0,n);
    }

    private static void Variations(int start, int index,int n) {
        if (index >= n) {
            for (var ff : exit) {
                System.out.print(ff + " ");
            }
            System.out.println();
            return;
        } else {
            for (int i = 0; i < numbers.length; i++) {
                if (!visited[i]) {
                    visited[i] = true;   
                    exit[index] = numbers[i];
                    Variations(i, index + 1, n);
                    visited[i] = false;
                }
            }
        }
    }
}