using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    [SerializeField] Text Points;
    [SerializeField] Text Bonuses;
    // Start is called before the first frame update
    private void Awake()
    {
        PlayerLevel PL  =  FindFirstObjectByType<PlayerLevel>();
        PL.LvlUp();
        Debug.Log(PL.levelList);
    }
    void Start()
    {
        GetComponent<Text>().text += $"{SceneManager.GetActiveScene().buildIndex-4}";
        Points.text += PointsCollector.Points.ToString() + " / "+PointsCollector.MaxPoints.ToString();
        Bonuses.text += PointsCollector.Bonuses.ToString() + " / " + PointsCollector.MaxBonuses.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
