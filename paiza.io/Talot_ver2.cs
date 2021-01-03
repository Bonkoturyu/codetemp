using System;
using System.Collections.Generic;
using System.Collections;

public class Hello{
    private const int card_max = 22;
    private static int nowCardCount = card_max;
    private static List<int> cardlist = new List<int>();
    
    // �J�[�h�ꗗ
    private static string[] cards = { 
    "����",
    "���p�t",
    "�����c",
    "����",
    "�c��",
    "���c",
    "���l",
    "���",
    "���`",
    "�B��",
    "�^���̗�",
    "��",
    "�݂邳�ꂽ�j",
    "���_",
    "�ߐ�",
    "����",
    "��",
    "��",
    "��",
    "���z",
    "�R��",
    "���E"
     };
    private static string[] frbk = {
    "��",
    "�t"
    };
    private static string[] means_fr = { 
    "���s�B�Ύ����B�ɒ[�B���B�A���R�[�����ŁB�M���B�\�I�B",
    "��r�B�O���B��ہB�I���B�a�B��ɁB�����B�ЊQ�B�G��㩁B���M�B�ӎu�B�j���̎���ҁB", 
    "�閧�B�_��B���炩�ɂ���Ȃ������B����҂��j���Ȃ�A�ނɂƂ��ċC�ɂȂ鏗���B����҂������Ȃ�A�ޏ����g�B���فB�S�苭���B��B�p�m�B�Ȋw�B",
    "����B�s���B�C�j�V���e�B�u�B�����̒����B���m�Ȃ���́B�閧�B����B�^���B���m�B",
    "��ł��B�́B�h��B�����B�̑�Ȑl���B�����B�����B�M�O�B���Ђƈӎu�B",
    "�����B�����B�S���B�ʂ̈Ӗ��ł́A�b�݂ƗL���B�����B����҂�����Ƃ���l���B",
    "���́B���B���B��������鎎���B",
    "�܂����̎��̋~���A���R�B�ۗ��B�푈�B�����B����B���Q�B�g���u���B",
    "�����B�������B�����B�s���B�����Ȕ��f�B",
    "�[���B�T�d�B�܂��A����ȈӖ��Ƃ��Ĕ��t�B�U��B�����B����ȂǁB",
    "�^���B�K�^�B�����B����B�����B",
    "�́B�G�l���M�[�B�s���B�E�C�B����B���S�Ȑ����Ɩ��_�B",
    "�p�m�B�T�d�B���@�́B�����B�]���B���ρB��p�B�\���B",
    "�I���B�����ׂ��^���B�j��B���B�j���ɂƂ��Ă͌�돂�������B�����ɂƂ��Ă͑����̔��΁B�Ⴂ�����ɂƂ��Ă͌����̌v��̎��s�B",
    "�o�ρB���f�B����B�Ǘ��B�K�؁B",
    "�j��B�\�́B����B�ُ�ȓw�́B�́B�^���B�O�����Ē�߂��Ă��ē������Ȃ����́i�K�������������̂Ƃ͌���Ȃ��j�B",
    "�ߒQ�B�����B�t���B�Г�B�s���_�B�j��B���\�B",
    "�����B�ޓ��B�r���B�����B�܂��ʂ̈Ӗ��ł́A��]�Ɩ��邢���ʂ��B",
    "�B�ꂽ�G�B�댯�B�����B�ŁB���|�B�\���B���z�B�I�J���g�I�ȗ́B���s�B",
    "�����I�ȍK���B�K�^�Ȍ����B�����B",
    "�ʒu�̕ω��B�X�V�B���ʁB���̉��߂ɂ��΁A�i�ׂɂ����鑹���B",
    "�񑩂��ꂽ�����B��V�B���B�o���B��s�B�ꏊ�̈ړ��B"
    };
    private static string[] means_bk = { 
    "���m�B�s�݁B���z�B�s���ӁB�����o�B�����B���h�B",
    "��ҁB���ҁB���_�a�B�s���_�B�s���B", 
    "��M�B�����I�A���邢�͓��̓I�M��B������B�\�ʓI�Ȓm���B",
    "���B�^���B���̉����B���̊��y�B�ʂ̉��߂ɂ��΁A�D�_�s�f�B",
    "���߁B�����B�M�p�B�G�ɑ΂��鍢�f�B��Q�B���n���B",
    "�Љ�B�ǂ������B���a�B�ߏ�Ȑe�؁B�コ�B",
    "���s�B�����Ȍv��B�ʂ̈Ӗ��ł́A�s���̂��錋���Ƃ�����Ӗ��ł̕s��v������킷�B",
    "�\�́B�����B�_���B�i�ׁB�s�k�B",
    "������Ӗ��ɂ�����@�B�@�����B�����蛁B�Ό��B�ߏ�Ȍ������B",
    "�B���B�\���B����B����B���R�̖����x���B",
    "����B�L�x�B�ߕ��B",
    "�ƍفB�̗͂��p�B�コ�B�s��v�B���ɂ͕s���_�B",
    "���Ȏ�`�B���O�B�����B���ƁB�����c�́B",
    "�Đ��B�����B���C�́B䩑R�����B���V�a�B����ꂽ��]�B�Đ��B�n���B�^���B�X�V�B�x��������킷�B",
    "����B�@���B�@�h�Ɋւ��邱�ƁB�Ƃ��ɂ͎���Ҏ��g�₻�̏����̌������肪�@���֌W�҂�������Ȃ��B�s���a�B�s�K�ȑg�ݍ��킹�B���Q�̏ՓˁB",
    "�����h���B�コ�B���ʁB�ӖځB",
    "�Ӗ��͎�܂邪�A���ʒu�Ɠ����Ӗ��B�}���B�����B�\���B",
    "�����B�s�\�B",
    "�s����B�����Ȃ����ƁB���فB�����ȋ\���Ǝ��s�B",
    "���ʒu�Ɠ��������A�Ӗ����キ�Ȃ�B�����I�ȍK���B�K�^�Ȍ����B�����B",
    "�コ�B���C�́B�P���B�T�d�B���S�B�����B",
    "�Đ��B�Œ�B����B�i���B"
    };

