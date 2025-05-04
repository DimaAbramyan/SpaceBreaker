using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckParticles : MonoBehaviour
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
        par.IsParticlesOn = !par.IsParticlesOn;
        ChangeIcon();
    }
    void ChangeIcon()
    {
        if (par.IsParticlesOn) GetComponent<Image>().sprite = On;
        else GetComponent<Image>().sprite = Off;

    }
}
