import java.util.Arrays;
import java.util.Scanner;

/**
 * TaskOne
 */
public class TaskOne {

    private static int[] variations;
    private static int[] exit;
    private static boolean[] visited;
    private static StringBuilder build = new StringBuilder();

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        variations = Arrays.stream(scanner.nextLine()
        .split(" ")).mapToInt(x -> Integer.parseInt(x))
        .toArray();

        int n = Integer.parseInt(scanner.nextLine());
        visited = new boolean[variations.length];
        exit = new int[n];

        Variations(0,0,n);
        
        System.out.println(build.toString());
    }

    private static void Variations(int start,int index,int n) {
        if (index >= variations.length - 1) {
            
            for (int s = 0; s < exit.length; s++) {
                if (s != exit.length - 1) {
                    build.append(exit[s]).append(" ");
                } else {
                    build.append(exit[s]);
                }
            }
            build.append(System.lineSeparator());

        } else {
            for (int i = 0; i < variations.length; i++) {
                if (!visited[i]) {
                    visited[i] = true;
                    exit[index] = variations[i];
                    Variations(i + 1, index + 1,n);
                    visited[i] = false;
                }
            }
        }
    }
}