import java.util.Arrays;
import java.util.Scanner;

public class ConnectingCables {

//     7. Connecting Cables
// We are in a rectangular room. On opposite sides of the room there are sets of n cables (n &lt; 1000). The cables are
// indexed from 1 to n.
// On each side of the room there is a permutation of the cables, e.g. on one side we always have ordered {1, 2, 3, 4, 5}
// and on the other side we have some permutation {5, 1, 3, 4, 2}. We are trying to connect each cable from one side
// with the corresponding cable on the other side – connect 1 with 1, 2 with 2, etc. Cables are straight and should not
// overlap!
// The task is to find the maximum number of pairs we can connect given the restrictions above.

    private static long[][] memory;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int [] cables = Arrays.stream(scanner.nextLine().split(" ")).mapToInt((Integer::parseInt))
                .toArray();

        int [] destination = new int [cables.length + 1];

        for (int i = 0; i < destination.length ; i++) {
            destination[i] = i + 1;
        }
         int dp [][] = new int [cables.length +1][cables.length + 1];

        for (int i = 1; i <= cables.length ; i++) {
            for (int j = 1; j <= cables.length ; j++) {
                if (destination[i-1] == cables[j-1]){
                    dp[i][j] = dp[i -1][j-1] + 1;
                } else {
                    dp[i][j] = Math.max(dp[i-1][j],dp[i][j-1]);
                }
            }
        }
        System.out.println("Maximum pairs connected: " + dp[cables.length][cables.length]);
    }
}
