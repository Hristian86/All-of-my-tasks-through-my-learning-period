import java.util.ArrayDeque;
import java.util.Comparator;
import java.util.Deque;
import java.util.Scanner;
import java.util.Stack;
import java.util.stream.Collectors;

import javax.lang.model.SourceVersion;

// import sun.jvm.hotspot.runtime.solaris_amd64.SolarisAMD64JavaThreadPDAccess;
// import sun.text.resources.cldr.ext.FormatData_ro_MD;

/**
 * TowerOfHanoi
 */
public class TowerOfHanoi {

//     4. Tower of Hanoi
// Your task is to solve the famous Tower of Hanoi puzzle using recursion.
// In this problem, you have three rods (let’s call them source, destination and spare). Initially, there are n disks, all
// placed on the source rod like in the picture below:
    // private static Stack<Integer> source = new Stack<>();
    private static Deque<Integer> source = new ArrayDeque<>();
    private static Deque<Integer> spare = new ArrayDeque<>();
    private static Deque<Integer> destination = new ArrayDeque<>();
    private static int steps = 1;
    private static StringBuilder out = new StringBuilder();

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int disk = Integer.parseInt(scanner.nextLine());

        for (int i = disk; i >= 1; i--) {
            source.push(i);
        }
        
        PrintRods();
        Solve(disk, source, destination, spare);
        System.out.println(out.toString());
        scanner.close();
    }

    private static void Solve(int disk, Deque<Integer> source, Deque<Integer> destination, Deque<Integer> spare) {
        if (disk == 1) {
            destination.push(source.pop());
            // System.out.println("Step #" + (steps++) + ": Moved disk");
            out.append("Step #")
            .append(steps++)
            .append(": Moved disk")
            .append(System.lineSeparator());
            PrintRods();
        } else {
            Solve(disk - 1,source, spare, destination);
            Solve(1, source, destination, spare);
            Solve(disk - 1, spare, destination, source);
        }
    }

    private static void PrintRods() {
        out.append(String.format("Source: %s%nDestination: %s%nSpare: %s%n",
         FormatRod(source), FormatRod(destination), FormatRod(spare) ))
         .append(System.lineSeparator());
    }

    private static String FormatRod(Deque<Integer> stack) {
        return stack.stream()
        .sorted(Comparator.reverseOrder())
        .map(String::valueOf)
        .collect(Collectors.joining(", "));
    }
}