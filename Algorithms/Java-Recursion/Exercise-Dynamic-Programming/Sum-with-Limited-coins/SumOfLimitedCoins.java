import java.util.Arrays;
import java.util.Scanner;

public class Main {

//     5. Sum with Limited Amount of Coins
// In the previous problem, the coins represented values, not actual coins (we could take as many coins of a certain
// value as we wanted). In this problem, we’ll regard the coins as actual coins, e.g. 1, 2, 5 are three coins and we can
// use each of them only once. We can, of course, have more coins of a given value, e.g. – 1, 1, 2, 2, 10.
// The task is the same - find the number of ways we can combine the coins to obtain a certain sum S.

    private static long[][] memory;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] coins = Arrays.stream(scanner.nextLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        int sum = Integer.parseInt(scanner.nextLine());

        int comb = Findcombinations(coins, sum);

        System.out.println(comb);
    }

    private static int Findcombinations(int[] coins, int sum) {
        int[][] maxCount = new int[coins.length + 1][sum + 1];
        for (int i = 0; i <= coins.length; i++) {
            maxCount[i][0] = 1;
        }

        for (int i = 1; i <= coins.length; i++) {
            for (int j = sum; j >= 0; j--) {
                if (coins[i - 1] <= j && maxCount[i - 1][j - coins[i - 1]] != 0) {
                    maxCount[i][j]++;
                } else {
                    maxCount[i][j] = maxCount[i - 1][j];
                }
            }
        }

        int count = 0;
        for (int i = 0; i <= coins.length; i++) {
            if (maxCount[i][sum] != 0) {
                count++;
            }
        }

        return count;
    }


}

