using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
//using UnityEngine.XR.WSA.Input;

public class PlayerController : MonoBehaviour
{
    public bool isDead;
    private float velocity = 2.5f;
    public Rigidbody2D rigidbodyplayer;
    public GameManager gameManager;
    public GameObject deadScreen;
    void Start()
    {
        Time.timeScale = 1;
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //mause sol tık telefonda ise ekrana tıklama
        {
            rigidbodyplayer.velocity = Vector2.up * velocity;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "score")
        {
            gameManager.UpdateScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="deadArea")
        {
            isDead = true;
            Time.timeScale = 0;
            deadScreen.SetActive(true);
        }
    }
}
