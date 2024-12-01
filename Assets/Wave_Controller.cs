using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

using UnityEngine;

public class WaveManager : MonoBehaviour
{

    [SerializeField] private GameObject EndGame;
    public GameObject[] waves; // Массив всех волн
    private int currentWaveIndex = 0; // Индекс текущей волны

    void Start()
    {
        // Активируем первую волну
        ActivateWave();
    }

    void Update()
    {
        // Проверяем текущую волну
        if (IsWaveCleared())
        {
            // Переход к следующей волне
            currentWaveIndex++;
            if (currentWaveIndex < waves.Length)
            {
                ActivateWave();
            }
            else
            {
                EndGame.SetActive(true);
                Destroy(this);
            }
        }
    }

    // Проверяем, уничтожены ли все враги текущей волны
    private bool IsWaveCleared()
    {
        if (currentWaveIndex >= waves.Length) return false;

        Transform wave = waves[currentWaveIndex].transform;
        foreach (Transform child in wave)
        {
            if (child.CompareTag("Enemy"))
            {
                return false; // Есть хотя бы один враг
            }
        }

        return true; // Все враги уничтожены
    }

    // Активируем текущую волну
    private void ActivateWave()
    {
        if (currentWaveIndex < waves.Length)
        {
            Invoke(nameof(Activate), 2f);
        }
    }
    private void Activate()
    {
        waves[currentWaveIndex].SetActive(true);
    }
}
