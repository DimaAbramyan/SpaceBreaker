using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AddToTeam : MonoBehaviour
{
    string filename;

    public void AddingToTeam()
    {
        filename = GetComponentInChildren<TMP_Text>().text;
        Debug.Log(filename);
    }
}
