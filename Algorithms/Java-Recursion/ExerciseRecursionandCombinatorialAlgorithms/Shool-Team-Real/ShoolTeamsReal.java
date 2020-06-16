import java.util.*;
/**
 * ShoolTeamsReal
 */
public class ShoolTeamsReal {

    public static final int girlsCount = 3;
    public static final int boysCount = 2;
    
    public static  String[] girls;
    public static String[] boys;
    public static String[] combinedGirls;
    public static String[] combinedBoys;

    public static List<String> allGirls = new ArrayList<>();
    public static List<String> allBoys = new ArrayList<>();
  
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        girls = scanner.nextLine().split(", ");
        boys = scanner.nextLine().split(", ");
 
        combinedGirls = new String[girlsCount];
        combinedBoys = new String[boysCount];
 
        combineGirls(0,0);
        combineBoys(0,0);

        for (String girsName: allGirls) {
            for (String boysName: allBoys) {
                System.out.println(girsName + ", " + boysName);
            }
        }
    }

    private static void combineGirls(int index, int start){
            if (index >= girlsCount){
                allGirls.add(String.join(", ", combinedGirls));
            } else {
                for (int i = start; i < girls.length ; i++) {
                    combinedGirls[index] = girls[i];
                    combineGirls(index + 1, i + 1);
                }
            }
 
    }

    private static void combineBoys(int index, int start){
        if (index >= boysCount){
            allBoys.add(String.join(", ", combinedBoys));
        } else {
            for (int i = start; i < boys.length ; i++) {
                combinedBoys[index] = boys[i];
                combineBoys(index + 1, i + 1);
            }
        }
 
    }
 
    // print the separate combined arrays - replaced by string.join
    public static void print(String [] arr){
        for (String name : arr) {
            System.out.print(name + ", ");
        }
        System.out.println();
    }
}