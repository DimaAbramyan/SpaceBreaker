using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IHaveBuff : MonoBehaviour
{
    private SpriteRenderer objectRenderer;
    private Color targetColor;
    private float duration = 0.2f; 

    void Start()
    {
        objectRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(ColorCycle());
    }

    IEnumerator ColorCycle()
    {
        while (true)
        {
            yield return StartCoroutine(ChangeColor(new Color(1f, 0.294f, 0.294f))); // ������� (255, 75, 75)
            yield return StartCoroutine(ChangeColor(new Color(1f, 1f, 0.294f)));   // Ƹ���� (255, 255, 75)
            yield return StartCoroutine(ChangeColor(new Color(0.294f, 1f, 0.294f))); // ������ (75, 255, 75)
            yield return StartCoroutine(ChangeColor(new Color(0.294f, 1f, 1f)));   // ������� (75, 255, 255)
            yield return StartCoroutine(ChangeColor(new Color(0.294f, 0.294f, 1f))); // ����� (75, 75, 255)
            yield return StartCoroutine(ChangeColor(new Color(1f, 0.294f, 1f)));   // ���������� (255, 75, 255)
        }
    }

    IEnumerator ChangeColor(Color newColor)
    {
        Color startColor = objectRenderer.material.color;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            objectRenderer.material.color = Color.Lerp(startColor, newColor, elapsedTime / duration);
            yield return null;
        }

        objectRenderer.material.color = newColor; // ������������� ������ ����
    }
}
