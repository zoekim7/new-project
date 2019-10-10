using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemName3 : MonoBehaviour
{
    public Text ScriptTxt;
    string test;

    public void test3()
    {
        var itemMap3 = new Dictionary<int, string>();

        itemMap3.Add(0, "장검");
        itemMap3.Add(1, "단검");
        itemMap3.Add(2, "쌍검");
        itemMap3.Add(3, "대검");
        itemMap3.Add(4, "장궁");
        itemMap3.Add(5, "석궁");
        itemMap3.Add(6, "활");
        itemMap3.Add(7, "단봉");
        itemMap3.Add(8, "장봉");
        itemMap3.Add(9, "경찰봉");
        itemMap3.Add(10, "총검");
        itemMap3.Add(11, "수리검");
        itemMap3.Add(12, "철퇴");
        itemMap3.Add(13, "전기충격기");
        itemMap3.Add(14, "방패");
        itemMap3.Add(15, "권총");
        itemMap3.Add(16, "리볼버");
        itemMap3.Add(17, "기관총");
        itemMap3.Add(18, "LR11011101");
        itemMap3.Add(19, "소총");
        itemMap3.Add(20, "저격총");
        itemMap3.Add(21, "샷건");
        itemMap3.Add(22, "얼음방사기");
        itemMap3.Add(23, "화염방사기");
        itemMap3.Add(24, "마이크");
        itemMap3.Add(25, "일렉기타");
        itemMap3.Add(26, "소화기");
        itemMap3.Add(27, "전공책");
        itemMap3.Add(28, "드론");
        itemMap3.Add(29, "마우스");
        itemMap3.Add(30, "키보드");

        int num = Random.Range(0,30);

        if (itemMap3.TryGetValue(num, out string test))
        ScriptTxt.text = test;

    }
}
