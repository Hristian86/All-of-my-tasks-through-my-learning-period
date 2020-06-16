import java.util.*;
/**
 * CyclesIngraphNewIdea
 */
public class CyclesIngraphNewIdea {

//     3. Cycles in a Graph
// Write a program to check whether an undirected graph is acyclic or holds any cycles. The input ends with &quot;End&quot; line.

    private static Set<String> unique;
    private static String line;
    private static List<String[]> graph;
    private static String result;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        unique = new HashSet<>();
        graph = new ArrayList<>();
        while (true) {
            line = scanner.nextLine();
            if (line.equals("End")) {
                break;
            }

            String[] cycle = line.split("-");

            if (unique.contains(cycle[1])) {
                result = "Acyclic: No";
            }

            unique.add(cycle[0]);
            unique.add(cycle[1]);

            graph.add(cycle);
        }
        
        if (result != null) {
            System.out.println(result);
        } else {
            System.out.println("Acyclic: Yes");
        }
    }
}