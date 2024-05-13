using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MentalPoint : PhysicPoint
{
    // パラメータの初期化
    public MentalPoint () {
        power = 20;
        Debug.Log("メンタルが" + power + "で初期化されました");
    }

    // 授業でのパラメータ計算
    public override void powerClassCalc(int powerAtt) {

        // 授業態度による点数の判定
        if (powerAtt == 0) {
            power = power + 3;
        }
        else if (powerAtt == 1) {
            power = power;
        }
        else if (powerAtt == 2) {
            power = power - 3;
        }

        Debug.Log("メンタルは" + power + "になりました");
        base.limit();

    }

    // powerHealthCalcで保険の授業での変化

    //　放課後での変化
    public void mentalAftSch(int mentalAtt) {
        if (mentalAtt == 0) {
            power = power + 7;
        }
        else if (mentalAtt == 1) {
            power = power + 5;
        }
        else if (mentalAtt == 2) {
            power = power + 3;
        }
        else if (mentalAtt == 3) {
            power = power + 1;
        }
        else if (mentalAtt == 4) {
            power = power - 1;
        }
        else if (mentalAtt == 5) {
            power = power - 3;
        }

        Debug.Log("メンタルは" + power + "になりました");
        base.limit();
    }


}
