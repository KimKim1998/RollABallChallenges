using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public Text countText;
    public Text winText;
    public Text scoretext;

    private Rigidbody rb;
    private int count;
    private int score;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        SetScoreText();
        winText.text = "";
    }

    void FixedUpdate()

    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

        if (Input.GetKey("escape"))
            Application.Quit();
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            score = score + 1;
            SetScoreText();
            SetCountText();
        }

        else if (other.gameObject.CompareTag("PickUpEvil"))

        {
            other.gameObject.SetActive(false);
            score = score - 1;
            SetScoreText();
        }
    }
    

    
        
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 8)
        {
            winText.text = "You won with game with a score of: " + score.ToString();
        }
    }

    void SetScoreText()
    {
        scoretext.text = "Score:" + score.ToString();
    }
}