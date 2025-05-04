using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ToBuildScene : MonoBehaviour
{
    public void SwitchToBuilding()
    {
        SceneManager.LoadScene("Building");
    }
    
}
