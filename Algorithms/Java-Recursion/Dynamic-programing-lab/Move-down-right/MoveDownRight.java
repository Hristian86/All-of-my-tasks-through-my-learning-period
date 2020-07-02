import java.util.Arrays;
import java.util.Scanner;

/**
 * MoveDownRight
 */
public class MoveDownRight {

//     3. Move Down/Right
// Given a matrix of N by M cells filled with positive integers, find the path from top left to bottom right with a highest
// sum of cells by moving only down or right.
    private static int[][] matrix;
    private static int[][] path;
    private static char[][] visiteds;
    private static int rows;
    private static int cols;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        rows = Integer.parseInt(scanner.nextLine());
        cols = Integer.parseInt(scanner.nextLine());

        matrix = new int[rows][cols];
        path = new int[rows][cols];
        visiteds = new char[rows][cols];

        for (int i = 0; i < matrix.length; i++) {
            int[] temp = Arrays.stream(scanner.nextLine().split(" "))
            .mapToInt(x -> Integer.parseInt(x)) 
            .toArray();

            matrix[i] = temp;
            path[i] = temp;
        }

        Initialize(0,0,' ');

        System.out.println();

        for (var ff : path) {
            for (var fs : ff) {
                System.out.print(fs + " ");
            }
            System.out.println();
        }
    }

    private static void Initialize(int row , int col, char visited) {
        int sumCol = 0;
        int sumRow = 0;
        if (IsOutOfBounds(row,col) || visiteds[row][col] == 'V') {
            return;
        }

        if (col + 1 >= cols || row + 1 >= rows) {
            return;
        } else {

            sumCol = matrix[row][col] + matrix[row][col + 1];
            sumRow = matrix[row][col] + matrix[row + 1][col];

            path[row + 1][col] = sumRow;
            path[row][col + 1] = sumCol;

        }

        visiteds[row][col] = 'V';

        Initialize(row, col + 1, visited);
        Initialize(row + 1, col, visited);
    }

    private static boolean IsOutOfBounds(int row , int col) {
        return row >= matrix.length && row < 0 && col >= matrix[row].length && col < 0;
    }
}