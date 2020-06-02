import java.util.Scanner;

/**
 * ReverseArr
 */
public class ReverseArr {

    static int[] reversedArr;
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();
        String[] numArr = input.split(" ");
        int[] numbers = new int[numArr.length];
        reversedArr = new int[numArr.length];
        for (int i = 0; i < numArr.length; i++) {
            numbers[i] = Integer.parseInt(numArr[i]);
        }
        
        RecursiveArray(numbers, numbers.length - 1, 0);
        Print();
        scanner.close();
    }

    private static void Print() {
        for (int num : reversedArr) {
            System.out.print(num+" ");
        }
    }

    private static void RecursiveArray(int[] numbers, int index, int start) {
        if (index < 0) {
            return;    
        }

        RecursiveArray(numbers, index - 1, start + 1);
        reversedArr[start] = numbers[index];
    }
}