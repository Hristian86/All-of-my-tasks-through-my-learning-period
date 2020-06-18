import java.util.*;
/**
 * SalaryNewSolution
 */
public class SalaryNewSolution {

//     4. Salaries
// We have a hierarchy between the employees in a company. Employees can have one or several direct managers.
// People who manage nobody are called regular employees and their salaries are 1. People who manage at least one
// employee are called managers. Each manager takes a salary which is equal to the sum of the salaries of their
// directly managed employees. Managers cannot manage directly or indirectly (transitively) themselves. Some
// employees might have no manager (like the big boss). See a sample hierarchy in a company along with the salaries
// computed following the above described rule:

// © SoftUni – about.softuni.bg. Copyrighted document. Unauthorized copy, reproduction or use is not permitted.
// Follow us: Page 1 of 10
// In the above example the employees 0 and 3 are regular employees and take salary 1. All others are managers and
// take the sum of the salaries of their directly managed employees. For example, manager 1 takes salary 3 + 2 + 1 = 6
// (sum of the salaries of employees 2, 5 and 0). In the above example employees 4 and 1 have no manager.
// If we have N employees, they will be indexed from 0 to N – 1. For each employee, you’ll be given a string with N
// symbols. The symbol at a given index i, either &#39;Y&#39; or &#39;N&#39;, shows whether the current employee is a direct manager of
// employee i.
// Hint: find the node with no parent and start a DFS traversal from it to calculate the salaries on the tree recursively.
// Input
//  The input data should be read from the console.
//  On the first line you’ll be given an integer N.
//  On the next N lines you’ll be given strings with N symbols (either &#39;Y&#39; or &#39;N&#39;).
//  The input data will always be valid and in the format described. There is no need to check it explicitly.
// Output
//  The output should be printed on the console. It should consist of one line.
//  On the only output line print the sum of the salaries of all employees.
// Constraints
//  N will be an integer in the range [1 … 50].
//  For each i-th line, the i-th symbol will be &#39;N&#39;.
//  If employee A is the manager of employee B, B will not be a manager of A.
//  Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.

// 6
// NNNNNN
// YNYNNY
// YNNNNY
// NNNNNN
// YNYNNN
// YNNYNN

    public static class Edge {
        private int value;
        private int salary;

        public void SetValue(int value) {
            this.value = value;
        }

        public void SetSalary(int salary) {
            this.salary = salary;
        }

        public int GetValueKey() {
            return this.value;
        }

        public int GetSalary() {
            return this.salary;
        }
    }

    private static char[][] matrix;
    private static Map<Integer,List<Integer>> graph;
    private static Map<Integer,Boolean> visited;
    public static List<Edge> edge;
    public static Map<Integer,Integer> occur;
    
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());
        matrix = new char[n][];
        graph = new TreeMap<>();
        visited = new TreeMap<>();
        edge = new ArrayList<>();
        occur = new HashMap<>();

        for (int i = 0; i < n; i++) {
            List<Integer> temp = new ArrayList<>();
            matrix[i] = scanner.nextLine().toCharArray();
            graph.putIfAbsent(i, temp);
            visited.putIfAbsent(i, false);
            occur.putIfAbsent(i, 1);
        }

        Initialize(0,0);
        int sum = 0;
        for (int y = 0; y < graph.size(); y++) {
            List<Integer> curr = graph.get(y);
            if (curr.size() == 0) {
                sum += 1;
                // System.out.println(sum);
            } else {   
                for (var js : graph.get(y)) {
                    // System.out.println(sum);
                    visited.put(js, false);
                }        
                Recurson(y);
                // sum += GraphChilds(y);
            }
            
            // for (int g = 0; g < curr.size(); g++) {
                //     Integer x = curr.get(g);
                //     System.out.print(x);
                // }
                // System.out.println();
            }
            
            // for (var f : edge) {
                //     System.out.println(" Edge => " + f.value + " Salary => " + f.salary);
                // }
                int totals = 1;
                // System.out.println(sum);
                for (var f : occur.keySet()) {
                    totals += occur.get(f);
                    System.out.println(occur.get(f));
                }
                
                // System.out.println(totals);
        }

        private static void Recurson(int key) {
            
            
            
        }

        
            

    // private static void Recurson(int key) {
                
    //         for (var f : graph.get(key)) {
    //             if (occur.containsKey(key)) {
    //                 List<Integer> cur = graph.get(key);
    //                 if (cur.size() > 1) {
    //                     occur.put(key, occur.get(key) + 1);
    //                 }
    //             }
    //             Recurson(f);
    //         }
    // }

    private static int GraphChilds(int key) {
        Deque<Integer> que = new ArrayDeque<>();
        que.offer(key);
        List<Integer> children;
        int occurrencies = 0; // not shure, it will need some twiking

        while (!que.isEmpty()) {
            children = new ArrayList<>();
            while (!que.isEmpty()) {

                Integer current = que.poll();
                if (current == 5) {
                    int asd = 0;
                }
                Edge currEdge = new Edge();
                currEdge.SetValue(current);
                currEdge.SetSalary(occurrencies);
                
                for (Integer child : graph.get(current)) {
                    if (!visited.get(child)) {
                        // visited.put(child, true);
                    }

                    children.add(child);
                    occurrencies++;
                }

                if (occur.containsKey(current)) {
                    List<Integer> cur = graph.get(current);
                    if (cur.size() > 1) {
                        occur.put(current, occur.get(current) + 1);
                    }
                }

            }
            que = new ArrayDeque<>(children);
        }
        return occurrencies;
    }

    private static void Initialize(int row, int index) {
        if (row >= matrix.length || index >= matrix.length) {
            return;
        }

        for (int i = 0; i < matrix[row].length; i++) {
            if (matrix[row][i] == 'Y') {
                List<Integer> current = graph.get(row);
                current.add(i);
                graph.put(row, current);
                
            }
        }

        Initialize(row + 1, index);
    }
}