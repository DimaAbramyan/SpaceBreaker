using UnityEngine;
using TMPro;

public class NumberShowingToPlayer : MonoBehaviour
{
    public DamageNumbPool Pool; // Сделал public для явного назначения
    private float VertDirection;
    private float HorDirection;
    Vector3 StartSpeed;
    private TextMeshProUGUI Text;

    private void Awake()
    {
        Text = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        if (Text != null)
        {
            Text.alpha = 1f; // Сбрасываем прозрачность при активации
        }

        float randDir = Random.Range(0.25f, 2.8915f);
        float randPow = Random.Range(1.5f, 3.5f);
        VertDirection = Mathf.Sin(randDir);
        HorDirection = Mathf.Cos(randDir);
        StartSpeed = new Vector3(HorDirection, VertDirection * 0.75f, 0) * randPow;
    }

    void FixedUpdate()
    {
        if (Text == null) return;

        Text.alpha -= 0.1f;
        transform.position += StartSpeed * 10;
        StartSpeed = new Vector3(StartSpeed.x, StartSpeed.y - 0.048f, 0);

        if (Text.alpha <= 0.01f)
        {
            Pool?.ReturnToPool(gameObject);
        }
    }
}