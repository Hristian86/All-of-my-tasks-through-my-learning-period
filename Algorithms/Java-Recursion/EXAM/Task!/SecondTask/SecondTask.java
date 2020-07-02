import java.util.*;
/**
 * SecondTask
 */
public class SecondTask {
    private static int[] numbers;
    private static List<List<Integer>> list;
    private static Map<Integer, List<Integer>> sum;
    private static int n;

    // Driver program
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        numbers = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        n = Integer.parseInt(scanner.nextLine());

        int size = numbers[numbers.length - 1];

        sum = new HashMap();

        int[] arr = new int[size];

        list = new ArrayList<>();

        printCompositions(arr, n, 0);

        for (List<Integer> nor : list) {
            int localSum = 0;
            // int counter = 0;
            // List<Integer> localnum = new ArrayList<>(numbers.length);
            List<Integer> localnum = new ArrayList<Integer>(Collections.nCopies(numbers.length, 0));
            for (Integer net : nor) {
                localSum += numbers[net - 1];

                int test = localnum.get(net - 1);
                localnum.set(net - 1, (test += 1));

                // sum.get(localSum).add(numbers[net-1],++counter);
            }
            sum.put(localSum, new ArrayList<>(localnum));
            // sum.put(localSum, localnum);
        }

        int minSum = Collections.min(sum.keySet());

        //Print SUM
        System.out.println("Cost: " + minSum);

        List<Integer> result = sum.get(minSum);
        
        //Print INDEXES
        for (int i = 0; i < result.size(); i++) {
            int checker = result.get(i);
            if (checker > 0) {
                while (checker != 0) {
                    System.out.println((i + 1) + " => " + numbers[i]);
                    checker--;
                }
            }

        }
        //  System.out.println(sum.get(minSum).toString());


    }

    static void printCompositions(int arr[], int n, int i) {

        int MAX_POINT = numbers.length;
        if (n == 0) {
            printArray(arr, i);
        } else if (n > 0) {
            for (int k = 1; k <= MAX_POINT; k++) {
                arr[i] = k;
                printCompositions(arr, n - k, i + 1);
            }
        }
    }

    // Utility function to print array arr[]
    static void printArray(int arr[], int m) {
        ArrayList<Integer> nums = new ArrayList<>();
        for (int i = 0; i < m; i++) {
            // System.out.print(arr[i] + " ");
            nums.add(arr[i]);
        }
        list.add(nums);
        // System.out.println();
    }
}