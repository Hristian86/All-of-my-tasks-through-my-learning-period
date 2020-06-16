import java.util.Arrays;
import java.util.*;
/**
 * BinarySearch
 */
public class BinarySearch {

//     1. Binary Search
// Implement an algorithm that finds the index of an element in a sorted array of integers in logarithmic time

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        // int[] numbers = Arrays.stream(scanner.nextLine().split(" "))
        // .map(x -> Integer.parseInt(x)).toArray();

        String[] input = scanner.nextLine().split(" ");
        int[] numbers = new int[input.length];

        for (int i = 0; i < input.length; i++) {
            numbers[i] = Integer.parseInt(input[i]);
        }
        
        int key = Integer.parseInt(scanner.nextLine());

        String result = BinarySearch(numbers,key, 0, numbers.length - 1);
        System.out.println(result);
    }

    private static String BinarySearch(int[] numbers, int key, int start, int end) {
        while (end >= start) {
            int mid = (start + end) / 2;
            if (numbers[mid] < key) {
                start = mid + 1;
            } else if(numbers[mid] > key) {
                end = mid - 1;
            } else {
                return String.valueOf(mid);
            }
        }
        return "Not found";
    }
}