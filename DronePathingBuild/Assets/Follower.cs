using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation; //include this namespace

public class Follower : MonoBehaviour
{
    public PathCreator pathCreator;
    public EndOfPathInstruction end;
    Quaternion Qxyz = new Quaternion();
    Vector3 temp;
    public float speed;
    float dstTravelled;
    float angle = 0.0f;
    float x,z;

    void start()
    {
        x = 0.0f;
        z = 0.0f;
    }

    void Update()
    {
        dstTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(dstTravelled, end);
        Qxyz = pathCreator.path.GetRotationAtDistance(dstTravelled, end);

        temp = Qxyz.eulerAngles;
        Debug.Log(temp);
        angle = temp.y;
        Debug.Log(angle);

        Quaternion caly = Quaternion.Euler(x,angle,z);
        transform.rotation = caly;
    }


    
            
}
