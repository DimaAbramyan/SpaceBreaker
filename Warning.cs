using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Warning : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnEnable()
    {
        StartCoroutine("StopShowing");
        Debug.Log("ѕ–я„”");
    }
    IEnumerator StopShowing()
    {
        yield return new WaitForSeconds(2);
        Image targetImage = this.gameObject.GetComponent<Image>();
        TextMeshProUGUI Text = GetComponentInChildren<TextMeshProUGUI>();
        Debug.Log(Text);
        //targetImage.color =  new Color(1,1,1,0); 
        float startAlpha = targetImage.color.a;
        float timeElapsed = 0f;
        while (timeElapsed < 2)
        {
            timeElapsed += Time.deltaTime;
            float newAlpha = Mathf.Lerp(startAlpha, 0, timeElapsed / 2);

            // ќбновл€ем прозрачность
            Color color = targetImage.color;
            color.a = newAlpha;
            Color c = Text.color;
            c.a = newAlpha;
            targetImage.color = color;
            Text.color = c;
            yield return null;
            // ∆дем следующий кадр
        }
        targetImage.color = new Color(1, 1, 1, 1);
        Text.color = new Color(0, 0, 0, 1);
        this.gameObject.SetActive(false);
        this.gameObject.GetComponentInChildren<GameObject>().SetActive(false);

    }
}
