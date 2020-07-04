import java.util.*;
/**
 * RedCutting
 */
public class RedCutting {

//     4. Rod Cutting
// Find the best way to cut up a rod with a specified length. You are also given to prices of all possible lengths starting
// from 0.
    private static int[] bestPrices;
    private static int[] prices;
    private static int[] previos;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        prices = Arrays.stream(scanner.nextLine().split(" "))
        .mapToInt(x -> Integer.parseInt(x))
        .toArray();

        int length = Integer.parseInt(scanner.nextLine());
        bestPrices = new int[length + 1];
        previos = new int[length + 1];

        int maxProfit = CutRope(length);
        System.out.println(maxProfit);
        Print(length);
    }

    private static void Print(int n) {
        while (n - previos[n] != 0) {
            System.out.print(previos[n] + " ");
            n = n - previos[n];
        }
        System.out.println(previos[n]);
    }

    private static int CutRope(int length) {
        if (length == 0) {
            return 0;
        }

        if (bestPrices[length] != 0) {
            return bestPrices[length];
        }

        int currentBest = bestPrices[length];
        for (int i = 1; i <= length; i++) {
            int localMax = Math.max(currentBest, prices[i] + CutRope(length - i));
            if (localMax > currentBest) {
                currentBest = localMax;
                bestPrices[length] = currentBest;
                previos[length] = i;
            }
        }
        
        return bestPrices[length];
    }
}