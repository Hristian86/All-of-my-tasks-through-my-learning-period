import java.util.*;
/**
 * four
 */
public class four {

    private static int[] lenght;
    // private static Map<Integer,Integer> chooseCoins = new TreeMap<>();
    // private static List<Integer> coins;
    // private static Integer sum = 0;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        lenght = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(x -> Integer.parseInt(x)).toArray();
        int flask = Integer.parseInt(scanner.nextLine());
        int[] coins = new int[flask];
        int sum = 0;
        
        for (int i = 1; i <= flask; i++) {
            // coins.add(i);
            coins[i - 1] = i;
        }

        Map<Integer,Integer> usedCoins = chooseCoins(coins,flask);

        for (var f : usedCoins.keySet()) {
            System.out.println(f + " -> " + usedCoins.get(f));
        }

        // GetCoins(flask);
    }

    private static Map<Integer,Integer> chooseCoins(int[] coins, int targetSum) {
        Map<Integer,Integer> usedCointses = new TreeMap<>();
        
        int index = coins.length - 1;

        while (targetSum != 0) {
            int coinsToTake = targetSum / coins[index];

            if (coinsToTake != 0) {
                usedCointses.put(coins[index],coinsToTake);
            }

            int sums = targetSum / coins[index];
            if (sums > 1) {
                
            }
            index--;
        }

        return usedCointses;

    }



    // private static void GetCoins(int targetSum) {
    //     int sum = 0;
    //     int currentSum = 0;
    //     int cointIndex = 0;
    //     while (currentSum != targetSum && cointIndex < coins.size()) {   
    //         int currentCoint = coins.get(cointIndex);
    //         int remainder = targetSum - currentCoint;
    //         int numberOfCoints = remainder - currentSum;
    //         if (currentSum + currentCoint <= targetSum) {
    //             chooseCoins.put(currentCoint, numberOfCoints);
    //             currentSum += numberOfCoints * currentCoint;
    //         }
    //         cointIndex++;
    //     }
    // }
}