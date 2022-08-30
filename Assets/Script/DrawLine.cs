using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DrawLine : MonoBehaviour
{

    public GameObject target;
    
    void Update()
    {
        SelfPos();
    }

    void SelfPos()
    {
        Vector3 tarPos = target.transform.position;
        Vector3 selfPos = transform.position;
        
        Debug.Log("11111111111111111111");
        
        Vector3 delta = tarPos - selfPos;
        Debug.DrawLine(selfPos,tarPos,Color.blue);
        Vector3 toOther = -delta;
        
        Vector3 c=Vector3.Cross(transform.forward,toOther);
        if (c.y < 0)
        {
            Debug.Log("right");
        }
        else
        {
            Debug.Log("left");
        }
    }
}
