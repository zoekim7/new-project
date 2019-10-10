using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemName2 : MonoBehaviour
{
    public Text ScriptTxt;
    string test;

    public void test2()
    {
        var itemMap2 = new Dictionary<int, string>();

        itemMap2.Add(0, "바다의");
        itemMap2.Add(1, "대지의");
        itemMap2.Add(2, "황혼의");
        itemMap2.Add(3, "구름의");
        itemMap2.Add(4, "새벽의");
        itemMap2.Add(5, "은하의");
        itemMap2.Add(6, "오수의");
        itemMap2.Add(7, "맹독의");
        itemMap2.Add(8, "번개의");
        itemMap2.Add(9, "폭풍의");
        itemMap2.Add(10, "태양의");
        itemMap2.Add(11, "초승달");
        itemMap2.Add(12, "보름달");
        itemMap2.Add(13, "겨울의");
        itemMap2.Add(14, "초목");
        itemMap2.Add(15, "유리");
        itemMap2.Add(16, "철제");
        itemMap2.Add(17, "플라스틱");
        itemMap2.Add(18, "과거의");
        itemMap2.Add(19, "미래의");
        itemMap2.Add(20, "추억의");
        itemMap2.Add(21, "줄무늬");
        itemMap2.Add(22, "소나기");
        itemMap2.Add(23, "스모그");
        itemMap2.Add(24, "안개비");
        itemMap2.Add(25, "잿빛");
        itemMap2.Add(26, "최첨단");
        itemMap2.Add(27, "구식");
        itemMap2.Add(28, "고급");
        itemMap2.Add(29, "사라진");
        itemMap2.Add(30, "ERROR ::"); // 정말 에러인 것이 아니고, 에러란 이름이 있으면 어떨까? 하는 마음에 삽입해보았습니다.

        int num = Random.Range(0, 30);

        if (itemMap2.TryGetValue(num, out string test))
            ScriptTxt.text = test;

    }
}
