using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MentalPoint : PhysicPoint
{
    // パラメータの初期化
    void Start() 
    {
        data.power = 20;
        Debug.Log("メンタルが" + data.power + "で初期化されました");
    }

    // 授業でのパラメータ計算
    public override void powerClassCalc(int powerAtt) {

        // 授業態度による点数の判定
        if (powerAtt == 0) {
            data.power = data.power - 3;
        }
        else if (powerAtt == 1) {
            data.power = data.power;
        }
        else if (powerAtt == 2) {
            data.power = data.power + 3;
        }

        Debug.Log("メンタルは" + data.power + "になりました");
        base.limit();

    }

    // powerHealthCalcで保険の授業での変化

    //　放課後での変化
    public void mentalAftSch(int mentalAtt) {
        if (mentalAtt == 0) {
            data.power = data.power + 7;
        }
        else if (mentalAtt == 1) {
            data.power = data.power + 5;
        }
        else if (mentalAtt == 2) {
            data.power = data.power + 3;
        }
        else if (mentalAtt == 3) {
            data.power = data.power + 1;
        }
        else if (mentalAtt == 4) {
            data.power = data.power - 1;
        }
        else if (mentalAtt == 5) {
            data.power = data.power - 3;
        }

        Debug.Log("メンタルは" + data.power + "になりました");
        base.limit();
    }


}
