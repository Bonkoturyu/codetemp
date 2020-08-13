using System;

public class Hello{
    public static void Main(){
        // 
        var rand = new System.Random();
        int number = rand.Next(1, 22*2) - 1;
        //System.Console.WriteLine("num:" + number);
        
        // ƒJ[ƒhˆê——
        string[] cards = { "‹ğÒ", "–‚pt", "—‹³c", "—’é", "c’é", "‹³c", "—öl", "íÔ", "³‹`", "‰BÒ", "‰^–½‚Ì—Ö", "—Í", "’İ‚é‚³‚ê‚½’j", "€_", "ß§", "ˆ«–‚", "“ƒ", "¯", "Œ", "‘¾—z", "R”»", "¢ŠE" };
        string[] frbk = { "³", "‹t" };

        System.Console.WriteLine(cards[(number / 2)] + "(" + frbk[(number % 2)] + ")");
    }
}
