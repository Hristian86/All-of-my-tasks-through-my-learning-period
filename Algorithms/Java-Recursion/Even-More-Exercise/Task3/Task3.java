import java.util.ArrayDeque;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Deque;
import java.util.List;
import java.util.Scanner;

import javax.sql.RowSetEvent;

/**
 * Task3
 */
public class Task3 {


    
    // public static void main(String[] args) {
    //     Scanner scanner = new Scanner(System.in);

    //     int n = scanner.nextInt();
    //     int k = scanner.nextInt();

    //     int[][] graph = new int[n + 1][n + 1];

    //     for (int i = 0; i < k; i++) {
    //         graph[scanner.nextInt()][scanner.nextInt()] = 1;
    //     }

    //     int source = scanner.nextInt();
    //     int destination = scanner.nextInt();

    //     boolean[] visited = new boolean[n + 1];

    //     ArrayList<Integer> path = new ArrayList<>();

    //     Deque<Integer> queue = new ArrayDeque<>();

    //     queue.offer(source);

    //     boolean isNotFound = true;

    //     while (!queue.isEmpty()) {
    //         int node = queue.poll();
    //         visited[node] = true;
    //         if (isNotFound) {
    //             path.add(node);
    //             isNotFound = node != destination;
    //         }
    //         for (int i = 0; i < graph[node].length; i++) {
    //             if (graph[node][i] != 0 && !visited[i]) {
    //                 visited[i] = true;
    //                 queue.offer(i);
    //             }
    //         }
    //     }

    //     StringBuilder out = new StringBuilder();

    //     for (Integer node : path) {
    //         out.append(node).append(" ");
    //     }

    //     out.append(System.lineSeparator());

    //     for (int i = 1; i < visited.length; i++) {
    //         if (!visited[i]) {
    //             out.append(i).append(" ");
    //         }
    //     }

    //     System.out.println(out.toString().trim());
    // }



    private static int[][] graph;
    private static ArrayList<Integer> visited;
    private static boolean cycle = true;
    private static boolean[] visitedNums;
    private static StringBuilder build = new StringBuilder();

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int node = Integer.parseInt(scanner.nextLine());
        int edge = Integer.parseInt(scanner.nextLine());
        graph = new int[node + 1][node + 1];
        visited = new ArrayList<>();
        visitedNums = new boolean[node + 1];

        for (int i = 0; i < edge; i++) {
            int[] temp = Arrays.stream(scanner.nextLine().split(" "))
            .mapToInt(x -> Integer.parseInt(x))
            .toArray();
            int row = temp[0];
            int col = temp[1];

            // graph[scanner.nextInt()][scanner.nextInt()] = 1;

            graph[row][col] = 1;
        }

        int start = Integer.parseInt(scanner.nextLine().trim());
        int end = Integer.parseInt(scanner.nextLine().trim());

        // for (var ff : graph) {
        //     for (var fs : ff) {
        //         System.out.print(fs + " ");
        //     }
        //     System.out.println();
        // }

        // Bfs(start,end,edge,node);

        Deque<Integer> que = new ArrayDeque<>();
        que.offer(start);
        
        while (!que.isEmpty()) {
            
            int current = que.poll();
            visitedNums[current] = true;
            if (cycle) {
                visited.add(current);
                cycle = current != end;
            }

            for (int s = 0; s < graph[current].length; s++) {
                if (graph[current][s] != 0 && !visitedNums[s]) {
                    visitedNums[s] = true;
                    que.offer(s);
                }
            }
        }
        
        for (var f : visited) {
            build.append(f).append(" ");
        }

        build.append(System.lineSeparator());
        
        for (int r = 1; r < visitedNums.length; r++) {
            if (visitedNums[r] == false) {
                build.append(r).append(" ");
            }
        }

        System.out.println(build.toString().trim());
        
    }

    // private static void Bfs(int start, int end, int edge, int node) {
    //     Deque<Integer> que = new ArrayDeque<>();
    //     que.offer(start);
        
    //     while (!que.isEmpty()) {
            
    //         int current = que.poll();
    //         visitedNums[current] = true;
    //         if (cycle) {
    //             visited.add(current);
    //             cycle = current != end;
    //         }

    //         for (int s = 0; s < graph[current].length; s++) {
    //             if (graph[current][s] != 0 && !visitedNums[s]) {
    //                 visitedNums[s] = true;
    //                 que.offer(s);
    //             }
    //         }
    //     }
    // }
}