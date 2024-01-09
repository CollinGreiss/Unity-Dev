using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disco : MonoBehaviour {

    public Light discoLight;
    int color = 0;

    void Update() {

        color++;
        color %= 256;

        discoLight.color = Color.HSVToRGB( color / 255.0f, 1.0f, 1.0f);
        print( Color.HSVToRGB( color, 1.0f, 1.0f ) );

    }
}
