using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    [SerializeField] private Image fill;
    public void SetHealth(float health)
    {
        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
    public void Update()
    {
       FirstShip ship  = FindObjectOfType<FirstShip>();
        switch (gameObject.name)
        {
            case "ShieldBar":
                {

                    SetHealth(ship._current_SP / (ship.ship_Data._max_SP / 100));
                        break;
                }
            case "HealthBar":
                {

                    SetHealth(ship._current_HP / (ship.ship_Data._max_HP / 100));
                    break;
                }
        }
    }
}
