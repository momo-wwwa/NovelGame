using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CalcTest : MonoBehaviour
{
    // パラメータ用の変数を宣言
    private SubPoint jp;
    private SubPoint mth;
    private SubPoint en;
    private SubPoint chem;
    private SubPoint phys;
    private SubPoint hist;
    private MentalPoint mental;
    private PhysicPoint physic;
    private LikePoint jpLike;

    // Start is called before the first frame update
    void Start()
    {
        // ３パラメータ：インスタンスを生成
        mental = new MentalPoint();
        physic = new PhysicPoint();
        jpLike = new LikePoint();

        // ６教科：インスタンスを生成
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.B) ||
            Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.D) ||
            Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.F))
        {
            Generation(Input.inputString);
        }
    }

    // Update is called once per frame
    void Update()
    {

        // ６教科の授業の点数の計算・メンタル値の変移・教師好感度の変移
        if (Input.GetKeyDown(KeyCode.G)) {
            jp.classCalc(0);
            mental.powerClassCalc(0);
            jpLike.powerClassCalc(0);
        }
        else if (Input.GetKeyDown(KeyCode.H)) {
            jp.classCalc(1);
            mental.powerClassCalc(1);
            jpLike.powerClassCalc(1);
        }
        else if (Input.GetKeyDown(KeyCode.I)) {
            jp.classCalc(2);
            mental.powerClassCalc(2);
            jpLike.powerClassCalc(2);
        }

        // ６教科の補正値のカウント開始
        if (Input.GetKeyDown(KeyCode.J)) {
            jp.crrectCount();
        }

        // 体育での体力値の変移
        if (Input.GetKeyDown(KeyCode.O)) {
            physic.powerHealthCalc();
        }

        // 保健でのメンタル値の変移
        if (Input.GetKeyDown(KeyCode.P)) {
            mental.powerHealthCalc();
        }

        // 放課後での教師好感度の変移
        if (Input.GetKeyDown(KeyCode.P)) {
            jpLike.powerHealthCalc();
        }

        // ６教科の放課後の点数の計算
        if (Input.GetKeyDown(KeyCode.K)) {
            jp.aftSchCalc();
        }

        // 部活での体力値の変移
        if (Input.GetKeyDown(KeyCode.L)) {
            physic.powerClassCalc(0);
        }
        else if (Input.GetKeyDown(KeyCode.M)) {
            physic.powerClassCalc(1);
        }
        else if (Input.GetKeyDown(KeyCode.N)) {
            physic.powerClassCalc(2);
        }

        // 放課後の行動によるメンタル値の変移
        if (Input.GetKeyDown(KeyCode.Q)) {
            mental.mentalAftSch(0);
        }
        else if (Input.GetKeyDown(KeyCode.R)) {
            mental.mentalAftSch(1);
        }
        else if (Input.GetKeyDown(KeyCode.S)) {
            mental.mentalAftSch(2);
        }
        else if (Input.GetKeyDown(KeyCode.T)) {
            mental.mentalAftSch(3);
        }
        else if (Input.GetKeyDown(KeyCode.U)) {
            mental.mentalAftSch(4);
        }
        else if (Input.GetKeyDown(KeyCode.V)) {
            mental.mentalAftSch(5);
        }


    }

    // 教科パラメータインスタンス生成用メソッド
    public void Generation(string key)
    {
        if (key == "a") {
            jp = new HrSubPoint();
            mth = new SubPoint();
            en = new SubPoint();
            chem = new SubPoint();
            phys = new SubPoint();
            hist = new SubPoint();
            Debug.Log("国語が担任で教科パラメータが設定されました");
        }
        else if (key == "b") {
            mth = new HrSubPoint();
            jp = new SubPoint();
            en = new SubPoint();
            chem = new SubPoint();
            phys = new SubPoint();
            hist = new SubPoint();
            Debug.Log("数学が担任で教科パラメータが設定されました");
        }
        else if (key == "c") {
            en = new HrSubPoint();
            jp = new SubPoint();
            mth = new SubPoint();
            chem = new SubPoint();
            phys = new SubPoint();
            hist = new SubPoint();
            Debug.Log("英語が担任で教科パラメータが設定されました");
        }
        else if (key == "d") {
            chem = new HrSubPoint();
            jp = new SubPoint();
            mth = new SubPoint();
            en = new SubPoint();
            phys = new SubPoint();
            hist = new SubPoint();
            Debug.Log("化学が担任で教科パラメータが設定されました");
        }
        else if (key == "e") {
            phys = new HrSubPoint();
            jp = new SubPoint();
            mth = new SubPoint();
            en = new SubPoint();
            chem = new SubPoint();
            hist = new SubPoint();
            Debug.Log("物理が担任で教科パラメータが設定されました");
        }
        else if (key == "f") {
            hist = new HrSubPoint();
            jp = new SubPoint();
            mth = new SubPoint();
            en = new SubPoint();
            chem = new SubPoint();
            phys = new SubPoint();
            Debug.Log("歴史が担任で教科パラメータが設定されました");
        }
    }

}
