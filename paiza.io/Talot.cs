using System;

public class Hello{
    public static void Main(){
        // 
        var rand = new System.Random();
        int number = rand.Next(1, 22*2) - 1;
        //System.Console.WriteLine("num:" + number);
        
        // �J�[�h�ꗗ
        string[] cards = { "����", "���p�t", "�����c", "����", "�c��", "���c", "���l", "���", "���`", "�B��", "�^���̗�", "��", "�݂邳�ꂽ�j", "���_", "�ߐ�", "����", "��", "��", "��", "���z", "�R��", "���E" };
        string[] frbk = { "��", "�t" };

        System.Console.WriteLine(cards[(number / 2)] + "(" + frbk[(number % 2)] + ")");
    }
}
