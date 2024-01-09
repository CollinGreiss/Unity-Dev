using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Daycycle : MonoBehaviour {


    [SerializeField][Range( 1, 20 )] float cycleTime = 20;
    [SerializeField] float curentTime = 0;

    [SerializeField] Light light; 

    void Start() {

        

    }

    void Update() {

        curentTime += Time.deltaTime;
        curentTime %= cycleTime;

        light.transform.rotation = Quaternion.AngleAxis( ( ( curentTime / cycleTime ) * 360 ) - 90, Vector3.right );
        light.intensity = Mathf.Clamp( Mathf.Sin( curentTime * ( Mathf.PI / cycleTime ) ), 0.1f, 1.0f );

    }

}
