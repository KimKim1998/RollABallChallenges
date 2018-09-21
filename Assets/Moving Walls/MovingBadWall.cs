using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingBadWall : MonoBehaviour
{


    public Text scoreText;

    private int score;

    void Start()
    {
        SetScoreText();
    }

   private void OnCollisionEnter(Collision collision)
    {

        if (gameObject.CompareTag("RedMovingWall"))

        {
            gameObject.SetActive(true);
            score = score - 1;
            SetScoreText();
        }
    }




    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.up, 100 * Time.deltaTime);
    }


    void SetScoreText()
    {
        scoreText.text = "Score:" + score.ToString();
    }
}
    
    
    

        
            

    
            



             




