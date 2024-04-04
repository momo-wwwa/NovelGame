using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider healthSlider;
    public Slider mentalSlider;


    // 最大値を設定します
    public float maxHealth = 100f;
    public float maxMental = 100f;

    // 現在の値を保持します
    private float currentHealth;
    private float currentMental;

    void Start()
    {
        // 初期化、初期の値は割4とかにする？
        currentHealth = maxHealth;
        currentMental = maxMental;

        // Sliderの最大値を設定します
        healthSlider.maxValue = maxHealth;
        mentalSlider.maxValue = maxMental;

        // 初期の値を反映します
        UpdateSliders();
    }

    void Update()
    {
        // 仮の更新処理
        // ここではデモ用にランダムな値を減らしているだけ
        currentHealth -= Random.Range(0f, 1f);
        currentMental -= Random.Range(0f, 1f);

        // 値が0未満にならないように調整します
        currentHealth = Mathf.Max(currentHealth, 0f);
        currentMental = Mathf.Max(currentMental, 0f);

        // Sliderを更新します
        UpdateSliders();
    }

    void UpdateSliders()
    {
        // Sliderのvalueを現在の値に更新します
        healthSlider.value = currentHealth;
        mentalSlider.value = currentMental;

    }
}
