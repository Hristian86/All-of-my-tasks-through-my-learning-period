import java.util.ArrayDeque;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Deque;
import java.util.HashMap;
import java.util.HashSet;
import java.util.List;
import java.util.Map;
import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;

/**
 * Molecules
 */
public class Molecules {

//     3. Molecules
// You are part of science team which is on an exploration mission in newly discovered planet inhabiting the goldilock
// zone of a distant star (insert random digits as name here).
// You have found a peace of tissue which consist of different molecules connected in order.
// The biology team want from you do develop a program which by given molecule as a source determines to which
// other molecules there is no way to transport energy. On the way to any other molecule you may have to pass
// through other molecules etc.
// Print on a new line separated by spaces print the numbers of molecules you cannot transport energy to from the
// start molecule. Print them in increasing order.
// Input
// The input will come from the console:
// • On the first line the number of molecules N
// • On the second line the number of connections between the molecules M
// • On each M line the data describing the connections:
// {fromMolecule} {toMolecule}
// • On the next line single integer the start molecule number
// Output
// • On the single output line print the molecules in increasing order to which there is no connection from start
// molecule.
// Constraints
// • All input lines will be valid integers you do not need to check that.
// • The range of the integers will be in the range [1…1000]
// • The molecules number will be numbers from one increasing for each molecule.

    private static Map<Integer,List<Integer>> graph;
    private static boolean[] visited;
    private static StringBuilder build = new StringBuilder();
    private static Set<Integer> set;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int maxNumber = Integer.parseInt(scanner.nextLine());
        int row = Integer.parseInt(scanner.nextLine());
        graph = new HashMap<>();
        visited = new boolean[row + 1];
        set = new TreeSet<>();

        visited[0] = true;

        for (int z = 1; z <= row; z++) {
            visited[z] = false;
        }
        
        for (int i = 1; i <= row; i++) {
            List<Integer> hoKnows = new ArrayList<>();
            int[] temp = Arrays.stream(scanner.nextLine().split(" "))
            .mapToInt(x -> Integer.parseInt(x))
            .toArray();

            if (temp[1] <= maxNumber) {
                
                if (graph.containsKey(temp[0])) {
                    List<Integer> x = graph.get(temp[0]);
                    x.add(temp[1]);
                    graph.put(temp[0], x);
                }
                
                hoKnows.add(temp[1]);
                graph.putIfAbsent(temp[0],hoKnows);
            }
        }

        int startIndex = Integer.parseInt(scanner.nextLine());
        
        List<Integer> value = graph.get(startIndex);

        TopologicalSort(startIndex, row, value.get(0));

        for (int k = 0; k < graph.size(); k++) {
            if (!visited[k]) {
                List<Integer> values = graph.get(startIndex);
                TopologicalSort(startIndex, row, values.get(0));
            }
        }

        for (int p = 1; p < visited.length; p++) {
            if (visited[p] == false && graph.get(p) != null) {
                
                    // System.out.print(p + " " + graph.get(p).get(0) + " ");
                    set.add(p);
                    set.add(graph.get(p).get(0));
                    // if (set.contains(graph.get(p).get(0))) {
                    //     build.append(p).append(" ").append(graph.get(p).get(0)).append(" ");
                    // }
            }
        }
        for (Integer s : set) {
            System.out.print(s + " ");
        }
        // System.out.println(build.toString());

    }

    private static void TopologicalSort(int startIndex, int row, int destination) {
        Deque<Integer> que = new ArrayDeque<>();
        que.offer(startIndex);
        List<Integer> children;

        while (!que.isEmpty()) {
            int index = que.poll();
            if (!visited[index]) {
                if (graph.get(index) == null) {
                    visited[index] = true;
                    return;
                } 
                
                    children = new ArrayList<>();
                    for (var child : graph.get(index)) {
                        children.add(child);
                    }
                    visited[index] = true;
                    que = new ArrayDeque<>(children);
                
            }
        }
    }
}