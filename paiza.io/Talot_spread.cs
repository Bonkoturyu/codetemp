using System;

public class Hello{
    public static void Main(){
        // 
        var rand = new System.Random();
        int number = rand.Next(1, 22*2) - 1;
        //System.Console.WriteLine("num:" + number);
        int number2 = rand.Next(1, 22*2) - 1;
        while(true){
            if(number != number2){
                if((number - (number % 2)) != number2){
                    break;
                }
            }
            number2 = rand.Next(1, 22*2) - 1;
        }

        int number3 = rand.Next(1, 22*2) - 1;
        while(true){
            if(number != number3){
                if((number - (number % 2)) != number3){
                    break;
                }
            }
            number3 = rand.Next(1, 22*2) - 1;
        }
        while(true){
            if(number2 != number3){
                if((number2 - (number2 % 2)) != number3){
                    break;
                }
            }
            number3 = rand.Next(1, 22*2) - 1;
        }
        
        // �J�[�h�ꗗ
        string[] cards = { 
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
        
        string[] frbk = {
        "��",
        "�t"
        };
        
        string[] means_fr = { 
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
        
        string[] means_bk = { 
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
        
        // �P����
        System.Console.WriteLine(cards[(number / 2)] + "(" + frbk[(number % 2)] + ")");
        if(0 == (number % 2)){ // ���ʒu
            System.Console.WriteLine(means_fr[(number / 2)]);
        }
        else{ // �t�ʒu
            System.Console.WriteLine(means_bk[(number / 2)]);
        }
        System.Console.WriteLine();
        // �Q����
        System.Console.WriteLine(cards[(number2 / 2)] + "(" + frbk[(number2 % 2)] + ")");
        if(0 == (number2 % 2)){ // ���ʒu
            System.Console.WriteLine(means_fr[(number2 / 2)]);
        }
        else{ // �t�ʒu
            System.Console.WriteLine(means_bk[(number2 / 2)]);
        }
        System.Console.WriteLine();
        // �R����
        System.Console.WriteLine(cards[(number3 / 2)] + "(" + frbk[(number3 % 2)] + ")");
        if(0 == (number3 % 2)){ // ���ʒu
            System.Console.WriteLine(means_fr[(number3 / 2)]);
        }
        else{ // �t�ʒu
            System.Console.WriteLine(means_bk[(number3 / 2)]);
        }
    }
}
