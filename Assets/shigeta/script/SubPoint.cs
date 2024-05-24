using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubPoint : Sub
{
    // 別のメソッドでも動くフィールド関数を宣言
    protected double point;
    protected double add;
    protected double crrect;
    protected int counter;

    void Start() 
    {
        // フィールド関数の初期化
        point = 0;
        add = 0;
        crrect = 1;
        counter = 0;
        Debug.Log("4つ変数を初期化しました");
    }

    // 授業のパラメータ計算
    public void classCalc(int att) 
    {

        // 授業態度による点数の判定
        if (att == 0) 
        {
            add = add + 5;
        }
        else if (att == 1) 
        {
            add = add + 3;
        }
        else if (att == 2) 
        {
            add = add + 1;
        }
        Debug.Log("追加する点数が" + add + "に設定されました");

        // 点数の追加及び上限制御
        if (point < 100) 
        {
            point = point + (add * crrect);
            Debug.Log("点数が追加され" + point + "に変更されました");

            if (point > 100) 
            {
                point = 100;
            }
        }
        Debug.Log("点数が" + point + "に変更され、上限に達しました");

        // 補正値の管理
        if (counter >= 1) 
        {
            crrectCount();
        }
    }

    // 補正値とカウンターの変更
    public void crrectCount () 
    {
        counter += 1;
        crrect = crrect * 1.1;
        Debug.Log("補正値が" + crrect + "に変更されました");
        Debug.Log("補正値用のカウンターが" + counter + "に変更されました");

        // 初期化
        if (counter > 4 || counter <= 0) 
        {
            counter = 0;
            crrect = crrect / 1.1;
            Debug.Log("補正値が" + crrect + "に変更されました");
            Debug.Log("補正値用のカウンターが" + counter + "に変更されました");
        }
    }

    // 放課後の点数計算
    public void aftSchCalc () 
    {
        point = point + (2 * crrect);
        Debug.Log("点数が" + point + "に変更されました");

        if (point > 100) 
        {
            point = 100;
            Debug.Log("点数が" + point + "に変更され、上限に達しました");
        }
    }

    // 点数を取り出し可能にする
    public double deliver () 
    {
        return point;
    }

    // HrSubPoint用の空メソッド
    public virtual void hrCrrCount() 
    {

    }


}
