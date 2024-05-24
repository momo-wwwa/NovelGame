using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LikePoint : PhysicPoint
{
    // パラメータの初期化
    void Start() 
    {
        power = 50;
        Debug.Log("好感度は" + power + "に初期化されました");
    }

    // 授業でのパラメータ計算
    public override void powerClassCalc(int powerAtt) {

        // 授業態度による点数の判定
        if (powerAtt == 0) {
            power = power + 5;
        }
        else if (powerAtt == 1) {
            power = power;
        }
        else if (powerAtt == 2) {
            power = power - 5;
        }

        Debug.Log("好感度は" + power + "に変更されました");
        base.limit();

    }

    // powerHealthCalcで放課後での変化

    
}
