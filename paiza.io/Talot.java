import java.util.*;

public class Main {
    public static void main(String[] args) throws Exception {
        double rand = Math.random();
        int number = (int)(rand * 22 * 2);
        System.out.println("num:" + number);

        // ƒJ[ƒhˆê——
        String[] cards = { "‹ğÒ", "–‚pt", "—‹³c", "—’é", "c’é", "‹³c", "—öl", "íÔ", "³‹`", "‰BÒ", "‰^–½‚Ì—Ö", "—Í", "’İ‚é‚³‚ê‚½’j", "€_", "ß§", "ˆ«–‚", "“ƒ", "¯", "Œ", "‘¾—z", "R”»", "¢ŠE" };
        String[] frbk = { "³", "‹t" };

        System.out.println(cards[(number / 2)] + "(" + frbk[(number % 2)] + ")");
    }
}
