using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideMe : MonoBehaviour
{
    public GameObject ToHide;
    public void Hiding()
    {
        ToHide.SetActive(false);
    }
}
