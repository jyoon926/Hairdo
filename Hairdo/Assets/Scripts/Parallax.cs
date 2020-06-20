using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float length, startPosX, startPosY;
    public GameObject camera;
    public float parallaxEffect;

    void Start()
    {
        startPosX = transform.position.x;
        startPosY = transform.position.y;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void FixedUpdate()
    {
        float distanceX = camera.transform.position.x * parallaxEffect;
        float distanceY = camera.transform.position.y * parallaxEffect;
        transform.position = new Vector3(startPosX + distanceX, startPosY + distanceY, 0f);

    }
}