    public static void Main(){
        //resetTarotList();//������

        tarotOneOracle();
        tarotThreeCardSpread();

        //�����邾�������i�e�X�g�p�j
        //while(true){
        //    int number = pickupRandomTarotCard();
        //    if(-1 == number){
        //        System.Console.WriteLine("CardFinished.");
        //        break;
        //    }
        //    else{
        //        System.Console.WriteLine("CardNum:" + number / 2);
        //    }
        //    System.Console.WriteLine();
        //}    
    }

    public static void tarotOneOracle(){
        //�����I���N���Ő肤
        System.Console.WriteLine();
        System.Console.WriteLine("[One Card Oracle Tarot]");
        resetTarotList();//������
        int num_oneoracle = pickupRandomTarotCard();
        System.Console.WriteLine(cards[(num_oneoracle / 2)] + "(" + frbk[(num_oneoracle % 2)] + ")");
        if(0 == (num_oneoracle % 2)){ // ���ʒu
            System.Console.WriteLine(means_fr[(num_oneoracle / 2)]);
        }
        else{ // �t�ʒu
            System.Console.WriteLine(means_bk[(num_oneoracle / 2)]);
        }
    }

    public static void tarotThreeCardSpread(){
        //�X�v���b�h�Ő肤
        System.Console.WriteLine();
        System.Console.WriteLine("[Three Card Tarot spread]");
        resetTarotList();//������
        int num_one_spread = pickupRandomTarotCard();
        int num_two_spread = pickupRandomTarotCard();
        int num_three_spread = pickupRandomTarotCard();
        // �P����
        System.Console.WriteLine("[old]");
        System.Console.WriteLine(cards[(num_one_spread / 2)] + "(" + frbk[(num_one_spread % 2)] + ")");
        if(0 == (num_one_spread % 2)){ // ���ʒu
            System.Console.WriteLine(means_fr[(num_one_spread / 2)]);
        }
        else{ // �t�ʒu
            System.Console.WriteLine(means_bk[(num_one_spread / 2)]);
        }
        System.Console.WriteLine();
        // �Q����
        System.Console.WriteLine("[now]");
        System.Console.WriteLine(cards[(num_two_spread / 2)] + "(" + frbk[(num_two_spread % 2)] + ")");
        if(0 == (num_two_spread % 2)){ // ���ʒu
            System.Console.WriteLine(means_fr[(num_two_spread / 2)]);
        }
        else{ // �t�ʒu
            System.Console.WriteLine(means_bk[(num_two_spread / 2)]);
        }
        System.Console.WriteLine();
        // �R����
        System.Console.WriteLine("[future]");
        System.Console.WriteLine(cards[(num_three_spread / 2)] + "(" + frbk[(num_three_spread % 2)] + ")");
        if(0 == (num_three_spread % 2)){ // ���ʒu
            System.Console.WriteLine(means_fr[(num_three_spread / 2)]);
        }
        else{ // �t�ʒu
            System.Console.WriteLine(means_bk[(num_three_spread / 2)]);
        }
    }

    public static int pickupRandomTarotCard(){
        //1������
        int pick_number = pickupRandomNum();
        if(-1 == pick_number){ return -1; } // ������J�[�h�������Ȃ�
        
        //�������̂ŃJ�[�h�̃��X�g����1�����O����
        int cardnum = pick_number / 2;
        //System.Console.WriteLine("remove card:" + cardlist[cardnum]);
        int card_number = cardlist[cardnum];
        cardlist.RemoveAt(cardnum);
        //foreach(int card in cardlist){
        //    System.Console.Write(card + ",");
        //}
        //System.Console.Write("\r\n");
        return card_number;
    }

    private static void resetTarotList(){
        // ���X�g�����Z�b�g����
        cardlist.Clear();
        for(int i = 0; i < card_max; i++)
            cardlist.Add(i);
    }

    private static int pickupRandomNum(){
        if(0 == nowCardCount){ return -1; } // ������J�[�h�������Ȃ�
        var rand = new System.Random();
        int number = rand.Next(1, nowCardCount*2) - 1;
        //System.Console.WriteLine("num:" + number);
        nowCardCount -= 1;
        //System.Console.WriteLine("Cnt:" + nowCardCount);
        return number;
    }
}
