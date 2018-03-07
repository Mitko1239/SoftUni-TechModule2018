package mitko1239;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.TreeMap;

public class Snowwhite {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

//	    TreeMap
//      HashMap
//      LinkedHashMap

        LinkedHashMap<String, Integer> dwarfs = new LinkedHashMap<>();
        HashMap<String, Integer> colors = new HashMap<>();


        String line;
        while (!"Once upon a time".equals(line = reader.readLine())) {
            String[] tokens = line.split(" <:> ");
            String dwarfName = tokens[0];
            String dwarfHatColor = tokens[1];
            int dwarfPhysics = Integer.parseInt(tokens[2]);

            String currentDwarfId = String.format("%s <:> %s", dwarfName, dwarfHatColor);

            colors.putIfAbsent(dwarfHatColor, 0);
            colors.put(dwarfHatColor, colors.get(dwarfHatColor) + 1);

            if (!dwarfs.containsKey(currentDwarfId)) {
                dwarfs.put(currentDwarfId, dwarfPhysics);
            } else {
                int oldPhysics = dwarfs.get(currentDwarfId);

                if (dwarfPhysics > oldPhysics) {
                    dwarfs.put(currentDwarfId, dwarfPhysics);
                }
            }
        }

        dwarfs.entrySet().stream().sorted((d1, d2) -> {
            int compareResult = Integer.compare(d2.getValue(), d1.getValue());
            if (compareResult == 0) {
                String d1HatColor = d1.getKey().split(" <:> ")[1];
                String d2HatColor = d2.getKey().split(" <:> ")[1];

                compareResult = Integer.compare(colors.get(d2HatColor), colors.get(d1HatColor));
            }

            return compareResult;
        }).forEach(d -> {
            String[] dwarfIDTokens = d.getKey().split(" <:> ");
            String dwarfName = dwarfIDTokens[0];
            String dwarfHatColor = dwarfIDTokens[1];
            Integer dwarfPhysics = d.getValue();

            System.out.printf("(%s) %s <-> %d%n", dwarfHatColor, dwarfName, dwarfPhysics);
        });
    }
}
