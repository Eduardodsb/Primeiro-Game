using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour{

    public AudioSource audio;


    // Start is called before the first frame update
    void Start(){
        // Este método impede que o objeto 
        // atual seja destruido durante o carregamento.
        DontDestroyOnLoad(audio);
    }

    // Update is called once per frame
    void Update(){
        
    }

    public void StartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
