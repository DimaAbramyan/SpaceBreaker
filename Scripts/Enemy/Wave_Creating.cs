using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave_Creating : MonoBehaviour
{

    [SerializeField] public List<GameObject> WaveToCreate;
    [SerializeField] public List<InfoAboutWave> info;
    [SerializeField] public List<float> Timer;
    [SerializeField] public List<Vector2> position;
    public float AbsoluteTimer;
    void Start()
    {
        int i = 0;
        foreach (GameObject wave in WaveToCreate)
        {
            info.Add(wave.GetComponent<InfoAboutWave>());
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        AbsoluteTimer -= Time.deltaTime;
        int i = 0;
        foreach (GameObject wave in WaveToCreate)
        {
            Timer[i] -= Time.deltaTime;
            
            if (Timer[i] < 0)
            {
              GameObject createdWave = Instantiate(wave, transform);
                createdWave.transform.position = position[i];
                Timer[i] = 100000000f;
            }
            i++;
        }
    }
}
