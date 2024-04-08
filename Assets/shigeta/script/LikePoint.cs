using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LikePoint : PhysicPoint
{
    // パラメータの初期化
    public LikePoint () {
        power = 50;
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

    base.limit();

    }

    // powerHealthCalcで放課後での変化

    
}
