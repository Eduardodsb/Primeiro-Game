using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour{

    public AudioSource audio;
    public AudioSource audioEffect;


    // Start is called before the first frame update
    void Start(){
        // Este método impede que o objeto 
        // atual seja destruido durante o carregamento.
        DontDestroyOnLoad(audio);
        DontDestroyOnLoad(audioEffect);
    }

    // Update is called once per frame
    void Update(){
        
    }

    public void StartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit(){
        Application.Quit();
    }

    public void MuteSound(){
        if (AudioListener.volume == 0){
            AudioListener.volume = 1;
        }else{
            AudioListener.volume = 0;
        }
            /* 
             if(audio.mute == false){
                 audioEffect.mute = true;
                 audio.mute = true;
             }else{
                 audio.mute = false;
                 audioEffect.mute = false;
             }*/
        }

}
