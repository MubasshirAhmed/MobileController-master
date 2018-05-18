using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControlScript : MonoBehaviour
{
    private bool ballMove;
    private float movementSpeed = 25;
    public GameObject ball;
    // Use this for initialization
    void Start()
    {
        //int n = 10;
        //string[] responses = { "Positive", "Negative" };
        //Debug.Log((n >> 31) & 1);
        //Debug.Log((n ^ (n >> 31)) - (n >> 31));
    }

    // Update is called once per frame
    void Update()
    {
        if (ballMove)
            ball.transform.Translate(new Vector3(movementSpeed * Time.deltaTime, 0, 0));
    }

    public void OnButtonDown(bool site)
    {
        ballMove = true;
        if (site)
            movementSpeed = -Mathf.Abs(movementSpeed);
        else
            movementSpeed = Mathf.Abs(movementSpeed);
    }

    public void OnButtonUp()
    {
        ballMove = false;
    }
}
