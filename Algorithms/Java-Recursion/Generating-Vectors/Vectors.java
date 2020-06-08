import java.util.Scanner;

import javax.sql.StatementEventListener;

/**
 * Vectors
 */
public class Vectors {

	//Generate all n-bit vectors of zeroes and ones in lexicographic order.	

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int number = Integer.parseInt(scanner.nextLine());
        // int number = 3;

        Integer[] memory = new Integer[number];
        FillVector(memory,0);
    }

    private static void FillVector(Integer[] memory,int index) {
        if (index >= memory.length) {
            Print(memory);
            return;
        }

        for(int i = 0;i <=1; i++) {
            memory[index] = i;
            FillVector(memory, index + 1);
        }
    }

    private static void Print(Integer[] memory) {
        for (Integer num : memory) {
            System.out.print(num);
        }
        System.out.println();
    }
}