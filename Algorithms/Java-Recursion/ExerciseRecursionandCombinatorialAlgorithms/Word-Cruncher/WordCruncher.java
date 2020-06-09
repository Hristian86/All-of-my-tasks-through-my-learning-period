import java.util.stream.Collectors;
import java.util.*;

/**
 * WordCruncher
 */
public class WordCruncher {

//     8. Word Cruncher
// Write a program that receives some strings and forms another string that is required. On the first line you will be
// given all of the strings separated by comma and space. On the next line you will be given the string that needs to be
// formed from the given strings. For more clarification see the examples below.
// Input
//  On the first line you will receive the strings (separated by comma and space &quot;, &quot;)
//  On the next line you will receive the target string
// Output
//  Print each of the found ways to form the required string as shown in the examples
// Constrains
//  There might be repeating elements in the input

    private static List<String> words;
    private static List<String> combined = new ArrayList<>();
    private static String target;
    private static StringBuilder builder = new StringBuilder();
    private static List<String> arrs = new ArrayList<>();
    // private static boolean[] used;

    private static Map<Integer, List<String>> table;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
        words = Arrays.stream(scanner.nextLine().split(", "))
        .collect(Collectors.toList());
        target = scanner.nextLine();

        words.removeIf(next -> !target.contains(next));

        // for(Iterator<String> iter = words.iterator();iter.hasNext();) {
        //     String next = iter.next();
        //     if (!target.contains(next)) {
        //         iter.remove();
        //     }
        // }

        table = new HashMap<>();

        for (String sub : words) {
            int index = target.indexOf(sub);

            while (index != -1) {
                table.putIfAbsent(index, new ArrayList<>());
                table.get(index).add(sub);
                index = target.indexOf(sub, index + 1);
            }
        }

        // combined = new String[words.size()];
        // used = new boolean[words.size()];

        Permute(0);
        Display();
        scanner.close();
    }

    private static void Display() {
        for (int i = arrs.size() - 1; i >= 0; i--) {
            System.out.print(arrs.get(i));
        }
    }

    private static void Permute(int index) {
        if (index == target.length()) {
            Print();
        } else if (table.containsKey(index)) {

            List<String> strings = table.get(index);

            for (String str : strings) {
                combined.add(str);
                Permute(index + str.length());
                combined.remove(combined.size() - 1);
            }
        }
    }

    private static void Print() {
        String actual = String.join("", combined);
        if (actual.contains(target)) {
            arrs.add(String.join(" ", combined) + System.lineSeparator());
            // builder.append(String.join(" ", combined));
        }
    }
}