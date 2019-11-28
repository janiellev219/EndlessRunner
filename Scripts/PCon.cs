using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PCon : MonoBehaviour
{
    public Text ScoreText;
    public float Score = 0;
    Rigidbody rb;
  

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ScoreText.text = "Score: " + Score.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        

        Score += Time.deltaTime;
        ScoreText.text = "Score: " + Score.ToString("0");

        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(new Vector3(-5, 0, 0), ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(new Vector3(5, 0, 0), ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 7, 0), ForceMode.Impulse);
        }

    }
   



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("Closing");


        }
        else if (collision.gameObject.tag == "Apple")
        {
            Score += 10;
            ScoreText.text = "Score: " + Score.ToString("0");
            Destroy(collision.gameObject);
        }
    }
}
