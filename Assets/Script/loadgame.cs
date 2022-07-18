using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadgame : MonoBehaviour
{
    public AudioClip a;
    public AudioSource aa;

    public void game()
    {
        
        aa.PlayOneShot(a);
        SceneManager.LoadScene(1);
    }
    public void exit()
    {
        aa.PlayOneShot(a);
        Application.Quit();
    }
}
