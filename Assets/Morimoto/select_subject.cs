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
    

    void AddSubject(string subject)
    {
        plan[a] = subject;
        Debug.Log("Added subject: " + subject);
        Debug.Log("Current plan: " + string.Join(", ", plan));
        a = (a + 1) % 4; // インデックスの更新
    }

    public void OnMathButtonClicked()
    {
        if (plan[3] != null){
            Debug.Log("You can't chouse more subject &" + string.Join(", ", plan));
        }
        else {
            AddSubject("Math");
        }
        
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
