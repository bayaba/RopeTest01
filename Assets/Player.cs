using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	void Start()
	{
	
	}
	
	void Update()
	{
	    if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddRelativeForce(Vector3.left * 60f);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddRelativeForce(Vector3.right * 60f);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rigidbody.AddRelativeForce(Vector3.up * 3000f);
        }
    }
}
