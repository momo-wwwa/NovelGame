using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider mentalSlider;
    public Slider healthSlider;

    // 初期化
    void Start()
    {
        // 精神力の初期値を設定
        mentalSlider.value = 20f;
        // 体力の初期値を設定
        healthSlider.value = 20f;
    }

    // 精神力を変更するメソッド
    public void SetMentalValue(float value)
    {
        // 現在の精神力の値を取得
        float currentMentalValue = mentalSlider.value;
        // 渡された値を現在の値からの変化量として扱う
        float newValue = Mathf.Clamp(currentMentalValue + value, 0f, 100f); // 値の範囲を制限する
        mentalSlider.value = newValue;
    }

    // 体力を変更するメソッド
    public void SetHealthValue(float value)
    {
        // 現在の体力の値を取得
        float currentHealthValue = healthSlider.value;
        // 渡された値を現在の値からの変化量として扱う
        float newValue = Mathf.Clamp(currentHealthValue + value, 0f, 100f); // 値の範囲を制限する
        healthSlider.value = newValue;
    }
}
