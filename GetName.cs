using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class GetName : MonoBehaviour
{
    TMPro.TextMeshPro m_TextMeshPro;
    [SerializeField]
    private GameObject toDestroy;
    public void ToDestroy()
    {
        string I = toDestroy.GetComponentInChildren<TMP_Text>().text;
        File.Delete(Application.persistentDataPath + "/Saves/" + I + ".json");
        Destroy(toDestroy);
    }
    public void Awake()
    {
        transform.position = new Vector3(150, 150, 0);
        string I = toDestroy.GetComponentInChildren<TMP_Text>().text;
       // m_TextMeshPro.text = I;
    }
}
