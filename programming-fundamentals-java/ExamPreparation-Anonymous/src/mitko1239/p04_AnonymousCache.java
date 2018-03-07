package mitko1239;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.stream.Collectors;

public class p04_AnonymousCache {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        String input = reader.readLine();
        LinkedHashMap<String, HashMap<String, Long>> data = new LinkedHashMap<>();

        while (!input.equals("thetinggoesskrra")) {
            String[] split =
                    Arrays.stream(input.split("[\\s+\\->|]"))
                            .filter(e -> !e.equals(""))
                            .toArray(String[]::new);
            if (split.length > 1) {
                String dataKey = split[0];
                long dataSize = Long.parseLong(split[1]);
                String dataSet = split[2];

                if (!data.containsKey(dataSet)) {
                    data.put(dataSet, new LinkedHashMap<>());
                }
                data.get(dataSet).put(dataKey, dataSize);
            }

            input = reader.readLine();
        }

        if (data.size() > 1) {
            data.entrySet().stream().sorted((e1, e2) -> {
                long firstSum = e1.getValue()
                        .entrySet()
                        .stream()
                        .mapToLong(Map.Entry::getValue)
                        .sum();
                long secondSum = e2.getValue()
                        .entrySet()
                        .stream()
                        .mapToLong(Map.Entry::getValue)
                        .sum();
                return Long.compare(secondSum, firstSum);
            }).limit(1)
                    .collect(Collectors.toMap(
                            Map.Entry::getKey,
                            Map.Entry::getValue,
                            (k, v) -> {
                                throw new AssertionError();
                            },
                            LinkedHashMap::new
                    )).forEach((key, value) -> {
                long totalSize = value.entrySet().stream().mapToLong(Map.Entry::getValue).sum();
                System.out.printf("Data Set: %s, Total Size: %d\n", key, totalSize);

                value.forEach((key1, value1) -> System.out.printf("$.%s\n", key1));
            });
        }
    }
}
