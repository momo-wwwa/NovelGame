using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class select_subject_sugiwaka : MonoBehaviour
{
    Button buttonInstance;
    Button[] = buttons;

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            var button = Instantiate<Button>(buttonInstance);
            button.transform.position = new Vector3(0, i * 10, 0);
            buttons[i] = button;
            var buttonText = testButton.transform.GetChild(0).GetComponent<Text>();
            buttonText.text = $"button {i}";
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}

