using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemName : MonoBehaviour
{
    public Text ScriptTxt;
    string test;

    public void test1()
    {
        var itemMap = new Dictionary<int, string>();

        itemMap.Add(0, "따스한");
        itemMap.Add(1, "시린");
        itemMap.Add(2, "쓰라린");
        itemMap.Add(3, "오묘한");
        itemMap.Add(4, "애매한");
        itemMap.Add(5, "망가진");
        itemMap.Add(6, "어디서 본");
        itemMap.Add(7, "종이로 만든");
        itemMap.Add(8, "앙증맞은");
        itemMap.Add(9, "거대한");
        itemMap.Add(10, "저무는");
        itemMap.Add(11, "오래된");
        itemMap.Add(12, "빛나는");
        itemMap.Add(13, "시끄러운");
        itemMap.Add(14, "고요한");
        itemMap.Add(15, "알 수 없는");
        itemMap.Add(16, "무딘");
        itemMap.Add(17, "날카로운");
        itemMap.Add(18, "떠오르는");
        itemMap.Add(19, "가라앉은");
        itemMap.Add(20, "녹아버린");
        itemMap.Add(21, "무거운");
        itemMap.Add(22, "가벼운");
        itemMap.Add(23, "타오르는");
        itemMap.Add(24, "완벽한");
        itemMap.Add(25, "평범한");
        itemMap.Add(26, "라면국물을 쏟은");
        itemMap.Add(27, "특별한");
        itemMap.Add(28, "튼튼한");
        itemMap.Add(29, "여린");
        itemMap.Add(30, "살아있는");

        int num = Random.Range(0,30);

        if (itemMap.TryGetValue(num, out string test))
        ScriptTxt.text = test;

    }
}
