using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

using UnityEngine;

public class WaveManager : MonoBehaviour
{

    [SerializeField] private GameObject EndGame;
    public GameObject[] waves; // ������ ���� ����
    private int currentWaveIndex = 0; // ������ ������� �����

    void Start()
    {
        // ���������� ������ �����
        ActivateWave();
    }

    void Update()
    {
        // ��������� ������� �����
        if (IsWaveCleared())
        {
            // ������� � ��������� �����
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

    // ���������, ���������� �� ��� ����� ������� �����
    private bool IsWaveCleared()
    {
        if (currentWaveIndex >= waves.Length) return false;

        Transform wave = waves[currentWaveIndex].transform;
        foreach (Transform child in wave)
        {
            if (child.CompareTag("Enemy"))
            {
                return false; // ���� ���� �� ���� ����
            }
        }

        return true; // ��� ����� ����������
    }

    // ���������� ������� �����
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
