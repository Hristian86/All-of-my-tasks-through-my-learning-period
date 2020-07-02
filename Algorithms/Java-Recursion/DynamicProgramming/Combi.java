import java.util.*;
/**
 * Combi
 */
public class Combi {
    private static int[] coins;
    private static List<List<Integer>> list;
    private static int targetSum;
    private static int[] exit;
    private static boolean[] visited;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        coins = Arrays.stream(scanner.nextLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();
        list = new ArrayList<>();
        targetSum = Integer.parseInt(scanner.nextLine());
        exit = new int[targetSum];
        visited = new boolean[targetSum + 1];
        
        Combi(0,0);
    }

    private static void Combi(int start, int index) {

        if (index == targetSum) {
            for (var ff : exit) {
                System.out.print(ff + " ");
            }
            System.out.println();
            return;
        }

        for (int i = start; i < coins.length; i++) {
            if (!visited[i]) {    
                visited[i] = true;
                exit[index] = coins[i];
                Combi(start + 1, index + 1);
                visited[i] = false;
            }
        }
    }
}