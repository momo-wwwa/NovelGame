using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NovelGame
{
    public class ScenarioManager : MonoBehaviour
    {
        public PhysicPoint physicPoint;
        public MentalPoint mentalPoint;
        public LikePoint likePoint;
        public SubPoint subPoint;

        private List<string> scenarios;

        void Start()
        {
            physicPoint = gameObject.AddComponent<PhysicPoint>();
            mentalPoint = gameObject.AddComponent<MentalPoint>();
            likePoint = gameObject.AddComponent<LikePoint>();
            subPoint = gameObject.AddComponent<SubPoint>();

            // �V�i���I�̃��X�g��������
            scenarios = new List<string>()
            {
                "�V�i���IA: ��l���͌��C�ōD����Ă��܂��B",
                "�V�i���IB: ��l���͌��C�����A�����^�������Ă��܂��B",
                "�V�i���IC: ��l���̗͑͂��Ȃ��A�����Ă���B",
                "�V�i���ID: ��l���͕��ʂ̏�Ԃł��B"
            };

            // �����_���V�i���I���Đ�
            PlayRandomScenario();
        }

        // �V�i���I�̃p�����[�^�Ɋ�Â��ăV�i���I��I�肷��
        void DetermineScenario()
        {
            int power = physicPoint.deliverPower();
            int mental = mentalPoint.deliverPower();
            int like = likePoint.deliverPower();
            double sub = subPoint.deliver();

            if (power > 80 && mental > 50 && like > 60)
            {
                Debug.Log(scenarios[0]); // �V�i���IA
            }
            else if (power > 50 && mental < 30)
            {
                Debug.Log(scenarios[1]); // �V�i���IB
            }
            else if (power < 30 && like < 40)
            {
                Debug.Log(scenarios[2]); // �V�i���IC
            }
            else
            {
                Debug.Log(scenarios[3]); // �V�i���ID
            }
        }

        // �����_���ŃV�i���I��I��ōĐ�����
        void PlayRandomScenario()
        {
            int randomScenario = Random.Range(0, scenarios.Count); // �V�i���I�̐��ɉ����ă����_���ɑI��

            Debug.Log("�����_���V�i���I: " + scenarios[randomScenario]);
            // �K�v�Ȃ炱���ł���ɃV�i���I�����s���郍�W�b�N��ǉ�
        }
    }
}
