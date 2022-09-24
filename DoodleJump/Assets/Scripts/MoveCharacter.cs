using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class MoveCharacter : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    private float moveInput;
    public TextMeshProUGUI ScoreYazisi;
    int score;

    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");//Hareket Input'u sağ ve sol ("Horizontal") seklinde olacak.
        rb.velocity = new Vector2(speed * moveInput, rb.velocity.y);//Doodle'ın hızı x'de Hiz ve giriş Inputu ile çarpılsın. Y de sabit kalsın
        ScoreYazisi.text = "Score:" + score;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "FinishLine")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (other.gameObject.tag == "Platform")
        {
            score += Random.Range(5, 10);
        }
    }
}
