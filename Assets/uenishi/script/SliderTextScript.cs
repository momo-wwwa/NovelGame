using UnityEngine;
using UnityEngine.UI;

public class SliderTextScript : MonoBehaviour
{
    public Slider healthSlider; // 体力を表すSlider
    public Slider mentalSlider; // 精神力を表すSlider

    public Image healthBar; // 体力を表す棒グラフのImage
    public Image mentalBar; // 精神力を表す棒グラフのImage

    void Update()
    {
        // 体力と精神力の値を取得
        float currentHealth = healthSlider.value;
        float currentMental = mentalSlider.value;

        // 棒グラフの長さを調整
        AdjustBarLength(healthBar, currentHealth);
        AdjustBarLength(mentalBar, currentMental);
    }

    // 棒グラフの長さを調整する関数
    void AdjustBarLength(Image bar, float value)
    {
        // 棒グラフの長さを更新
        bar.rectTransform.sizeDelta = new Vector2(value, bar.rectTransform.sizeDelta.y);
    }
}
