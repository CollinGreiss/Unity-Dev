using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke : MonoBehaviour {

    List<GameObject> smoke = new List<GameObject>();

    float time = 0;
    float interval = 0.75f;
    float speed = 2;

    void Start() {



    }

    void Update() {

        time += Time.deltaTime;
        if ( time < interval ) return;

        time = 0;

        GameObject sphere = GameObject.CreatePrimitive( PrimitiveType.Sphere ); ;
        sphere.transform.position = transform.position;
        
        Rigidbody rigidbody = sphere.AddComponent<Rigidbody>();
        rigidbody.velocity = Vector2.up * speed;
        rigidbody.useGravity = false;

        smoke.Add( sphere );
        if ( smoke.Count < 6 ) return;

        Destroy( smoke[0] );
        smoke.RemoveAt( 0 );

    }

}
