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
     public Button next;
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
        
        // if(plan[3] != null){
        //     next.interactable = true;
        // }
    }

    public void OnJapaneseButtonClicked()
    {
        if (plan[3] != null){
            Debug.Log("You can't chouse more subject &" + string.Join(", ", plan));
        }
        else {
            AddSubject("japanese");
        }
    }

    public void OnPhysicsButtonClicked()
    {
        if (plan[3] != null){
            Debug.Log("You can't chouse more subject &" + string.Join(", ", plan));
        }
        else {
            AddSubject("physics");
        }
    }

    public void OnHistoryButtonClicked()
    {
        if (plan[3] != null){
            Debug.Log("You can't chouse more subject &" + string.Join(", ", plan));
        }
        else {
            AddSubject("History");
        }
    }

    public void OnPEButtonClicked()
    {
        if (plan[3] != null){
            Debug.Log("You can't chouse more subject &" + string.Join(", ", plan));
        }
        else {
            AddSubject("PE");
        }
    }

    public void OnEnglishButtonClicked()
    {
        if (plan[3] != null){
            Debug.Log("You can't chouse more subject &" + string.Join(", ", plan));
        }
        else {
            AddSubject("English");
        }
    }

    public void OnChemistryButtonClicked()
    {
        if (plan[3] != null){
            Debug.Log("You can't chouse more subject &" + string.Join(", ", plan));
        }
        else {
            AddSubject("Chemistry");
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
