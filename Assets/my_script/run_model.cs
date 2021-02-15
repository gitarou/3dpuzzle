using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class run_model : MonoBehaviour
{
    public float speed = 0.1f;
    private float ver = 0f;
    private float hor = 0f;
    private double angle = 0d;
    private int kakudo = 0;
    private Quaternion offset;
    private Vector3 vec;

    void Start(){

    }

    void Update(){
        ver = Input.GetAxis("Vertical");
        hor = Input.GetAxis("Horizontal");
        //angle = Math.Atan(ver/hor)*180.0/Math.PI;
        //kakudo = (int)angle;
        //
        //Quaternion.AngleAxis(kakudo,new Vector3(0, 1, 0));
        transform.position +=new Vector3(hor*speed, 0, ver*speed);
    }
}