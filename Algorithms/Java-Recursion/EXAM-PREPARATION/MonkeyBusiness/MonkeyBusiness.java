import java.util.Arrays;
import java.util.Scanner;

/**
 * MonkeyBusiness
 */
public class MonkeyBusiness {

//     1.Monkey Business
// So nothing to do right? But how is that even possible. No matter what there is always something to be done and you
// never get bored doing the Monkey Business.
// You have found a number N and now you want to see in how many ways you can combine the numbers from 1 to N
// in such a way that by using addition or subtraction you will end up with zero as a result. Find the possible
// expressions print them on the console each on a new line then followed by the total number of solutions in the
// following format:
// • Total Solutions: {possibleSolutions}
// 1. Input
// • The input will come from the console on single line.
// 2. Output
// • The output is each expression on a new line followed by the total solutions see the examples below.
// 3. Constraints
// • The input will only be a single positive integer.
// • The input will be in the range [1…25]

    private static int[] combinations;
    private static int[] display;
    private static int solutions = 0;
    private static StringBuilder map = new StringBuilder();

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int input = Integer.parseInt(scanner.nextLine());
        // combinations = new int[input * 2 + 1];
        display = new int[input];
        // for (int s = 1; s <= input; s++) {
        //     combinations[s - 1] = s;
        //     combinations[s - 1 + input] = -s;
        // }
        Combi(input,1,0);
        map.append("Total Solutions: ").append(solutions);
        System.out.println(map.toString());
    }

    private static void Combi(int input, int start, int index) {
        
        if (index >= input) {
                Print();
        } else {
            for (int i = start; i <= input; i++) {
                display[index] = i;
                Combi(input, i + 1, index + 1);
                display[index] = -i;
                Combi(input, i + 1, index + 1);
            }
        }
    }

    private static void Print() {
        int sum = Arrays.stream(display).sum();
        if (sum == 0) {   
            solutions++;
            for (var ch : display) {
                String positiveNumbers = ch > 0 ? "+" + ch: String.valueOf(ch);
                map.append(positiveNumbers).append(" ");
            }
            map.append(System.lineSeparator());
        }
    }
}