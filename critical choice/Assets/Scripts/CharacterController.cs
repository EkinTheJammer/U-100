using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
	private UnityEngine.CharacterController cc;
	private Vector3 direction;
	public float forwardSpeed;

	private Animator anim;

	private int desireLane = 1;
	public float laneDistance;

    void Start()
	{
		cc = GetComponent<UnityEngine.CharacterController>();
		anim = GetComponent<Animator>();
	}

	void Update()
	{
		direction.z = forwardSpeed;

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
			desireLane++;
            if (desireLane == 3)
            {
				desireLane = 2;
            }
        }

		if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
		{
			desireLane--;
			if (desireLane == -1)
			{
				desireLane = 0;
			}
		}

		Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;


        if (desireLane == 0)
        {
			targetPosition += Vector3.left * laneDistance;
        }
        else if (desireLane == 2)
        {
			targetPosition += Vector3.right * laneDistance;
		}

		transform.position = targetPosition;

	}

	private void FixedUpdate()
    {
		cc.Move(direction * Time.fixedDeltaTime);
    }

}