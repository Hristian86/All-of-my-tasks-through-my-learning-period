import java.util.*;

/**
 * DistanceSolution
 */
public class DistanceSolution {

    public static class Edge {
        private int[] source;
        private int[] dest;
        
        public Edge(int sRow, int sCol, int dRow, int dCol ) {
            this.source = new int[] {sRow, sCol};
            this.dest = new int[] {dRow,dCol};
        }
    }

    private static char[][] matrix;
    private static List<Edge> graph = new ArrayList<>();
    private static boolean[][] visited;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int row = Integer.parseInt(scanner.nextLine());

        matrix = new char[row][];
        visited = new boolean[row][];

        for (int i = 0; i < row; i++) {
            matrix[i] = scanner.nextLine().toCharArray();
            visited[i] = new boolean[matrix[i].length];
        }

        for (var ch : matrix) {
            for (var child : ch) {
                System.out.print(child);
            }
            System.out.println();
        }

        for (int i = 0; i < matrix.length; i++) {
            for (int s = 0; s < matrix[i].length; s++) {
                if (!visited[i][s]) {
                    Dfs(i,s,matrix[i][s]);
                }
            }
        }

        System.out.println();
    }

    private static void Dfs(int row, int col, char areaSymbol) {
        if (IsOutOfBounds(row,col) || visited[row][col] || matrix[row][col] != areaSymbol) {
            return;
        }
        
        visited[row][col] = true;

        if (!IsOutOfBounds(row, col + 1) && !visited[row][col + 1] && matrix[row][col + 1] == areaSymbol ) {
            graph.add(new Edge(row, col, row, col + 1));
            Dfs(row, col + 1, areaSymbol);
        }
        
        if (!IsOutOfBounds(row, col - 1) && !visited[row][col - 1] && matrix[row][col - 1] == areaSymbol ) {
            graph.add(new Edge(row, col, row, col - 1));
            Dfs(row, col - 1, areaSymbol);
        }

        if (!IsOutOfBounds(row + 1, col) && !visited[row + 1][col] && matrix[row + 1][col] == areaSymbol ) {
            graph.add(new Edge(row, col, row + 1, col));
            Dfs(row + 1, col, areaSymbol);
        }

        if (!IsOutOfBounds(row - 1, col) && !visited[row - 1][col] && matrix[row - 1][col] == areaSymbol ) {
            graph.add(new Edge(row, col, row - 1, col));
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