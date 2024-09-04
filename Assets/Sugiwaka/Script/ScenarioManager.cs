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

            // シナリオのリストを初期化
            scenarios = new List<string>()
            {
                "シナリオA: 主人公は元気で好かれています。",
                "シナリオB: 主人公は元気だが、メンタルが疲れています。",
                "シナリオC: 主人公は体力もなく、嫌われている。",
                "シナリオD: 主人公は普通の状態です。"
            };

            // ランダムシナリオを再生
            PlayRandomScenario();
        }

        // シナリオのパラメータに基づいてシナリオを選定する
        void DetermineScenario()
        {
            int power = physicPoint.deliverPower();
            int mental = mentalPoint.deliverPower();
            int like = likePoint.deliverPower();
            double sub = subPoint.deliver();

            if (power > 80 && mental > 50 && like > 60)
            {
                Debug.Log(scenarios[0]); // シナリオA
            }
            else if (power > 50 && mental < 30)
            {
                Debug.Log(scenarios[1]); // シナリオB
            }
            else if (power < 30 && like < 40)
            {
                Debug.Log(scenarios[2]); // シナリオC
            }
            else
            {
                Debug.Log(scenarios[3]); // シナリオD
            }
        }

        // ランダムでシナリオを選んで再生する
        void PlayRandomScenario()
        {
            int randomScenario = Random.Range(0, scenarios.Count); // シナリオの数に応じてランダムに選択

            Debug.Log("ランダムシナリオ: " + scenarios[randomScenario]);
            // 必要ならここでさらにシナリオを実行するロジックを追加
        }
    }
}
