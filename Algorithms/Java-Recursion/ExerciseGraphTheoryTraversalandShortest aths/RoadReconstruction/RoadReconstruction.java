import java.util.*;
/**
 * RoadReconstruction
 */
public class RoadReconstruction {

    private static int[][] pairs;
    private static Map<Integer,Integer> graph;
    private static Deque<int[]> que;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int maxNumber = Integer.parseInt(scanner.nextLine());
        int row = Integer.parseInt(scanner.nextLine());

        graph = new HashMap<>();
        pairs = new int[row][];

        for (int i = 0; i < row; i++) {
            pairs[i] = Arrays.stream(scanner.nextLine().split(" - "))
            .mapToInt(x -> Integer.parseInt(x))
            .toArray();
        }

        for (var pair : pairs) {
            
            CheckPair(pair);

        }

        System.out.println();

    }

    private static void CheckPair(int[] pair) {
        
        

    }
}