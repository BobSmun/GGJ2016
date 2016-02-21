using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour
{

    public float paddleSpeed = 1f;


    private Vector3 playerPos = new Vector3(0, 0, 0);

    void Update()
    {
        float xPos = transform.position.x + (Input.GetAxis("BreakoutHoriz") * paddleSpeed);
        playerPos = new Vector3(Mathf.Clamp(xPos, -8f, 8f), -9.5f, -300);
        transform.position = playerPos;

    }
}