import java.util.*;

/**
 * RoadReconstructionNew
 */
public class RoadReconstructionNew {

    private static Map<Integer, List<Integer>> graph;
    private static Map<Integer, Boolean> visited;
    private static List<int[]> pairs;


    static Scanner scanner = new Scanner(System.in);


    public static void main(String[] args) {


        int maxNumber = Integer.parseInt(scanner.nextLine());    //maxNumber
        int row = Integer.parseInt(scanner.nextLine());       //row

        InitializeGraph(row);
        visited = new HashMap<>();
        for (int s = 0; s < row; s++) {
            visited.putIfAbsent(s, false);
        }

        for (int g = 0; g < row; g++) {   
            int cur = graph.get(g).get(0);
            int distance = CalculateShortestDistance(g,cur);
        }
        
        for (int vertex : graph.keySet()) {
            visited.put(vertex, false);
        }
        
        // InitializePairs(maxNumber);

        // for (int [] pair : pairs){

        //     System.out.println(String.format(
        //             "{%d, %d} -> %d", pair[0],pair[1],distance
        //     ));

        // }
    }

    private static void InitializePairs(int countOfPairs) {
        pairs = new ArrayList<>();

        for (int i = 0; i < countOfPairs; i++) {
            int[] pair = Arrays.stream(scanner.nextLine().split("-"))
                    .mapToInt(Integer::parseInt).toArray();
            pairs.add(pair);
        }

    }

    private static void InitializeGraph(int vertices) {

        graph = new HashMap<>();
        for (int i = 0; i < vertices; i++) {

            graph.put(i, new ArrayList<>());


                int[] asd = Arrays.stream(scanner.nextLine().split(" - "))
                        .mapToInt(Integer::parseInt).toArray();

                for (int e : asd) {
                    graph.get(i).add(e);
                }
        }
    }

    private static int CalculateShortestDistance(int source, int destination) {

        ArrayDeque<Integer> vertices = new ArrayDeque<>();
        vertices.offer(source);
        List<Integer> children;
        int distance = 1;

        System.out.println();

        var cur = graph.get(source).get(1);
        System.out.println(source + " - " + destination);
        CalculateShortestDistance(destination, cur);
            
        while (vertices.size() > 0) {
            children = new ArrayList<>();
            while (vertices.size() > 0) {
                int current = vertices.poll();

                // for (int child : graph.get(current)) {
                    // if (!visited.get(child)) {
                        // if (child == destination) {
                        //     return distance;
                        // }
                        // visited.put(child, true);
                        
                        // children.add(child);
                    // }
                // }
            }
            vertices = new ArrayDeque<>(children);
            distance++;
        }

        return -1;
    }
}