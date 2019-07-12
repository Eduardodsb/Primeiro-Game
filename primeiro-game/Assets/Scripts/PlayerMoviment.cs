using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour{

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start(){
        Debug.Log("Iniciando");
        rb.useGravity = true;
        rb.AddForce(0, 100, 0);
    }

    // Update is called once per frame
    void Update(){ //É chamado a cada frame produzido.
        rb.AddForce(0, 0, 10 * Time.deltaTime); //Time.deltaTime serve para manter a proporção de acordo com a variação dos frames produzidos(Se baseando no time do último frame).

    }
}
