using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private float moveSpeed = 25;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(VirtualJoystick.joystick.Horizontal(), 0, VirtualJoystick.joystick.Vertical()) * moveSpeed * Time.deltaTime);
    }
}
