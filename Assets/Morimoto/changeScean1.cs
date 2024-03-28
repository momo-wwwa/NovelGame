using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScean1 : MonoBehaviour
{
    public void SwitchScene()
    {
        SceneManager.LoadScene("Scene_morimoto2",LoadSceneMode.Single);
        Debug.Log("押された！");
    }
}
