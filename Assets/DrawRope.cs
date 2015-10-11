using UnityEngine;
using System.Collections;

public class DrawRope : MonoBehaviour
{
    LineRenderer RopeLine;
    
    void Start()
	{
        RopeLine = GetComponent<LineRenderer>();
        RopeLine.SetVertexCount(transform.childCount);
    }
	
	void Update()
	{
        for (int i = 0; i < transform.childCount; i++)
        {
            RopeLine.SetPosition(i, transform.GetChild(i).position);
        }
    }
}
