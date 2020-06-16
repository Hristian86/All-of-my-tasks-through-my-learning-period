import java.util.*;
/**
 * TheMatrix
 */
public class TheMatrix {

//     12. The Matrix
// You are given a matrix (2D array) of lowercase alphanumeric characters (a-z, 0-9), a starting position – defined by a
// start row startRow and a start column startCol – and a filling symbol fillChar. Let’s call the symbol originally
// at startRow and startCol the startChar. Write a program, which, starting from the symbol at startRow and
// startCol, changes to fillChar every symbol in the matrix which:
//  is equal to startChar AND
//  can be reached from startChar by going up (row – 1), down (row + 1), left (col – 1) and right (col
// + 1) and “stepping” ONLY on symbols equal startChar
// So, you basically start from startRow and startCol and can move either by changing the row OR column (not
// both at once, i.e. you can’t go diagonally) by 1, and can only go to positions which have the startChar written on
// them. Once you find all those positions, you change them to fillChar.
// In other words, you need to implement something like the Fill tool in MS Paint, but for a 2D char array instead of a
// bitmap.
// Input
// On the first line, two integers will be entered – the number R of rows and number C of columns.
// On each of the next R lines, C characters separated by single spaces will be entered – the symbols of the R th row of
// the matrix, starting from the 0 th column and ending at the C-1 column.
// On the next line, a single character – the fillChar – will be entered.
// On the last line, two integers – startRow and startCol – separated by a single space, will be entered.
// Output
// The output should consist of R lines, each consisting of exactly C characters, NOT SEPARATED by spaces,
// representing the matrix after the fill operation has been finished.
// Constraints
// 0 &lt; R, C &lt; 20
// 0 &lt;= startRow &lt; R
// 0 &lt;= startCol &lt; C
// All symbols in the input matrix will be lowercase alphanumerics (a-z, 0-9). The fillChar will also be
// alphanumeric and lowercase.
// The total running time of your program should be no more than 0.1s
// The total memory allowed for use by your program is 5MB

    private static char[][] matrix;
    private static char reaplChar;
    private static int[] replaceParametars;
    private static char toBeReplaced;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int[] matrixLength = Arrays.stream(scanner.nextLine().split(" "))
        .mapToInt(x -> Integer.parseInt(x))
        .toArray();
        
        matrix = new char[matrixLength[0]][matrixLength[1]];

        for (int i = 0; i < matrix.length; i++) {
            char[] chars = scanner.nextLine().toCharArray();
            int y = 0;
            for (int s = 0; s < chars.length; s++) {
                if (chars[s] != ' ') {
                    matrix[i][y] = chars[s];
                    y++;
                }
            }
        }

        reaplChar = scanner.nextLine().charAt(0);
        replaceParametars = Arrays.stream(scanner.nextLine().split(" "))
        .mapToInt(x -> Integer.parseInt(x))
        .toArray();
        toBeReplaced = matrix[replaceParametars[0]][replaceParametars[1]];

        Initialize(replaceParametars[0],replaceParametars[1],toBeReplaced);

        for (char[] child : matrix) {
            for (int i = 0; i < child.length; i++) {
                System.out.print(child[i]);
            }
            System.out.println();
        }
    }

    private static void Initialize(int row, int col, char areaChar) {
        if (IsInBounds(row,col) || matrix[row][col] == reaplChar || areaChar != matrix[row][col]) {
            return;    
        }

        matrix[row][col] = reaplChar;

        Initialize(row - 1, col, areaChar); // up
        Initialize(row, col + 1, areaChar); // right
        Initialize(row + 1, col, areaChar); // down
        Initialize(row, col - 1, areaChar); // left
    }

    private static boolean IsInBounds(int row,int col) {
        return row >= matrix.length || row < 0 || col >= matrix[row].length || col < 0;
    }
}