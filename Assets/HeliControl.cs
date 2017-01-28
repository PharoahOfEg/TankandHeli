using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliControl : MonoBehaviour {
    public float Speed;
    public float RotationSpeed;
    // Use this for initialization
    Rigidbody rigid;
    short move;
    short rotate;
    short ascend;
    //float t;
	void Start () {
        rigid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        CheckMovement();
        CheckRotation();
        CheckAscending();




    }
    void FixedUpdate()
    {
        if (move != 0)
        {
            //if (move > 0)
            //    rigid.rotation = Quaternion.Euler(270 + Mathf.Lerp(0, 5, t += 0.01f), 0, 0);
            //if (move < 0)
            //    rigid.rotation = Quaternion.Euler(270 + Mathf.Lerp(0, -5, t += 0.01f), 0, 0);
            rigid.velocity += -transform.up * Speed * move;
        }
        //if (move == 0 && rigid.rotation.eulerAngles.x > 270)
        //{
        //    rigid.rotation = Quaternion.Euler(270 + Mathf.Lerp(5, 0, t += 0.01f), 0, 0);
        //}
        //if (move == 0 && rigid.rotation.eulerAngles.x < 270)
        //{
        //    rigid.rotation = Quaternion.Euler(270 + Mathf.Lerp(-5, 0, t += 0.01f), 0, 0);
        //}

        if (rotate!=0)
        {
            rigid.angularVelocity += -transform.forward * RotationSpeed * rotate;
        }
        if (ascend != 0)
        {
            rigid.velocity += transform.forward * Speed * ascend;
        }

    }

    void CheckMovement()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            move = 1;
            //t = 0;
            Debug.Log(move);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            move = -1;
            //t = 0;
            Debug.Log(move);
        }
        if (Input.GetKeyUp(KeyCode.W) && move == 1)
        {
            move = 0;

            //t = 0;
            Debug.Log(move);
        }
        if (Input.GetKeyUp(KeyCode.S) && move == -1)
        {
            move = 0;

            //t = 0;
            Debug.Log(move);
        }
    }
    void CheckRotation()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            rotate = 1;
            Debug.Log(rotate);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            rotate = -1;
            Debug.Log(rotate);
        }
        if (Input.GetKeyUp(KeyCode.Q) && rotate == 1)
        {
            rotate = 0;

            Debug.Log(rotate);
        }
        if (Input.GetKeyUp(KeyCode.E) && rotate == -1)
        {
            rotate = 0;

            Debug.Log(rotate);
        }
    }
    void CheckAscending()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            ascend = 1;
            Debug.Log(ascend);
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            ascend = -1;
            Debug.Log(ascend);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift) && ascend == 1)
        {
            ascend = 0;

            Debug.Log(ascend);
        }
        if (Input.GetKeyUp(KeyCode.LeftControl) && ascend == -1)
        {
            ascend = 0;

            Debug.Log(ascend);
        }
    }
}
