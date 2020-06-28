import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.List;
import java.util.Map;
import java.util.Scanner;

/**
 * TreeTest
 */
public class TreeTest {

    // private static int[][] graph;
    // private static List<int[]> graph2;
    private static Map<Integer,Integer> graph;
    private static boolean[] visited;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int node = Integer.parseInt(scanner.nextLine());
        int edge = Integer.parseInt(scanner.nextLine());
        // graph = new int[node + 1][edge + 1];
        // graph2 = new ArrayList<>();
        graph = new LinkedHashMap<>();
        visited = new boolean[node + 1];

        for (int i = 0; i < node; i++) {
            int[] connects = Arrays.stream(scanner.nextLine().split(" "))
            .mapToInt(x -> Integer.parseInt(x))
            .toArray();

            graph.putIfAbsent(connects[0], connects[1]);

            // graph[connects[0]][connects[1]] = 1;
        }

        int start = Integer.parseInt(scanner.nextLine());
        int end = Integer.parseInt(scanner.nextLine());

        System.out.print(start + " ");
        visited[start] = true;
        Dfs(start, end);

    }

    private static void Dfs(int start, int end) {

        if (start == end) {
            System.err.println();
            Print();
            return;
        } else {
            int current = graph.get(start);
            System.out.print(current + " ");
            visited[current] = true;
            Dfs(current, end);
        }
    }

    private static void Print() {
        
        for (int i = 1; i < visited.length; i++) {
            if (visited[i] == false) {
                System.err.print(i + " ");
            }
        }
    }
}