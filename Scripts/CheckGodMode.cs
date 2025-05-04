using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckGodMode : MonoBehaviour
{
    [SerializeField] Sprite On;
    [SerializeField] Sprite Off;
    Parameters par;
    void Start()
    {
        par = FindAnyObjectByType<Parameters>();
    }
    void Awake()
    {
        par = FindAnyObjectByType<Parameters>();
        ChangeIcon();
    }
    
    public void EnableDisable()
    {
        par.IsGodModeOn = !par.IsGodModeOn;
        ChangeIcon();
    }
    void ChangeIcon()
    {
        if (par.IsGodModeOn) GetComponent<Image>().sprite = On; 
        else GetComponent<Image>().sprite = Off;

    }
}
