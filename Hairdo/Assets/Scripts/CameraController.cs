using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public float smoothing;

    void Update()
    {
        Vector3 position = new Vector3(player.position.x, player.position.y, -10f);
        transform.position = Vector3.Lerp(transform.position, position, smoothing * Time.deltaTime);
    }
}
