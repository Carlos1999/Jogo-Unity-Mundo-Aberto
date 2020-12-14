using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ControleNivel : MonoBehaviour
{
    private Scene scene;
    private bool paused;
    public GameObject pauseMenu;
    public GameObject controles;
    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(paused){
                Resume();
                AudioListener.pause = false;
            }else{
                Pause();
                AudioListener.pause = true;
            }
        }

        if(Input.GetKey(KeyCode.LeftShift) && paused == false){
            Time.timeScale = 0.5f;
        }else if (paused == false){
            Time.timeScale = 1f;
        }
    
    }


    void Resume(){
        pauseMenu.SetActive(false);
        controles.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
    }

    void Pause(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
    }
    public void Reiniciar(){
        paused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(scene.name);
    }
     public void ProximaFase(){
        paused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("fase 2");
    }
    public void VoltarFase(){
        pauseMenu.SetActive(false);
        paused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("fase 1");
    }

    public void Despausar(){
        Resume();
    }

    public void MostrarControles(){
        pauseMenu.SetActive(false);
        controles.SetActive(true);
    }

    public void Voltar(){
        controles.SetActive(false);
        Pause();
    }

}
