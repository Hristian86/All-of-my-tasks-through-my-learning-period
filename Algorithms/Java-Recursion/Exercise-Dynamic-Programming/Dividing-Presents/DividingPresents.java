import java.util.Arrays;
import java.util.Scanner;

public class DividingPresents {

//     3. Dividing Presents
// Alan and Bob are twins. For their birthday they received some presents and now they need to split them amongst
// themselves. The goal is to minimize the difference between the values of the presents received by the two
// brothers, i.e. to divide the presents as equally as possible.
// Assume the presents have values represented by positive integer numbers and that presents cannot be split in half
// (a present can only go to one brother or the other).
// Find the minimal difference that can be obtained and print which presents each brother has received (you may only
// print the presents for one of them, it is obvious that the rest will go to the other brother). In the examples below
// Alan always takes a value less than or equal to Bob, but you may do it the other way around.

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] values = Arrays.stream(scanner.nextLine().split(" "))
                .mapToInt(Integer::parseInt).toArray();


        int totalSum = Arrays.stream(values).sum();

        int[] sums = new int[totalSum + 1];
        for (int i = 1; i < sums.length; i++) {
            sums[i] = -1;
        }

        for (int presIndex = 0; presIndex < values.length; presIndex++) {

            for (int prevSumIndex = totalSum - values[presIndex]; prevSumIndex >= 0; prevSumIndex--) {

                int presentValue = values[presIndex];

                if (sums[prevSumIndex] != -1 &&
                        sums[prevSumIndex + presentValue] == -1) {

                    sums[prevSumIndex + presentValue] = presIndex;
                }
            }
        }
        int half = totalSum / 2;

        for (int i = half; i >= 0; i--) {
            if (sums[i] == -1) {
                continue;
            }

            int toPrint = totalSum - i - i;
            System.out.println("Difference: " + toPrint);
            System.out.println("Alan:" + i + " " + "Bob:" + (totalSum - i));
            System.out.print("Alan takes: ");
            while (i!=0){
                System.out.print(values[sums[i]] + " ");
                i -= values[sums[i]];
            }
            System.out.println();
            System.out.println("Bob takes the rest.");
        }
    }
}