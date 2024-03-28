using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubPoint : MonoBehaviour
{
    private float point;
    private float add;
    private float crrect;

    public SubPoint() {
        point = 0;
        add = 0;
        crrect = 1;
    }

    public void classCalc(int att) {
        if (att == 0) {
            add = add + 5;
        }
        else if (att == 1) {
            add = add + 3;
        }
        else if (att == 2) {
            add = add + 1;
        }

        if (point < 100) {
            point = point + (add * crrect);

            if (point > 100) {
                point = 100;
            }
        }
    }

}
