package mitko1239;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import java.util.stream.Collectors;

public class p03_AnonymousVox {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String encodedText = reader.readLine();
        String[] placeholders =
                Arrays.stream(reader.readLine().split("[{}]"))
                        .filter(e -> !e.equals(""))
                        .toArray(String[]::new);

        Pattern pattern = Pattern.compile("([A-Za-z]+)(.*)(\\1)");
        Matcher matcher = pattern.matcher(encodedText);

        int count = 0;
        while (matcher.find()) {
            String decodedText = matcher.group(1) + placeholders[count++] + matcher.group(3);
            encodedText = encodedText.replace(matcher.group(0), decodedText);
        }
        System.out.println(encodedText);

    }
}
