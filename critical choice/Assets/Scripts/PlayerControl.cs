using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Vector3 firstPos, endPos;
    public float playerSpeed;
    public float forwardSpeed;
    Vector3 direction;
    void Update()
    {
        direction.z = forwardSpeed;

        if (Input.GetMouseButtonDown(0))
        {
            firstPos = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            endPos = Input.mousePosition;
            float farkX = endPos.x - firstPos.x;
            transform.Translate(farkX * Time.deltaTime * playerSpeed /100, 0, 0);
        }
        if (Input.GetMouseButtonUp(0))
        {
            firstPos = Vector3.zero;
            endPos = Vector3.zero;   
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(0, 0, forwardSpeed * Time.fixedDeltaTime);
    }
}