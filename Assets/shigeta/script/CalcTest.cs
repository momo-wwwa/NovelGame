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
        Debug.Log("3パラメータインスタンスを生成しました");

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
            Debug.Log("授業態度良好（G）が選ばれました");
            jp.classCalc(0);
            mental.powerClassCalc(0);
            jpLike.powerClassCalc(0);
        }
        else if (Input.GetKeyDown(KeyCode.H)) {
            Debug.Log("授業態度並（H）が選ばれました");
            jp.classCalc(1);
            mental.powerClassCalc(1);
            jpLike.powerClassCalc(1);
        }
        else if (Input.GetKeyDown(KeyCode.I)) {
            Debug.Log("授業態度非行(I)が選ばれました");
            jp.classCalc(2);
            mental.powerClassCalc(2);
            jpLike.powerClassCalc(2);
        }

        // ６教科の補正値のカウント開始
        if (Input.GetKeyDown(KeyCode.J)) {
            Debug.Log("補正値のカウント（J）が開始されました");
            jp.crrectCount();
        }

        // 体育での体力値の変移
        if (Input.GetKeyDown(KeyCode.O)) {
            Debug.Log("体育（O）が選択されました");
            physic.powerHealthCalc();
        }

        // 保健でのメンタル値の変移
        if (Input.GetKeyDown(KeyCode.P)) {
            Debug.Log("保健（P）が選択されました");
            mental.powerHealthCalc();
        }

        // 放課後での教師好感度の変移
        if (Input.GetKeyDown(KeyCode.Q)) {
            Debug.Log("放課後の好感度の変更(Q)が選択されました");
            jpLike.powerHealthCalc();
        }

        // ６教科の放課後の点数の計算
        if (Input.GetKeyDown(KeyCode.K)) {
            Debug.Log("放課後の国語の勉強（K）が選択されました");
            jp.aftSchCalc();
        }

        // 部活での体力値の変移
        if (Input.GetKeyDown(KeyCode.L)) {
            Debug.Log("部活態度良好（L）が選択されました");
            physic.powerClassCalc(0);
        }
        else if (Input.GetKeyDown(KeyCode.M)) {
            Debug.Log("部活態度並（M）が選択されました");
            physic.powerClassCalc(1);
        }
        else if (Input.GetKeyDown(KeyCode.N)) {
            Debug.Log("部活態度非行（N）が選択されました");
            physic.powerClassCalc(2);
        }

        // 放課後の行動によるメンタル値の変移
        if (Input.GetKeyDown(KeyCode.R)) {
            Debug.Log("放課後に保健室(R)が選ばれました");
            mental.mentalAftSch(0);
        }
        else if (Input.GetKeyDown(KeyCode.S)) {
            Debug.Log("放課後に、メンタルの変移２（s）が選ばれました");
            mental.mentalAftSch(1);
        }
        else if (Input.GetKeyDown(KeyCode.T)) {
            Debug.Log("放課後にメンタルの変移３(T)が選ばれました");
            mental.mentalAftSch(2);
        }
        else if (Input.GetKeyDown(KeyCode.U)) {
            Debug.Log("放課後にメンタルの変移4(U)が選ばれました");
            mental.mentalAftSch(3);
        }
        else if (Input.GetKeyDown(KeyCode.V)) {
            Debug.Log("放課後にメンタルの変移５(V)が選ばれました");
            mental.mentalAftSch(4);
        }
        else if (Input.GetKeyDown(KeyCode.W)) {
            Debug.Log("放課後にメンタルの変移６(W)が選ばれました");
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
