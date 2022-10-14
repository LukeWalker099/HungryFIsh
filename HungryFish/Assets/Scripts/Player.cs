using Mono.Cecil.Cil;
using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Rigidbody2D playerRigidBody;
    public SpriteRenderer spriteRenderer;
    public Player player;
    public AudioSource munchSFX;
    public AudioSource healthPowerSFX;
    public SpriteRenderer heartsImgOne;
    public SpriteRenderer heartsImgTwo;

    public int playerHealth;
    public int moveSpeed;
    public int dashSpeed;

    private void Start()
    {
        heartsImgOne.enabled = true;
        heartsImgTwo.enabled = false;
        playerHealth = 1;
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            spriteRenderer.flipX = false;
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            spriteRenderer.flipX = true;
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Fish"))
        {
            if (other.transform.localScale.sqrMagnitude > transform.localScale.sqrMagnitude)
            {
                playerHealth -= 1;
                transform.position = new Vector2(0, 0);
                spriteRenderer.color = Color.red;
                spriteRenderer.flipY = true;
                munchSFX.Play();
                if (heartsImgTwo.enabled)
                {
                    heartsImgTwo.enabled = false;
                }
                else
                {
                    if (heartsImgTwo.enabled == false)
                    {
                        heartsImgOne.enabled = false;
                    }
                }

                if (playerHealth <= 0)
                {
                    player.enabled = false;
                    Debug.Log("Damage Received!");
                    playerHealth -= 1;
                    spriteRenderer.flipY = true;
                    spriteRenderer.color = Color.red;
                    transform.position = new Vector2(0, 0);
                    Time.timeScale = 0.10f;
                }
            }
            else 
                if (other.transform.localScale.sqrMagnitude < transform.localScale.sqrMagnitude)
            {
                munchSFX.Play();
                Destroy(other.gameObject);
            }
        }
        
        // Pick up Power Ups
        if (other.gameObject.tag == ("Heart"))
        {
            if (playerHealth < 2)
            {
                healthPowerSFX.Play();
                playerHealth += 1;
                heartsImgTwo.enabled = true;
                other.gameObject.SetActive(false);
                //Destroy(other.gameObject);
            }
            else
            {
                if (playerHealth >= 2)
                {
                    other.gameObject.SetActive(true);
                }
            }
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Fish"))
        {
            if (playerHealth >= 0)
            {
                spriteRenderer.color = Color.white;
                spriteRenderer.flipY = false;
            }
        }
    }
}
