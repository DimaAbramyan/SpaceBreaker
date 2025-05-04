using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DamageNumbPool : MonoBehaviour
{
    public GameObject damageNumberPrefab;
    private int poolSize = 2500;
    private Queue<GameObject> _pool = new Queue<GameObject>();

    void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        InitializePool();
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Очищаем пул и создаем новые объекты
        ClearPool();
        InitializePool();
    }

    private void InitializePool()
    {
        for (int i = 0; i < poolSize; i++)
        {
            CreateNewPoolObject();
        }
    }

    private GameObject CreateNewPoolObject()
    {
        GameObject obj = Instantiate(damageNumberPrefab, transform);
        obj.SetActive(false);
        var numberScript = obj.GetComponent<NumberShowingToPlayer>();
        numberScript.Pool = this; // Устанавливаем ссылку на пул
        _pool.Enqueue(obj);
        return obj;
    }

    private void ClearPool()
    {
        _pool.Clear(); // Просто очищаем очередь, объекты уничтожатся автоматически
    }

    public GameObject GetDamageNumber(float numb)
    {
        // Удаляем уничтоженные объекты из начала очереди
        while (_pool.Count > 0 && _pool.Peek() == null)
        {
            _pool.Dequeue();
        }

        GameObject obj = _pool.Count > 0 ? _pool.Dequeue() : CreateNewPoolObject();

        if (obj != null)
        {
            obj.SetActive(true);
            TextMeshProUGUI text = obj.GetComponent<TextMeshProUGUI>();
            if (text != null)
            {
                text.text = numb.ToString();
                text.alpha = 1f; // Сбрасываем прозрачность
            }
            return obj;
        }

        return CreateNewPoolObject(); // На случай, если что-то пошло не так
    }

    public void ReturnToPool(GameObject obj)
    {
        if (obj != null)
        {
            obj.SetActive(false);
            _pool.Enqueue(obj);
        }
    }

    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}