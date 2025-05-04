using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeParameters : MonoBehaviour
{
    public void ChangeGod()
    {
        Parameters Setting = FindAnyObjectByType<Parameters>();
        Setting.IsGodModeOn = !Setting.IsGodModeOn;
    }
    public void ChangeParticles()
    {
        Parameters Setting = FindAnyObjectByType<Parameters>();
        Setting.IsParticlesOn = !Setting.IsParticlesOn;
    }
}
