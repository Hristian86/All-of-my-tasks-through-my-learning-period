import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;
import java.util.stream.Collectors;
import java.util.*;

/**
 * Cinema
 */
public class Cinema {

//     7. Cinema
// Write a program that prints all of the possible distributions of a group of friends in a cinema hall. On the first line
// you will be given all of the friend&#39;s names separated by comma and space. Until you receive the command
// &quot;generate&quot; you will be given some of those friend&#39;s names and a number of the place that they want to have.
// (format: &quot;{name} - {place}&quot;) So here comes the tricky part. Those friend&#39;s want only to sit on the place that
// they have chosen. They cannot sit on other places. For more clarification see the examples below.
// Output
// Print all the possible ways to distribute the friends having in mind that some of them want a particular place and
// they will sit there only. The order of the output does not matter.
// Constrains
//  The friends names and the number of the place will always be valid

    private static List<String> people;
    private static String[] combinations;
    private static String[] seats;
    private static boolean[] used;
    
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        people = Arrays.stream(scanner.nextLine().split(", "))
        .collect(Collectors.toList());

        seats = new String[people.size()];
        String line = scanner.nextLine();

        while (!line.equals("generate")) {
            

            String[] tokens = line.split(" - ");
            String name = tokens[0];
            int position = Integer.parseInt(tokens[1]) - 1;

            seats[position] = name;
            people.remove(name);

            line = scanner.nextLine();
        }

        combinations = new String[people.size()];
        used = new boolean[people.size()];

        Permute(0);
    }

    private static void Permute(int index) {
        if (index == combinations.length) {
            Print();
        } else {
                for (int i = 0; i < people.size(); i++) {
                    if (!used[i]) {
                        used[i] = true;
                            combinations[index] = people.get(i);
                            Permute(index + 1);
                            used[i] = false;
                        }
            }
        }
    }

    private static void Print() {
        int index = 0;
        StringBuilder str = new StringBuilder();
        for (int i = 0; i < seats.length; i++) {
            if (seats[i] != null) {
                str.append(seats[i] + " ");
            } else {
                str.append(combinations[index++] + " ");
            }
        }
        System.out.print(str.toString().trim());
        System.out.println();
    }
}