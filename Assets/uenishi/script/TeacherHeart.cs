using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacherHeart : MonoBehaviour
{
    //現在の担任好感度もInGameControllerにあると仮定して書いています
    // 各ハートアイコンのGameObjectへの参照
    public GameObject heart100;
    public GameObject heart75;
    public GameObject heart50;
    public GameObject heart25;
    public GameObject heart0;


    private InGameMainController inGameController;

    //
     private int currentHeartScore;



    // Start is called before the first frame update
    void Start()
    {   
        //現在の担任好感度をInGameControllerからもってくる
        inGameController = FindObjectOfType<InGameMainController>();

        // 現在の担任好感度を取得するためにInGameMainController内のメソッドを呼び出す
        currentHeartScore = inGameController.GetCurrentTeacherHeartScore();　//ここでInGameControllerの中の現在の担任好感度を返り値としているメソッドを呼び出すため、このプログラム書く人のコードみてGetCurrentTeacherHeartScoreという名前を変える
        // 現在のスコアに基づいてハートアイコンを更新するメソッドを呼び出す
        UpdateHeartIcon();
    }

    // Update is called once per frame
    void Update()
    {
        //後ろでずっと表示しとくならここか
    }

    // 現在のハートスコアに基づいてハートアイコンを更新するメソッド
    void UpdateHeartIcon()
    {
        // すべてのハートアイコンを非アクティブ化
        heart100.SetActive(false);
        heart75.SetActive(false);
        heart50.SetActive(false);
        heart25.SetActive(false);
        heart0.SetActive(false);

        // 適切なアイコンをアクティブ化
        if (currentHeartScore >= 100)
        {
            heart100.SetActive(true);
        }
        else if (currentHeartScore >= 75)
        {
            heart75.SetActive(true);
        }
        else if (currentHeartScore >= 50)
        {
            heart50.SetActive(true);
        }
        else if (currentHeartScore >= 25)
        {
            heart25.SetActive(true);
        }
        else
        {
            heart0.SetActive(true);
        }
    }
}
