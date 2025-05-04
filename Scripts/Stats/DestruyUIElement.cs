using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class DestroyUIElement : MonoBehaviour
{
    [SerializeField] private GameObject toDestroy;

    public void ToDestroy()
    {
        if (toDestroy.GetComponent<Image>().color != Color.white)
        {
            GetComponentInParent<FINDME>().GetComponentInChildren<Save>().ErazeSave();
            GetComponentInParent<FINDME>().GetComponentInChildren<Image>().sprite = GetComponentInParent<FINDME>().GetComponentInChildren<ShowPanel>().SelectStatus[1];
        }
        string I = toDestroy.GetComponentInChildren<TMP_Text>().text;
        File.Delete(Application.persistentDataPath + "/Saves/" + I + ".json");
        Destroy(toDestroy);

    }

}
