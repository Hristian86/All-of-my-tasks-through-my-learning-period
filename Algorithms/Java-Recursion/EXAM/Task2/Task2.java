import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Scanner;

/**
 * Task2
 */
public class Task2 {

    private static int[] numbers;
    private static Map<Integer,List<Integer>> graph;
    private static int[] exit;
    private static List<Integer> list;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        numbers = Arrays.stream(scanner.nextLine().split(" "))
        .mapToInt(x -> Integer.parseInt(x))
        .toArray();
        graph = new HashMap<>();

        int flasksSum = Integer.parseInt(scanner.nextLine());
        list = new ArrayList<>();

        Variations(numbers.length,flasksSum,0,1);
    }

    private static void Variations(int numbersSize, int flasksSum, int index, int start) {
        exit = new int[flasksSum];
        int sum = list.stream().mapToInt(x -> x).sum();
        if (sum == flasksSum) {
            for (var f : list) {
                System.out.print(f + " ");
            }
            list.clear();
        }
        if (index == flasksSum) {
            list.clear();
            return;
        }
        for (int i = start; i <= flasksSum; i++) {
            list.add(i);
            Variations(numbersSize, flasksSum, index + 1, i);
        }
    }
}