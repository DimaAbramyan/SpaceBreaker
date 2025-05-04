using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WaveManager : MonoBehaviour
{
    [SerializeField] private GameObject GameOver;
    [SerializeField] private GameObject EndGame;
    public GameObject[] waves; // ������ ���� ����
    private int currentWaveIndex = 0; // ������ ������� �����
    private float absTimer;
    private bool IsPlaying = true;
    void Start()
    {
        Time.timeScale = 1.0f;
        ActivateWave();
    }

    void Update()
    {
        if (IsPlaying)
        {
            absTimer = waves[currentWaveIndex].GetComponent<Wave_Creating>().AbsoluteTimer;
        //Debug.Log(AbsTimer);
        // ��������� ������� �����
        
            if (IsWaveCleared())
            {
                // ������� � ��������� �����
                currentWaveIndex++;
                Debug.Log(currentWaveIndex);
                if (currentWaveIndex < waves.Length)
                {
                    ActivateWave();
                }
                else
                {
                    ReturnToMap();
                }
            }
        }
    }

    // ���������, ���������� �� ��� ����� ������� �����
    private bool IsWaveCleared()
    {
        if (currentWaveIndex >= waves.Length) return false;

        Transform wave = waves[currentWaveIndex].transform;
        if (absTimer >= 0)
        {
            return false;
        }
        foreach (Transform child in wave)
        {
            //Debug.Log(child.name);  
            if (child.GetComponentInChildren<Enemy>() != null)
            {
                return false;
            }
        }
        absTimer = 4;
        return true; // ��� ����� ����������
    }
    
    // ���������� ������� �����
    private void ActivateWave()
    {
        if (currentWaveIndex < waves.Length)
        {
            Activate();
        }
    }
    private void Activate()
    {
        waves[currentWaveIndex].SetActive(true);
       // absTimer = waves[currentWaveIndex].GetComponent<Wave_Creating>().AbsoluteTimer;
    }
    void ReturnToMap()
    {
        IsPlaying = false;
        EndGame.SetActive(true);
    }
    public void MainHeroIsDead()
    {
        GameOver.SetActive(true);
    }
}
