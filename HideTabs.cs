using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideTabs : MonoBehaviour
{
    GameObject FoundTab;
    // Start is called before the first frame update
    public void Hide()
    {
        if (FindAnyObjectByType<SaveLoadUI>() != null)
        FoundTab = FindAnyObjectByType<SaveLoadUI>().gameObject;
        GameObject button = FoundTab.GetComponentInParent<FINDME>().GetComponentInChildren<ShowPanel>().gameObject;
        Debug.Log(FoundTab);
        Debug.Log(button);
        button.GetComponent<ShowPanel>().SwitchImage(button, 1);
        button.GetComponent<ShowPanel>().ShowingPanel();
    }
}
