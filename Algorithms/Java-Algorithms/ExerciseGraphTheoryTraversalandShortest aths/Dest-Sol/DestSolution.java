import java.util.*;

/**
 * DestSolution
 */
public class DestSolution {

//     2. Areas in Matrix
// We are given a matrix of letters of size N * M. Two cells are neighbor if they share a common wall. Write a program
// to find the connected areas of neighbor cells holding the same letter. Display the total number of areas and
// the number of areas for each alphabetical letter (ordered by alphabetical order).
// On the first line is given the number of rows.
        
    public static class Edge {
        private int[] source;
        private int[] dest;
        
        public Edge(int sRow, int sCol) {
            this.source = new int[] {sRow, sCol};
        }

        public void SetDest(int dRow, int dCol) {
            this.dest = new int[] {dRow,dCol};
        }
    }

    private static char[][] matrix;
    private static List<Edge> graph = new ArrayList<>();
    private static boolean[][] visited;
    private static boolean[] visitedNode;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int row = Integer.parseInt(scanner.nextLine());

        matrix = new char[row][];
        visited = new boolean[row][];

        for (int i = 0; i < row; i++) {
            matrix[i] = scanner.nextLine().toCharArray();
            visited[i] = new boolean[matrix[i].length];
        }

        // for (var ch : matrix) {
        //     for (var child : ch) {
        //         System.out.print(child);
        //     }
        //     System.out.println();
        // }

        for (int i = 0; i < matrix.length; i++) {
            for (int s = 0; s < matrix[i].length; s++) {
                if (!visited[i][s]) {
                    Dfs(i,s,matrix[i][s]);
                }
            }
        }

        visitedNode = new boolean[graph.size()];

        Map<Character,Integer> areas = new TreeMap<>();

        for (int i = 0; i < graph.size(); i++) {
            if(!visitedNode[i]) {
                Edge edges = graph.get(i);
                char key = matrix[edges.source[0]][edges.source[1]];
                areas.putIfAbsent(key,0);
                areas.put(key, areas.get(key) + 1);
                Bfs(i);
            }
        }

        System.out.println("Areas: " + areas.values().stream().mapToInt(x -> x).sum());

        for (Map.Entry<Character, Integer> entry : areas.entrySet()) {
            System.out.println("Letter " + "\'" + entry.getKey() + "\'" + " -> " + entry.getValue());
        }
    }

    private static void Bfs(int source) {
        Deque<Integer> que = new ArrayDeque<>();
        que.offer(source);

        visitedNode[source] = true;

        while (!que.isEmpty()) {
            int node = que.poll();
            Edge edgi = graph.get(node);
            if (edgi.dest != null) {   
                visitedNode[node + 1] = true;
                que.offer(node + 1);
            }
        }
    }

    private static void Dfs(int row, int col, char areaSymbol) {
        // if (IsOutOfBounds(row,col) || visited[row][col] || matrix[row][col] != areaSymbol) {
        //     return;
        // }
        
        visited[row][col] = true;
        Edge edge = new Edge(row, col);
        graph.add(edge);
        

        if (!IsOutOfBounds(row, col + 1) && !visited[row][col + 1] && matrix[row][col + 1] == areaSymbol ) {
            graph.get(graph.size() - 1).SetDest(row, col + 1);
            Dfs(row, col + 1, areaSymbol);
        }
        
        if (!IsOutOfBounds(row, col - 1) && !visited[row][col - 1] && matrix[row][col - 1] == areaSymbol ) {
            graph.get(graph.size() - 1).SetDest(row, col - 1);
            Dfs(row, col - 1, areaSymbol);
        }

        if (!IsOutOfBounds(row + 1, col) && !visited[row + 1][col] && matrix[row + 1][col] == areaSymbol ) {
            graph.get(graph.size() - 1).SetDest(row + 1, col);
            Dfs(row + 1, col, areaSymbol);
        }

        if (!IsOutOfBounds(row - 1, col) && !visited[row - 1][col] && matrix[row - 1][col] == areaSymbol ) {
            graph.get(graph.size() - 1).SetDest(row - 1, col);
            Dfs(row - 1, col, areaSymbol);
        }
    }

    // private static boolean IsInBounds(int row, int col) {
    //     return !IsOutOfBounds(row, col);
    // }

    private static boolean IsOutOfBounds(int row, int col) {
        return row >= matrix.length || row < 0 || col >= matrix[row].length || col < 0;
    }
}