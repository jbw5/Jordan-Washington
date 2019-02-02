using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Text countText;
    public Text winText;
    public Text scoreText;
    public Text loseText;
    public Text livesText;


    private Rigidbody rb;
    private int count;
    private int score;
    private int lives;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        score = 0;
        lives = 3;
        SetCountText ();
        SetScoreText ();
        SetLivesText ();
        winText.text = "";
        loseText.text = "";
     }

    void FixedUpdate()
    { float moveHorizontal = Input.GetAxis("Horizontal");
      float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
        if (Input.GetKey("escape"))
            Application.Quit();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
        else if (other.gameObject.CompareTag("Enemy"))
        { other.gameObject.SetActive(false);
            count = count - 1;
            SetCountText();
        }
        
          

        
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            score = score + 1;
        
            SetScoreText();
        }

        if (count == 12)
        {
            transform.position = new Vector3(23.42f, 0.514f, 0.0f);
        }
        if (other.gameObject.CompareTag("Enemy"))
        { other.gameObject.SetActive(false);
            lives = lives - 1;
            SetLivesText();
        }
    }
    
    void SetCountText ()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 24) { 
            winText.text = "You Win!";
               }
    }

   

    void SetScoreText()
    {
    scoreText.text = "Score: " + score.ToString();
        if (score >= 24)
        {
            winText.text = "You Win!";
        }
    }
    void SetLivesText()
    {
        livesText.text = "Lives: " + lives.ToString();
        if (lives <= 0)
        { loseText.text = "You Lose!";
            Destroy(this);
        }

    }
}
