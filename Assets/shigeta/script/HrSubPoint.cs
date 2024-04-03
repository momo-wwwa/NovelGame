using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HrSubPoint : SubPoint
{
     protected int midSemCounter;

     public HrSubPoint() {
        // フィールド関数の初期化
        crrect = 1.2;
        midSemCounter = 1;
    }

    // 担任補正値の管理
    public void hrCrrCount() {
        if ((midSemCounter >= 1) && (midSemCounter <= 7) ) {
            midSemCounter = midSemCounter + 1;
        }
        else {
            midSemCounter = 0;
            crrect = crrect / 1.2;
        }
    }

}
