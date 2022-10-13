using Mono.Cecil.Cil;
using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Rigidbody2D playerRigidBody;
    public SpriteRenderer spriteRenderer;
    public Player player;

    public int playerHealth;
    public int moveSpeed;
    public int dashSpeed;

    private void Start()
    {
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

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            player.enabled = false;
            Debug.Log("Damage Received!");
            playerHealth -= 1;
            spriteRenderer.flipY = true;
            spriteRenderer.color = Color.red;
            transform.position = new Vector2(0, 0);
            Time.timeScale = 0.09f;
        }
    }
}
