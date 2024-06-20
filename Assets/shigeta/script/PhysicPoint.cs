using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicPoint : MonoBehaviour
{
    // パラメータの関数を宣言
    protected int power;

    // パラメータの初期化
    void Start() 
    {
        power = 0;
        Debug.Log("体力" + power + "に初期化されました");
    }

    // 部活でのパラメータ計算
    public virtual void powerClassCalc(int powerAtt) {

        // 態度による点数の判定
        if (powerAtt == 0) {
            power = power + 7;
        }
        else if (powerAtt == 1) {
            power = power + 5;
        }
        else if (powerAtt == 2) {
            power = power + 3;
        }

        Debug.Log("体力が" + power + "に変更されました");
        limit();

    }

    // 体育での変化
    public void powerHealthCalc () {
        power = power + 5;
        Debug.Log("体力が体育で" + power + "に変更されました");
        limit();
    }

    public void limit() {
        if (power > 100) {
            power = 100;
            Debug.Log("体力が" + power + "に変更され、上限に達しました");
        }
        else if (power < 0) {
            power = 0;
            Debug.Log("体力が" + power + "に変更され、下限に達しました");
        }
    }

    public int deliverPower () {
        return power;
    }
}
