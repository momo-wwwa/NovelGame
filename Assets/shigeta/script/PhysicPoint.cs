using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicPoint : MonoBehaviour
{
    // ScriptableObjectを宣言
    public PhysicPointData data;

    // パラメータの初期化
    void Start() 
    {
        if (data != null)
        {
            data.power = 0;
            Debug.Log("体力" + data.power + "に初期化されました");
        }
    }

    // 部活でのパラメータ計算
    public virtual void powerClassCalc(int powerAtt) {

        if (data == null) return;

        // 態度による点数の判定
        if (powerAtt == 0) {
            data.power = data.power + 7;
        }
        else if (powerAtt == 1) {
            data.power = data.power + 5;
        }
        else if (powerAtt == 2) {
            data.power = data.power + 3;
        }

        Debug.Log("体力が" + data.power + "に変更されました");
        limit();

    }

    // 体育での変化
    public void powerHealthCalc () {
        if (data == null) return;
        
        data.power = data.power + 5;
        Debug.Log("体力が体育で" + data.power + "に変更されました");
        limit();
    }

    public void limit() {
        if (data == null) return;

        if (data.power > 100) {
            data.power = 100;
            Debug.Log("体力が" + data.power + "に変更され、上限に達しました");
        }
        else if (data.power < 0) {
            data.power = 0;
            Debug.Log("体力が" + data.power + "に変更され、下限に達しました");
        }
    }

    public int deliverPower () {
        if (data == null) return 0;
        return data.power;
    }
}
