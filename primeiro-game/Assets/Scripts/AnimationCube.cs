using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCube : MonoBehaviour{

    public Transform MovableCube;
    public Rigidbody rb;
    public float lateralForce;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        if(MovableCube.position.x <= -4.0 ){
            rb.AddForce(lateralForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (MovableCube.position.x >= 4.0){
            rb.AddForce(-lateralForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
