import java.util.*;
import java.util.concurrent.atomic.AtomicInteger;

/**
 * ConnectedAreasInMatrix
 */
public class ConnectedAreasInMatrix {

//     6. Connected Areas in a Matrix
// Let’s define a connected area in a matrix as an area of cells in which there is a path between every two cells.
// Write a program to find all connected areas in a matrix.
// On the console, print the total number of areas found, and on a separate line some info about each of the areas –
// its position (top-left corner) and size.
// Order the areas by size (in descending order) so that the largest area is printed first. If several areas have the same
// size, order them by their position, first by the row, then by the column of the top-left corner. So, if there are two
// connected areas with the same size, the one which is above and/or to the left of the other will be printed first.
// On the first line, you will get the number of rows.
// On the second line, you will get the number of columns.
// The rest of the input will be the actual matrix.

private static char[][] matrix;
private static List<int[]> areas;
private static StringBuilder output = new StringBuilder();
private static int areaCount = 0;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int r = Integer.parseInt(scanner.nextLine());
        int k = Integer.parseInt(scanner.nextLine());

        matrix = new char[r][k];

        for (int i = 0; i < r; i++) {
            matrix[i] = scanner.nextLine().toCharArray();
        }
        
        areas = new ArrayList<>();

        for (int row = 0; row < matrix.length; row++) {
            for (int col = 0; col < matrix[row].length; col++) {
                areas.add(new int[] {row, col, 0});
                FindAreas(row,col);
            }
        }
        
        
        AtomicInteger counter = new AtomicInteger(1);
        
        areas.stream()
        .sorted((f, s) -> Integer.compare(s[2], f[2]))
        .forEach(a -> {
            if (a[2] != 0) {
                areaCount += 1;
                output.append("Area #" + counter.getAndIncrement()
                + " at ("+ a[0] +", "+ a[1] +"), size: " + a[2])
                .append(System.lineSeparator());
            }
        });

        System.out.println("Total areas found: " + areaCount);
        System.out.println(output.toString());
        scanner.close();
    }

    private static void FindAreas(int row, int col) {
        if (InBounds(row,col) || IsNotTraversable(row, col)) {
            return;
        }

        matrix[row][col] = 'V';

        areas.get(areas.size() - 1)[2]++;

        FindAreas(row + 1, col);
        FindAreas(row, col + 1);
        FindAreas(row - 1, col);
        FindAreas(row, col - 1);
    }

    private static boolean IsNotTraversable(int row, int col) {
        return matrix[row][col] == 'V' || matrix[row][col] == '*';
    }

    private static boolean InBounds(int row, int col) {
        return row < 0 || row == matrix.length || col < 0 || col == matrix[row].length;
    } 
}