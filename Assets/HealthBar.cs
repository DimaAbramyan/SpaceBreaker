using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasGroup;
    public Slider slider;
    public Gradient gradient;
    [SerializeField] private Image fill;
    public void SetHealth(float health)
    {
        canvasGroup.alpha = 1f;
        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
    private void Start()
    {
        canvasGroup.GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0f;
    }
}
