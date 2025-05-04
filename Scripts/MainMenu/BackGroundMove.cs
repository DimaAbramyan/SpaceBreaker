using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour
{
    Transform tr;

    private SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        tr = GetComponent<Transform>();
        // �������� ������ ������ � ������� �����������
        float cameraHeight = Camera.main.orthographicSize * 2;
        float cameraWidth = cameraHeight * Camera.main.aspect;

        // �������� ������ �������
        float spriteWidth = spriteRenderer.sprite.bounds.size.x;
        float spriteHeight = spriteRenderer.sprite.bounds.size.y;

        // ������������ ������
        transform.localScale = new Vector3(
            cameraWidth*1.2f / spriteWidth,
            spriteHeight,
            1
        );
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        tr.localPosition += new Vector3(0,-0.005f);
    }
}
