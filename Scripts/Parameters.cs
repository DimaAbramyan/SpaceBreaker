using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Parameters : MonoBehaviour
{
    public bool IsGodModeOn;
    public bool IsParticlesOn;
    void Start()
    {
        DontDestroyOnLoad(gameObject);    
    }
    
}
