import java.util.*;

/**
 * TaskTree
 */
public class TaskTree {

    private static int[][] graph;
    private static List<Integer> display = new ArrayList<>();

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int node = Integer.parseInt(scanner.nextLine());
        int edge = Integer.parseInt(scanner.nextLine());

        graph = new int[node + 1][edge + 1];

        for (int i = 0; i < edge; i++) {
            int[] connects = Arrays.stream(scanner.nextLine().split(" "))
            .mapToInt(x -> Integer.parseInt(x))
            .toArray();

            graph[connects[0]][connects[1]] = 1;
        }

        int start = Integer.parseInt(scanner.nextLine());
        int end = Integer.parseInt(scanner.nextLine());

        boolean[] visited = new boolean[node + 1];

        Deque<Integer> que = new ArrayDeque<>();
        que.offer(start);

        while (!que.isEmpty()) {
            int temp = que.poll();
            visited[temp] = true;
            for (int q = 0; q < graph[temp].length; q++) {
                if (graph[temp][q] != 0 && !visited[q]) {
                    display.add(q);
                    que.offer(q);
                }
            }
        }

        System.out.print(start + " ");
        for (var f : display) {
            System.out.print(f + " ");
        }
        

        System.out.println();
        for (int g = 1; g < visited.length; g++) {
            if (!visited[g]) {
                System.out.print(g + " ");
            }
        }

    }
}