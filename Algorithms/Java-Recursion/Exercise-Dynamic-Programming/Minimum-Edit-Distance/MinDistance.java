import java.util.ArrayDeque;
import java.util.Deque;
import java.util.Scanner;
import java.lang.*;

/**
 * MinDistance
 */
public class MinDistance {

//     8. Minimum Edit Distance
// We have two strings, s1 and s2. The goal is to obtain s2 from s1 by applying the following operations:
//  replace(i, x) – in s1, replaces the symbol at index i with the character x
//  insert(i, x) – in s1, inserts the character x at index i
//  delete(i) – from s1, removes the character at index i

// © SoftUni – about.softuni.bg. Copyrighted document. Unauthorized copy, reproduction or use is not permitted.
// Follow us: Page 6 of 6
// We are only allowed to modify s1, s2 stays unchanged at all times. Each of the three operations has a certain cost
// associated with it (positive integer number). Note: the cost of the replace(i, x) operation is 0 if it doesn’t
// actually change the character.
// The goal is to find the sequence of operations which will produce s2 from s1 with minimal cost.
// Input
//  The input consist of five lines, on the first line the cost for replace on the second the cost for
// insert and then on the third the cost for the delete. After that on the next two lines are the two
// strings s1 and s2.

    private static int replaceCost;
    private static int insertCost;
    private static int deleteCost;
    private static int[][] editCost;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        replaceCost = Integer.parseInt(scanner.nextLine());
        insertCost = Integer.parseInt(scanner.nextLine());
        deleteCost = Integer.parseInt(scanner.nextLine());
        String first = scanner.nextLine();
        String second = scanner.nextLine();
        Compute(first,second);
        
    }

    private static void Compute(String first,String second) {
        int firstLen = first.length();
        int secondLen = second.length();
        editCost = new int[firstLen + 1][secondLen + 1];

        for (int row = 0; row <= firstLen; row++)
        {
            editCost[row][0] = row * deleteCost;
        }

        for (int col = 0; col <= secondLen; col++)
        {
            editCost[0][col] = col * insertCost;
        }

        for (int row = 1; row <= firstLen; row++)
        {
            for (int col = 1; col <= secondLen; col++)
            {
                int cost = second.indexOf(col - 1) == first.indexOf(row - 1) ? 0 : replaceCost;

                int delete = editCost[row - 1][col] + deleteCost;
                int replace = editCost[row - 1][col - 1] + cost;
                int insert = editCost[row][col - 1] + insertCost;
                
                editCost[row][col] = Math.min(Math.min(delete, insert), replace);
            }
        }

        PrintResult(first, second, firstLen, secondLen);
    }

    private static void PrintResult(String first, String second, int firstLen, int secondLen)
    {
        System.out.println("Minimum edit distance: " + editCost[firstLen][secondLen]);

        Deque<String> resultOperations = new ArrayDeque<>();
        int fIndex = firstLen;
        int sIndex = secondLen;
        while (fIndex > 0 && sIndex > 0)
        {
            if (first.indexOf(fIndex - 1) == second.indexOf(sIndex - 1))
            {
                fIndex--;
                sIndex--;
            }
            else
            {
                int replace = editCost[fIndex - 1][sIndex - 1] + replaceCost;
                int delete = editCost[fIndex - 1][sIndex] + deleteCost;
                int insert = editCost[fIndex][sIndex - 1] + insertCost;
                if (replace <= delete && replace <= insert)
                {
                    resultOperations.push("REPLACE(" + (fIndex - 1) + ", " + second.indexOf(sIndex - 1) + ")");
                    fIndex--;
                    sIndex--;
                }
                else if (delete < replace && delete < insert)
                {
                    resultOperations.push("DELETE(" + (fIndex - 1) + ")");
                    fIndex--;
                }
                else
                {
                    resultOperations.push("INSERT("+ (sIndex - 1) + ", " + second.indexOf(sIndex - 1) + ")");
                    sIndex--;
                }
            }
        }

        while (fIndex > 0)
        {
            resultOperations.push("DELETE(" + (fIndex - 1) + ")");
            fIndex--;
        }

        while (sIndex > 0)
        {
            resultOperations.push("INSERT(" + (sIndex - 1) + ", " + second.indexOf(sIndex - 1) + ")");
            sIndex--;
        }

        for (var resultOperation : resultOperations)
        {
            System.out.println(resultOperation);
        }
    }
}