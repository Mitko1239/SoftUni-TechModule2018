package mitko1239;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class p02_AnonymousThreat {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        List<String> elements = Arrays.stream(reader.readLine().split(" ")).collect(Collectors.toList());

        String input = reader.readLine();
        while (!input.equals("3:1")) {
            String[] data = input.split(" ");
            String command = data[0];
            switch (command) {
                case "merge":
                    int startIndex = Integer.parseInt(data[1]);
                    int endIndex = Integer.parseInt(data[2]);
                    startIndex = validateIndex(startIndex, elements.size());
                    endIndex = validateIndex(endIndex, elements.size());

                    String concatElements = elements
                            .subList(startIndex, endIndex + 1)
                            .stream()
                            .collect(Collectors.joining(""));
                    elements.subList(startIndex, endIndex + 1).clear();
                    elements.add(startIndex, concatElements);
                    break;
                case "divide":
                    int index = Integer.parseInt(data[1]);
                    int partitionCount = Integer.parseInt(data[2]);
                    List<String> partitions = splitEqually(elements.get(index), partitionCount);
                    elements.remove(index);
                    elements.addAll(index, partitions);
                    break;
            }

            input = reader.readLine();
        }

        System.out.println(String.join(" ", elements));
    }

    private static List<String> splitEqually(String word, int partitionCount) {
        List<String> result = new ArrayList<>();

        int part = word.length() / partitionCount;

        while (word.length() >= part) {
            result.add(word.substring(0, part));
            word = word.substring(part);
        }
        if (!word.equals("")) {
            result.add(word);
        }
        if (result.size() == partitionCount) {
            return result;
        } else {
            String concatLastTwoElements = result.get(result.size() - 2)
                    .concat(result.get(result.size() - 1));

            result.subList(result.size() - 2, result.size()).clear();
            result.add(concatLastTwoElements);
            return result;
        }
    }

    private static int validateIndex(int index, int length) {
        if (index < 0) {
            index = 0;
        }
        if (index > length - 1) {
            index = length - 1;
        }
        return index;
    }
}
