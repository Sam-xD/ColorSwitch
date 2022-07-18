using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Mot : MonoBehaviour
{
    public Rigidbody2D rb;
    public float x ;
    public SpriteRenderer sp;
    public Color[] co;
    public AudioClip[] a;
    public AudioSource aa;
    private string name;

    void Start()
    {
        RandCol();
    }public void nxt()
    {
        SceneManager.LoadScene(0);
    }

    
    void FixedUpdate()
    {

        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            FindObjectOfType<Canvas>().enabled = false;
            rb.gravityScale = 2.08f;
            aa.PlayOneShot(a[0]);
            rb.velocity = Vector2.up * x;
        }
    }
    void RandCol()
    {
        
        int rr = Random.Range(0, 4);
        sp.color = co[rr];
        switch (rr)
        {
            case 0:
                name = "Yellow";
                break;
            case 1:
                name = "Voilet";
                break;
            case 2:
                 name = "Megenta";
                break;
            case 3:
                name = "Cyan";
                break;
        }

    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag=="change")
        {
            aa.PlayOneShot(a[2]);
            Destroy(col.gameObject);
            RandCol();
        }
        else if (col.tag == "end")
        {
            Destroy(col.gameObject);
            SceneManager.LoadScene(0);
        }
        else if (name != col.name)
        {
            aa.PlayOneShot(a[1]);
            
            rb.velocity = Vector2.zero;
            FindObjectOfType<Mot>().enabled = false;
            Invoke("nxt", 3f);
            
        }
    }


}
