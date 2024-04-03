using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class select_subject : MonoBehaviour
{
    public Button math;
    public Button japanese;
    public Button physics;
    public Button history;
    public Button PE;
    public Button english;
    public Button chemistry;
    string[] plan = new string[4];//配列に今日の授業を入れる

    int a = 0;
    void Start()
    {
        // plan = new string[] {"nothing", "nothing", "nothing", "nothing"}; 
        // a = 0;
    }
    /*public void chose_math()

    {
        plan[a] = "math";
        Debug.Log("math");
        a = (a + 1) % 4;
        Debug.Log(string.Join(", ", plan));
    }

    public void chose_japanese()
    {
        plan[a] = "japanese";
        Debug.Log("japanese");
        a = (a + 1) % 4;
        Debug.Log(string.Join(", ", plan));
    }
    
    public void chose_PE()
    {
        plan[a] = "PE";
        Debug.Log("PE");
        a = (a + 1) % 4;
        Debug.Log(string.Join(", ", plan));
    }
    public void chose_english()
    {
        plan[a] = "english";
        Debug.Log("english");
        a = (a + 1) % 4;
        Debug.Log(string.Join(", ", plan));
    }
    public void chose_physics()
    {
        plan[a] = "physics";
        Debug.Log("physics");
        a = (a + 1) % 4;
        Debug.Log(string.Join(", ", plan));
    }
    public void chose_history()
    {
        plan[a] = "history";
        Debug.Log("history");
        a = (a + 1) % 4;
        Debug.Log(string.Join(", ", plan));
    }
    public void chose_chemistry()
    {
        plan[a] = "chemistry";
        Debug.Log("chemistry");
        a = (a + 1) % 4;
        Debug.Log(string.Join(", ", plan));
    }


    */

    void AddSubject(string subject)
    {
        plan[a] = subject;
        Debug.Log("Added subject: " + subject);
        Debug.Log("Current plan: " + string.Join(", ", plan));
        a = (a + 1) % 4; // インデックスの更新
    }

    public void OnMathButtonClicked()
    {
        AddSubject("Math");
    }

    public void OnJapaneseButtonClicked()
    {
        AddSubject("Japanese");
    }

    public void OnPhysicsButtonClicked()
    {
        AddSubject("Physics");
    }

    public void OnHistoryButtonClicked()
    {
        AddSubject("History");
    }

    public void OnPEButtonClicked()
    {
        AddSubject("PE");
    }

    public void OnEnglishButtonClicked()
    {
        AddSubject("English");
    }

    public void OnChemistryButtonClicked()
    {
        AddSubject("Chemistry");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
