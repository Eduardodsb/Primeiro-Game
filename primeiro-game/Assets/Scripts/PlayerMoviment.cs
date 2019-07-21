﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour{

    public Rigidbody rb;
    public Transform player;
    public float force = 100;
    public float lateralForce = 50;
    public float jumpForce = 100;

    // Start is called before the first frame update
    void Start(){
        Debug.Log("Iniciando");
        rb.useGravity = true;
        rb.AddForce(0, 0, 0);
    }

    //É chamado a cada frame produzido.
    void Update(){
        if (rb.velocity.z < 45){
            rb.AddForce(0, 0, force * Time.deltaTime); //Time.deltaTime serve para manter a proporção de acordo com a variação dos frames produzidos(Se baseando no time do último frame).
        }
    }

    private void FixedUpdate(){
        if(Input.GetKey("a")){
            rb.AddForce(-lateralForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d")){
            rb.AddForce(lateralForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.Space) && player.position.y <= 0.55 && player.position.y > 0.45){
            rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1.0){
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
