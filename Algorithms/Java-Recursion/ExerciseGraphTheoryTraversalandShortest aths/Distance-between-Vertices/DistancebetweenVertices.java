import java.util.*;

/**
 * DistancebetweenVertices
 */
public class DistancebetweenVertices {

//     1. Distance between Vertices
// We are given a directed graph. We are given also a set of pairs of vertices. Find the shortest distance between each
// pair of vertices or -1 if there is no path connecting them.
// On the first line, you will get N, the number of vertices in the graph. On the second line, you will get P, the number
// of pairs between which to find the shortest distance.
// On the next N lines will be the edges of the graph and on the next P lines, the pairs.

    private static int[][] graph;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int nodes = Integer.parseInt(scanner.nextLine());
        int pairs = Integer.parseInt(scanner.nextLine());

        graph = new int[nodes + 1][];

        for (int i = 0; i < nodes; i++) {
            
            String[] edges = scanner.nextLine()
            .split(":");
        if (edges.length == 1) {
            graph[i] = new int[1];
        } else {
                graph[i] = Arrays.stream(edges[1]
                .split("\\s+"))
                .mapToInt(x -> Integer.parseInt(x))
                .toArray();
            }
        }

        while (pairs-- > 0) {
            int[] relations = Arrays.stream(scanner.nextLine().split("-"))
            .mapToInt(x -> Integer.parseInt(x))
            .toArray();

            int source = relations[0];
            int destination = relations[1];
            
            System.out.printf("{%d, %d} -> ",source, destination);
            
            int[] path = new int[graph.length];
            try {
                Bfs(graph,source,destination,path);
            } catch (Exception e) {
                System.out.println(e.getMessage());
            }

            System.out.println(path[source]);
            
        }
    }

    private static void Bfs(int[][] graph, int source, int destination, int[] path) {
        Deque<Integer> que = new ArrayDeque<>();

        que.offer(source);

        boolean[] visited = new boolean[graph.length + 1];
        visited[source] = true;

        while (!que.isEmpty()) {
            int node = que.poll();
            if (node == destination) {
                return;
            }
            path[source]++;
            for (int i = 0; i < graph[node].length; i++) {
                int child = graph[node][i];
                if (!visited[child]) {
                    path[child] = node;
                    visited[child] = true;
                    que.offer(child);
                }
            }
        }

        path[source] = -1;
    }
}