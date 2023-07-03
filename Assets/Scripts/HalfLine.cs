using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DottedLine;

public class HalfLine : MonoBehaviour
{
    public Vector2 pointA;
    public Vector2 pointB;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DottedLine.DottedLine.Instance.DrawDottedLine(pointA, pointB);
    }
}
