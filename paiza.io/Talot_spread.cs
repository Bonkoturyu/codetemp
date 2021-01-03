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
        
        // カード一覧
        string[] cards = { 
        "愚者",
        "魔術師",
        "女教皇",
        "女帝",
        "皇帝",
        "教皇",
        "恋人",
        "戦車",
        "正義",
        "隠者",
        "運命の輪",
        "力",
        "吊るされた男",
        "死神",
        "節制",
        "悪魔",
        "塔",
        "星",
        "月",
        "太陽",
        "審判",
        "世界"
         };
        
        string[] frbk = {
        "正",
        "逆"
        };
        
        string[] means_fr = { 
        "愚行。偏執狂。極端。酩酊。アルコール中毒。熱狂。暴露。",
        "手腕。外交。手際。巧妙。病。苦痛。損失。災害。敵の罠。自信。意志。男性の質問者。", 
        "秘密。神秘。明らかにされない未来。質問者が男性なら、彼にとって気になる女性。質問者が女性なら、彼女自身。沈黙。粘り強さ。謎。英知。科学。",
        "実り。行動。イニシャティブ。月日の長さ。未知なるもの。秘密。困難。疑い。無知。",
        "頑固さ。力。防御。実現。偉大な人物。同盟。理性。信念。権威と意志。",
        "結婚。同盟。拘束。別の意味では、恵みと有徳。直感。質問者が頼りとする人物。",
        "魅力。愛。美。克服される試練。",
        "まさかの時の救助、援軍。摂理。戦争。勝利。無礼。復讐。トラブル。",
        "平等。正しさ。高潔。行政。正当な判断。",
        "深慮。慎重。また、特殊な意味として反逆。偽り。悪事。崩壊など。",
        "運命。幸運。成功。向上。至福。",
        "力。エネルギー。行動。勇気。寛大。完全な成功と名誉。",
        "英知。慎重。洞察力。試練。犠牲。直観。占術。予言。",
        "終わり。死すべき運命。破壊。堕落。男性にとっては後ろ盾を失う。女性にとっては多くの反対。若い女性にとっては結婚の計画の失敗。",
        "経済。中庸。倹約。管理。適切。",
        "破壊。暴力。激烈。異常な努力。力。運命。前もって定められていて動かせないもの（必ずしも悪いものとは限らない）。",
        "悲嘆。困窮。逆境。災難。不名誉。破壊。詐欺。",
        "損失。窃盗。喪失。放棄。また別の意味では、希望と明るい見通し。",
        "隠れた敵。危険。中傷。闇。恐怖。欺き。幻想。オカルト的な力。失敗。",
        "物質的な幸福。幸運な結婚。満足。",
        "位置の変化。更新。結果。他の解釈によれば、訴訟における損失。",
        "約束された成功。報酬。旅。出国。飛行。場所の移動。"
        };
        
        string[] means_bk = { 
        "無知。不在。分配。不注意。無感覚。無効。虚栄。",
        "医者。賢者。精神病。不名誉。不安。", 
        "情熱。道徳的、あるいは肉体的熱情。自惚れ。表面的な知識。",
        "光。真実。問題の解決。公の歓楽。別の解釈によれば、優柔不断。",
        "慈悲。共感。信用。敵に対する困惑。障害。未熟さ。",
        "社会。良い理解。調和。過剰な親切。弱さ。",
        "失敗。愚かな計画。別の意味では、不満のある結婚とあらゆる意味での不一致をあらわす。",
        "暴力。争い。論争。訴訟。敗北。",
        "あらゆる意味における法。法律問題。頑迷固陋。偏見。過剰な厳しさ。",
        "隠蔽。欺き。政策。恐れ。理由の無い警戒。",
        "増大。豊富。過分。",
        "独裁。力の乱用。弱さ。不一致。時には不名誉。",
        "利己主義。民衆。国民。国家。政治団体。",
        "惰性。睡眠。無気力。茫然自失。夢遊病。失われた希望。再生。創造。運命。更新。休息をあらわす。",
        "教会。宗教。宗派に関すること。ときには質問者自身やその将来の結婚相手が宗教関係者かもしれない。不調和。不幸な組み合わせ。利害の衝突。",
        "悪い宿命。弱さ。狭量。盲目。",
        "意味は弱まるが、正位置と同じ意味。抑圧。投獄。暴政。",
        "傲慢。不能。",
        "不安定。続かないこと。沈黙。小さな欺きと失敗。",
        "正位置と同じだが、意味が弱くなる。物質的な幸福。幸運な結婚。満足。",
        "弱さ。無気力。単純。慎重。決心。判決。",
        "惰性。固定。頑迷。永続。"
        };
        
        // １枚目
        System.Console.WriteLine("[old]");
        System.Console.WriteLine(cards[(number / 2)] + "(" + frbk[(number % 2)] + ")");
        if(0 == (number % 2)){ // 正位置
            System.Console.WriteLine(means_fr[(number / 2)]);
        }
        else{ // 逆位置
            System.Console.WriteLine(means_bk[(number / 2)]);
        }
        System.Console.WriteLine();
        // ２枚目
        System.Console.WriteLine("[now]");
        System.Console.WriteLine(cards[(number2 / 2)] + "(" + frbk[(number2 % 2)] + ")");
        if(0 == (number2 % 2)){ // 正位置
            System.Console.WriteLine(means_fr[(number2 / 2)]);
        }
        else{ // 逆位置
            System.Console.WriteLine(means_bk[(number2 / 2)]);
        }
        System.Console.WriteLine();
        // ３枚目
        System.Console.WriteLine("[future]");
        System.Console.WriteLine(cards[(number3 / 2)] + "(" + frbk[(number3 % 2)] + ")");
        if(0 == (number3 % 2)){ // 正位置
            System.Console.WriteLine(means_fr[(number3 / 2)]);
        }
        else{ // 逆位置
            System.Console.WriteLine(means_bk[(number3 / 2)]);
        }
    }
}
