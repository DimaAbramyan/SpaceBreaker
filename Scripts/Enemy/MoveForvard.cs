using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveForvard : MonoBehaviour
{
    [SerializeField] bool looped = false;
    [SerializeField] private float speed = 0.01f;
    [Header("Быстрое появление на сцене")]
    [SerializeField] Vector3 startPos;
    [SerializeField] Vector3 endPos;
    [SerializeField] float duration = 0;
    private float timeElapsed = 0f;

    void Start()
    {
        
    }


    void Update()
    {
        if (timeElapsed < duration)
        {
            timeElapsed += Time.deltaTime;
            float t = timeElapsed / duration;
            float smoothT = Mathf.SmoothStep(0, 1, t); // ускорение + замедление
            transform.position = Vector3.Lerp(startPos, endPos, smoothT);
        }
        else
        {
            if (looped)
            {
                timeElapsed = 0;
                (startPos, endPos) = (endPos, startPos);
            }
        }
    }
    void FixedUpdate()
    {
        this.transform.position += new Vector3(0,-speed);
        
    }
}
