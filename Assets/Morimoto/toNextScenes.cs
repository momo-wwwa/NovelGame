using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;//シーン切り替えに必要

public class toNextScenes : MonoBehaviour
{
    public TMPro.TMP_Text clickCountText; // ボタンが押された回数を表示するテキスト
    private int clickCount = 0; // ボタンが押された回数

    void Start()
    {
        if (clickCountText == null)
    {
        Debug.LogError("clickCountText is not assigned!");
        return;
    }
        // シーンが読み込まれた時に保存された回数をロードする
        if (PlayerPrefs.HasKey("ClickCount"))
        {
            clickCount = PlayerPrefs.GetInt("ClickCount");
        }
        UpdateClickCountText();
    }

    public void OnButtonClick()
    {
        clickCount++; // ボタンが押された回数を増やす
        PlayerPrefs.SetInt("ClickCount", clickCount); // 回数を保存する
        UpdateClickCountText(); // テキストを更新する
        SceneManager.LoadScene("InGamePlayScene");
    }

    void UpdateClickCountText()
    {
        clickCountText.text = "Button Clicks: " + clickCount.ToString(); // テキストを更新する
    }

    public void OnResetButtonClick(){
        clickCount = 0; // ボタンが押された階数を0にする
        PlayerPrefs.SetInt("ClickCount", clickCount); // 回数を保存する
        UpdateClickCountText(); // テキストを更新する
    }
}
