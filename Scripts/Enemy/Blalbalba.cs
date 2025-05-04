using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Blalbalba : MonoBehaviour
{
    [SerializeField] NumberShowingToPlayer WhatToCreate;
    float _timer;
    private float _delay = 0.15f;
    void Start()
    {


    }
    private void Update()
    {
        _timer += Time.deltaTime; 

        if (_timer >= _delay)
        {
            NumberShowingToPlayer Gameobject = Instantiate(WhatToCreate, this.transform);
            Gameobject.GetComponent<TextMeshProUGUI>().text = Random.Range(10, 999).ToString();
            _timer = 0f;
        }
    }
}
