using UnityEngine;

public class Test : MonoBehaviour
{
    public float torque;
    public float force;
    int rotateHull;
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rotateHull = 1;
            Debug.Log(rotateHull);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rotateHull = -1;
            Debug.Log(rotateHull);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow)&&rotateHull==1)
        {
            rotateHull = 0;
            GetComponent<Rigidbody>().angularVelocity = (transform.up * 0);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow)&&rotateHull==-1)
        {
            rotateHull = 0;
            GetComponent<Rigidbody>().angularVelocity = (transform.up * 0);
        }

    }
    void FixedUpdate()
    {

        Debug.Log(rotateHull);
        if(rotateHull!=0)
        {
            Debug.Log(rotateHull);
            GetComponent<Rigidbody>().angularVelocity=(-transform.up * torque*rotateHull);
        }
    }
}