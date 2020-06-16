import java.util.*;

/**
 * ShoolTeams
 */
public class ShoolTeams {

    private static int[] combinatios;
    private static boolean[] visited;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int maxNumber = Integer.parseInt(scanner.nextLine());
        int length = Integer.parseInt(scanner.nextLine());
        combinatios = new int[length];
        visited = new boolean[length];
        Permute(1,0,maxNumber);

    }

    private static void Permute(int start,int index,int maxNumber) {
        if (index == combinatios.length) {
            Print();
        } else {
            for (int i = start; i <= maxNumber; i++) {
                if (!visited[index]) {   
                    visited[index] = true;
                    combinatios[index] = i;
                    Permute(i + 1, index + 1,maxNumber);
                    visited[index] = false;
                }
            }
        }
    }

    private static void Print() {
        StringBuilder bld = new StringBuilder();
        for (int i = 0; i < combinatios.length; i++) {
            if (i == combinatios.length - 1) {
                bld.append(combinatios[i]);    
            } else {
                bld.append(combinatios[i]).append(" ");
            }
        }
        System.out.println(bld);
    }
}