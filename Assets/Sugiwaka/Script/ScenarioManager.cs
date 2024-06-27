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

        // �p�����[�^��������
        //physicPoint.Start();
        //entalPoint.Start();
        //likePoint.Start();
        //SubPoint.Start();

        // �V�i���I�̕���
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
            Debug.Log("�V�i���IA: ��l���͌��C�ōD����Ă��܂��B");
        }
        else if (power > 50 && mental < 30)
        {
            Debug.Log("�V�i���IB: ��l���͌��C�����A�����^�������Ă��܂��B");
        }
        else if (power < 30 && like < 40)
        {
            Debug.Log("�V�i���IC: ��l���̗͑͂��Ȃ��A�����Ă���B");
        }
        else
        {
            Debug.Log("�V�i���ID: ��l���͕��ʂ̏�Ԃł��B");
        }
    }
}
