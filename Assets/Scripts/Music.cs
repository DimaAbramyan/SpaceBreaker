using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private static MusicManager instance;

    private void Awake()
    {
        // Если объект уже существует, уничтожаем новый экземпляр
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            // Устанавливаем текущий объект как единственный экземпляр
            instance = this;
            DontDestroyOnLoad(gameObject); // Не уничтожать объект при загрузке новой сцены
        }
    }
}