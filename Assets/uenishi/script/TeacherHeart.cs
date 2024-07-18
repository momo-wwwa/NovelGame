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



private int currentHeartScore = 40;

void Start()
{
    
    UpdateHeartIcon();
}


void Update()
{
    
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