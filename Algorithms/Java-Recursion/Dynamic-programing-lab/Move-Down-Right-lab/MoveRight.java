import java.text.Format;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

/**
 * MoveRight
 */
public class MoveRight {

    private static int[][] matrix;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int rows = Integer.parseInt(scanner.nextLine());
        int cols = Integer.parseInt(scanner.nextLine());
        matrix = new int[rows][cols];
        
        for (int i = 0; i < rows; i++) {
            matrix[i] = Arrays.stream(scanner.nextLine().split(" "))
            .mapToInt(x -> Integer.parseInt(x))
            .toArray();
        }

        int[][] dp = new int[rows][cols];

        dp[0][0] = matrix[0][0];

        for (int s = 1; s < cols; s++) {
            dp[0][s] = matrix[0][s] + dp[0][s - 1];
        }

        for (int g = 1; g < rows; g++) {
            dp[g][0] = matrix[g][0] + dp[g - 1][0];
        }

        for (int j = 1; j < rows; j++) {
            for (int z = 1; z < cols; z++) {
                dp[j][z] = Math.max(dp[j - 1][z] + matrix[j][z], dp[j][z - 1] + matrix[j][z]);
            }
        }

        int dispRow = rows - 1;
        int dispCol = cols - 1;

        List<String> path = new ArrayList<>();

        path.add(OutPuts(dispRow,dispCol));

        while (dispRow > 0 || dispCol > 0 ) {

            int top = -1;
            int left = -1;

                if (dispRow - 1 < 0) {
                    
                } else {
                    top = dp[dispRow - 1][dispCol];
                }
                if (dispCol - 1 < 0) {
                    
                } else {
                    left = dp[dispRow][dispCol - 1];
                }

            if (top > left) {
                dispRow -= 1;
            } else {
                dispCol -= 1;
            }

            path.add(OutPuts(dispRow, dispCol));

        }


        for (int d = path.size() - 1; d >= 0; d--) {
            System.out.print(path.get(d) + " ");
        }


        // System.out.println();
        
        // for (int[] ff : dp) {
        //     for (int fs : ff) {
        //         System.out.print(fs + " ");
        //     }
        //     System.out.println();
        // }
    }

    private static String OutPuts(int row, int col) {
        return "[" + row + ", " + col + "]";
    }
}