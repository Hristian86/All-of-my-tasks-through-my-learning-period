import java.util.HashMap;
import java.util.Map;

/**
 * test
 */
public class test {

    public static void main(String[] args) {
        Map<String,String> mapa = new HashMap<>();

        String name = "ico";
        mapa.put(name, "icaka");

        System.out.println(mapa.get(name));
        if (mapa.containsKey(name)) {
            String value = mapa.get(name);
            String temp = "gen4o";

            mapa.put(name,value + " " + temp);
            System.out.println(mapa.get(name));
        }
    }
}