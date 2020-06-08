import java.util.Scanner;

/**
 * RecDrawing
 */
public class RecDrawing {

//     2. Recursive Drawing
// Write a program that draws the figure below depending on n. Use recursion.

    public static void main(String[] args) {
        // Scanner scanner = new Scanner(System.in);
        // int number = Integer.parseInt(scanner.nextLine());
        int number = 5;
        
        Draw(number);
    }

    public static void Draw(int number){
        if (number == 0) {
            return;
        }
        for(int i = 0; i < number; i++) {
            System.out.print("*");
        }
        System.out.println();
        
        number--;
        Draw(number);
        number++;
        for(int i = 0; i < number; i++) {
            System.out.print("#");
        }
        System.out.println();
        // System.out.println("*".repeat(number));
    }
}