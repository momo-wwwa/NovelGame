using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioManager : MonoBehaviour
{
    public PhysicPoint physicPoint;
    public MentalPoint mentalPoint;
    public LikePoint likePoint;
    public SubPoint subPoint;

    void Start()
    {
        physicPoint = gameObject.AddComponent<PhysicPoint>();
        mentalPoint = gameObject.AddComponent<MentalPoint>();
        likePoint = gameObject.AddComponent<LikePoint>();
        subPoint = gameObject.AddComponent<SubPoint>();

        // パラメータを初期化
        //physicPoint.Start();
        //entalPoint.Start();
        //likePoint.Start();
        //SubPoint.Start();

        // シナリオの分岐
        DetermineScenario();
    }

    void DetermineScenario()
    {
        int power = physicPoint.deliverPower();
        int mental = mentalPoint.deliverPower();
        int like = likePoint.deliverPower();
        double sub = subPoint.deliver();

        if (power > 80 && mental > 50 && like > 60)
        {
            Debug.Log("シナリオA: 主人公は元気で好かれています。");
        }
        else if (power > 50 && mental < 30)
        {
            Debug.Log("シナリオB: 主人公は元気だが、メンタルが疲れています。");
        }
        else if (power < 30 && like < 40)
        {
            Debug.Log("シナリオC: 主人公は体力もなく、嫌われている。");
        }
        else
        {
            Debug.Log("シナリオD: 主人公は普通の状態です。");
        }
    }
}
