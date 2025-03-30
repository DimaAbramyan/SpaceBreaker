using UnityEngine;
using TMPro;

public class NumberShowingToPlayer : MonoBehaviour
{
    public DamageNumbPool Pool; // ������ public ��� ������ ����������
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
            Text.alpha = 1f; // ���������� ������������ ��� ���������
        }

        float randDir = Random.Range(0.25f, 2.8915f);
        float randPow = Random.Range(1.5f, 3.5f);
        VertDirection = Mathf.Sin(randDir);
        HorDirection = Mathf.Cos(randDir);
        StartSpeed = new Vector3(HorDirection, VertDirection * 4.5f, 0) * randPow;
    }

    void Update()
    {
        if (Text == null) return;

        Text.alpha -= 0.025f;
        transform.position += StartSpeed * 100 * Time.deltaTime;
        StartSpeed = new Vector3(StartSpeed.x, StartSpeed.y - 48f * Time.deltaTime, 0);

        if (Text.alpha <= 0.01f)
        {
            Pool?.ReturnToPool(gameObject);
        }
    }
}