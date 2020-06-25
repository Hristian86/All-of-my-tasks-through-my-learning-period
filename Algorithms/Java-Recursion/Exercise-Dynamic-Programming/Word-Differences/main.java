import java.util.Arrays;
import java.util.Scanner;

public class Main {

//     6. Word Differences
// Write a program that finds all the differences in two strings with equal lengths. You have to determine the smallest
// set of deletions and insertions to make the first string equal to the second. Finally you have to print the count of
// that minimum insertions and deletions.
// Input
//  You will receive the two strings on separate lines
// Output
//  Print the minimum amount of deletions and insertions as described below

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        char[] first = scanner.nextLine().toCharArray();
        char[] second = scanner.nextLine().toCharArray();

          int[][] dp =  new int[first.length + 1][second.length + 1];

        for (int i = 0; i <= first.length; i++) {
            for (int j = 0; j <= second.length; j++) {
                if (i == 0) {
                    dp[i][j] = j;
                } else if (j == 0){
                    dp[i][j] = i;
                } else if (first[i - 1] == second[j -1]){
                    dp[i][j] = dp[i - 1][j - 1];
                }
                 else {
                     dp[i][j] = Math.min(dp[i - 1][j],dp[i][j - 1]) + 1;
                }
            }
        }
        System.out.println("Deletions and Insertions: " + dp[first.length][second.length]);

    }
}