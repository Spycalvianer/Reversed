using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public float speed;
    public bool isMoving = false;

    private void Update()
    {
        if (isMoving) StartMoving();
    }
    public void StartMoving()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }
    public void ChangeBool()
    {
        isMoving = true;
    }
}
