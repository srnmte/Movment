using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Move : MonoBehaviour
{

    private float speed = 10;
    void Update()
    {
        transform.Translate(new Vector3(0, 0, speed* Time.deltaTime));
    }
}
