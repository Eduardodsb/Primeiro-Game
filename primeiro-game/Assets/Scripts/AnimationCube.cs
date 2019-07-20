using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCube : MonoBehaviour{

    public Transform MovableCube;
    public Rigidbody rb;
    public Vector3 velocidade;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        if (MovableCube.position.x <= -4.0) {
            rb.velocity = velocidade;
        } else if (MovableCube.position.x >= 4.0) {
            rb.velocity = -velocidade;
        } else if (rb.velocity.x == 0.0 ) { 
            rb.velocity = velocidade;
        }
    }
}
