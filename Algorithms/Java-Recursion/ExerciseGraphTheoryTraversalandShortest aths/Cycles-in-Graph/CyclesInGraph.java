import java.util.*;

/**
 * CyclesInGraph
 */
public class CyclesInGraph {

//     3. Cycles in a Graph
// Write a program to check whether an undirected graph is acyclic or holds any cycles. The input ends with &quot;End&quot; line.

    private static Map<String,List<String>> graph = new HashMap<>();

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String line = scanner.nextLine();
        String source = null;
        while (!line.equals("End")) {

            String[] tokens = line.split("-");

            if (source == null) {
                source = tokens[0];
            }

            graph.putIfAbsent(tokens[0], new ArrayList());
            graph.get(tokens[0]).add(tokens[1]);

            line = scanner.nextLine();
        }

        Set<String> visited = new HashSet<>();
        Set<String> cycles = new HashSet<>();

        try {
            Dfs(source,visited,cycles);
            System.out.println("Acyclic: Yes");
        } catch (IllegalStateException e) {
            System.out.println(e.getMessage());
        }
    }

    private static void Dfs(String source,Set<String> visited,Set<String> cycles) {
        
        if (cycles.contains(source)) {
            throw new IllegalStateException("Acyclic: No");
        }

        if (visited.contains(source)) {
            return;
        }

        cycles.add(source);
        visited.add(source);

        for (String child : graph.get(source)) {
            if (!visited.contains(child)) {
                Dfs(child, visited, cycles);
            }
        }

        cycles.remove(source);
    }
}