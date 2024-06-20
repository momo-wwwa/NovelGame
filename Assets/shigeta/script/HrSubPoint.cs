using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HrSubPoint : SubPoint
{
    protected int midSemCounter;

    void Start()
    {
        // フィールド関数の初期化
        crrect = 1.2;
        midSemCounter = 1;
        Debug.Log("補正値は" + crrect + "に初期化されました");
        Debug.Log("補正値用のカウンターは" + midSemCounter + "に初期化されました");
    }

    // 担任補正値の管理
    public override void hrCrrCount() 
    {
        if ((midSemCounter >= 1) && (midSemCounter <= 7) ) {
            midSemCounter = midSemCounter + 1;
        }
        else {
            midSemCounter = 0;
            crrect = crrect / 1.2;
            Debug.Log("補正値は" + crrect + "に変更されました");
            Debug.Log("補正値用のカウンターは" + midSemCounter + "に変更されました");
        }
    }

}
