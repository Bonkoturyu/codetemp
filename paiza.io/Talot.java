import java.util.*;

public class Main {
    public static void main(String[] args) throws Exception {
        double rand = Math.random();
        int number = (int)(rand * 22 * 2);
        System.out.println("num:" + number);

        // �J�[�h�ꗗ
        String[] cards = { "����", "���p�t", "�����c", "����", "�c��", "���c", "���l", "���", "���`", "�B��", "�^���̗�", "��", "�݂邳�ꂽ�j", "���_", "�ߐ�", "����", "��", "��", "��", "���z", "�R��", "���E" };
        String[] frbk = { "��", "�t" };

        System.out.println(cards[(number / 2)] + "(" + frbk[(number % 2)] + ")");
    }
}
