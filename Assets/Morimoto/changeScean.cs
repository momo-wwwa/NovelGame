using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//追加
using UnityEngine.SceneManagement;//シーン切り替えに必要

public class changeScean : MonoBehaviour
{
    public Button ASclub_1;
    public Button AShome_1;
    public Button ASlibraly_1;

    public void MoveA()
    {
        SceneManager.LoadScene("ASclub_1");
    }

    public void MoveB()
    {
        SceneManager.LoadScene("AShome_1");
    }

    public void MoveC()
    {
        SceneManager.LoadScene("ASlibraly_1");
    }
}