// import java.util.*;
// /**
//  * DistanceTest
//  */
// public class DistanceTest {

// //     1. Distance between Vertices
// // We are given a directed graph. We are given also a set of pairs of vertices. Find the shortest distance between each
// // pair of vertices or -1 if there is no path connecting them.
// // On the first line, you will get N, the number of vertices in the graph. On the second line, you will get P, the number
// // of pairs between which to find the shortest distance.
// // On the next N lines will be the edges of the graph and on the next P lines, the pairs.
//     private static Map<Integer,List<Integer>> graph;
//     private static List<int[]> pairs;
//     private static Map<Integer,Boolean> visited;

//     public static void main(String[] args) {
//         Scanner scanner = new Scanner(System.in);

//         int countOfVerticals = Integer.parseInt(scanner.nextLine());
//         int countOfPairs = Integer.parseInt(scanner.nextLine());

//         InitializeGraph(countOfVerticals, scanner);
//         InitializePairs(countOfPairs, scanner);

//         for (int[] pair : pairs) {
//             visited = new LinkedHashMap<>();

//             for (int vertex : graph.keySet()) {
//                 visited.put(vertex, false);
//             }

//             int distance = CalculateShortestDistance(pair[0],pair[1]);
//             System.out.printf("{%d, %d} -> %d",pair[0],pair[1],distance);
//             System.out.println();
//         }

//     }

//     private static int CalculateShortestDistance(int source, int destination) {

//             Queue<Integer> verticales = new ArrayDeque<>();
//             verticales.offer(source);
//             List<Integer> children;
//             int distance = 1;

//             while (!verticales.isEmpty()) {
//                 int current = verticales.poll();
//                 children = new ArrayList<>();

//                 for (int child : graph.get(current)) {
                    
//                     if (!visited.get(child)) {
                        
//                         if (child == destination) {
//                             return distance;
//                         }

//                         visited.put(child, true);
//                         children.add(child);
//                     }

//                 }

//                 verticales = new ArrayDeque<>(children);
//                 distance++;
//             }

//         return -1;
//     }

//     private static void InitializePairs(int countOfPairs, Scanner scanner) {
//         pairs = new ArrayList<>();

//         for (int i = 0; i < countOfPairs; i++) {
//             int[] pair = Arrays.stream(scanner.nextLine().split("-"))
//             .mapToInt(x -> Integer.parseInt(x))
//             .toArray();
//             pairs.add(pair);
//         }
//     }

//     private static void InitializeGraph(int countOfVerticals, Scanner scanner) {
//         graph = new LinkedHashMap<>();

//         for (int i = 0; i < countOfVerticals; i++) {
//             String[] tokens = scanner.nextLine().split(":");

//             graph.put(Integer.parseInt(tokens[0]), new ArrayList<>());

//             if (tokens.length > 1) {
//                 List<Integer> temp = new ArrayList<>();
//                 // temp = Arrays.stream(tokens[1].split(" "))
//                 // .mapToInt(x -> Integer.parseInt(x))
//                 // .collect(Collections.toList());
//                 String[] temporary = tokens[1].split(" ");
//                 for (int z = 0; z < temporary.length; z++) {
//                     temp.add(Integer.parseInt(temporary[z]));
//                 }
                
//                 graph.put(Integer.parseInt(tokens[0]), temp);
//             }
//         }
//     }
// }