package mitko1239;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.math.BigDecimal;

public class p01_AnonymousDownsite {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int numberOfWebsites = Integer.parseInt(reader.readLine());
        BigDecimal securityKey = new BigDecimal(reader.readLine());

        BigDecimal totalLoss = new BigDecimal(0);
        for (int i = 0; i < numberOfWebsites; i++) {
            String[] input =reader.readLine().split(" ");
            String siteName = input[0];
            BigDecimal siteVisits = new BigDecimal(input[1]);
            BigDecimal siteCommercialPricePerVisit = new BigDecimal(input[2]);

            BigDecimal siteLoss = siteVisits.multiply(siteCommercialPricePerVisit);
            totalLoss = totalLoss.add(siteLoss);
            System.out.println(siteName);
        }

        System.out.printf("Total Loss: %.20f\n", totalLoss);
        System.out.printf("Total Loss: %s\n", securityKey.pow(numberOfWebsites));
    }
}
