using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToWorld : MonoBehaviour
{
    public void GoToWorldScene()
    {
        SceneManager.LoadScene("World");
    }
}
