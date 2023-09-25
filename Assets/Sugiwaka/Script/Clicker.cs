using UnityEngine;
using System.Collections;

public class Clicker : MonoBehaviour
{
    public int numClicksNeeded = 10;
    private int numClicks = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            numClicks++;
            Debug.Log("Hello World!");

            if (numClicks == numClicksNeeded)
            {
                Debug.Log("You reached " + numClicksNeeded + " clicks!");
            }
        }
    }
}
