import java.util.Arrays;
import java.util.Scanner;

public class Main {

//     4. Sum with Unlimited Amount of Coins
// We have a set of coins with predetermined values, e.g. 1, 2, 5, 10, 20, 50. Given a sum S, the task is to find how
// many combinations of coins will sum up to S. For each value, we can use an unlimited number of coins, e.g. we can
// use S coins of value 1 or S/2 coins of value 2 (if S is even), etc.

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int [] coins = Arrays.stream(scanner.nextLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        int targetSum = Integer.parseInt(scanner.nextLine());

        int[] dp = new int [targetSum + 1];
        dp[0] = 1;
        
        for (int i = 0; i < coins.length; i++) {
            for (int j = coins[i]; j <= targetSum ; j++) {
                dp[j] += dp[j - coins[i]];
            }
        }
        System.out.println(dp[targetSum]);
    }
}
