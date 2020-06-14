import java.awt.Container;
import java.util.*;

/**
 * AreasInMatrix
 */
public class AreasInMatrix {

//     2. Areas in Matrix
// We are given a matrix of letters of size N * M. Two cells are neighbor if they share a common wall. Write a program
// to find the connected areas of neighbor cells holding the same letter. Display the total number of areas and
// the number of areas for each alphabetical letter (ordered by alphabetical order).
// On the first line is given the number of rows.

    private static Map<String,Integer> counter = new LinkedHashMap<>();
    private static String[][] matrix;
    private static Queue<String> que;
    private static List<int[]> position;
    private static Map<String,Integer> area;
    private static String currentChar = " ";

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int row = Integer.parseInt(scanner.nextLine());

        matrix = new String[row][];

        for (int i = 0; i < matrix.length; i++) {
            matrix[i] = scanner.nextLine().split("");
        }

        currentChar = matrix[0][0];
        que = new ArrayDeque<>();

        que.offer(matrix[0][0]);

        position = new ArrayList<>();
        area = new TreeMap<>();

        position.add(new int[]{0,0});        
        int index = 0;

        while (!que.isEmpty()) {
            String curr = que.poll();
            int[] posts = position.get(index);
            Initialize(posts[0],posts[1],curr);
            if (!area.containsKey(currentChar)) {
                area.put(currentChar, 1);
            } else {
                int sum = area.get(currentChar);
                area.put(currentChar, sum + 1);
            }
            counter.remove(currentChar);
            index++;
        }

        System.out.println();
        for (int i = 0; i < matrix.length; i++) {
            System.err.println(String.join("", matrix[i]));
        }
        int sums = 0;
        for (int child : area.values()) {
            sums += child;
        }
        
        System.out.println("Areas: " + sums);
        for (String child : area.keySet()) {
            String displa = String.format("Letter " + "\'" + child + "\'" + " -> " + area.get(child));
            System.out.println(displa);
        }
    }

    private static void Initialize(int row, int col, String letter) {

        if (IsOutOfBounds(row,col) || matrix[row][col] == "&") {
            return;
        }

        currentChar = matrix[row][col];
        boolean isEqual = letter.equals(currentChar);
        if (!isEqual) {
            if (!counter.containsKey(matrix[row][col])) {
                counter.put(matrix[row][col], 1);
                que.offer(matrix[row][col]);
                int[] exactPosition = new int[]{row,col};
                position.add(exactPosition);
            } else {   
                que.offer(matrix[row][col]);
                int[] exactPosition = new int[]{row,col};
                position.add(exactPosition);
            }

            return;
        }
        
        matrix[row][col] = "&";

        Initialize(row - 1, col,letter); // up
        Initialize(row + 1, col, letter); // down
        Initialize(row, col - 1, letter); // left
        Initialize(row, col + 1, letter); // right

    }

    private static boolean IsOutOfBounds(int row, int col) {
        return row >= matrix.length || row < 0 || col >= matrix[row].length || col < 0;
    }
}