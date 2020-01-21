using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class BirdControler : MonoBehaviour
{

    public float flapSpeed = 200f;
    public float maxFlapSpeed = 100;
    public float forwordSpeed = 100f;

    private Rigidbody2D rbody;
    private Animator animator;

    private bool didFlap;
    private bool isDead;
    private bool gameStarted;

    private Vector3 originaPosition;
    private GameObject startButton;
    private GameObject gameOver;

    public int score;
    public int highScore;
    

    public void Start()
    {
        this.rbody = this.GetComponent<Rigidbody2D>();
        this.animator = this.GetComponent<Animator>();
        this.startButton = GameObject.Find("StartButton");
        this.gameOver = GameObject.Find("Gameover");

        this.originaPosition = new Vector3(this.transform.position.x, this.transform.position.y);

        this.forwordSpeed = 0;
        this.rbody.gravityScale = 0;
        this.animator.enabled = false;

    }
    // read input, change graphics
    public void Update()
    {


        if (Input.GetButtonDown("Fire1"))
        {
            if (!isDead)
            {
                if (!this.gameStarted)
                {

                    UnityEngine.SpriteRenderer renderer = startButton.GetComponent<SpriteRenderer>();
                    UnityEngine.SpriteRenderer rend = gameOver.GetComponent<SpriteRenderer>();

                    rend.enabled = false;
                    renderer.enabled = false;

                    this.forwordSpeed = 0.6f;
                    this.rbody.gravityScale = 1.5f;
                    this.animator.enabled = true;

                }
                this.didFlap = true;
            }
            else
            {
                score = 0;
                UnityEngine.SceneManagement.SceneManager.LoadScene("Play");
            }
        }

    }
    // apply phisics
    public void FixedUpdate()
    {
        Vector2 velosity = this.rbody.velocity;
        velosity.x = this.forwordSpeed;
        this.rbody.velocity = velosity;

        if (velosity.y > 1.05)
        {
            this.rbody.MoveRotation(30);
        }
        else if (!isDead)
        {

            var angle = velosity.y * 60;
            if (angle < -90)
            {
                angle = -90;
            }
            this.rbody.MoveRotation(angle);

        }

        if (didFlap)
        {
            didFlap = false;
            this.rbody.AddForce(new Vector2(0, flapSpeed));

            Vector2 updatedVelosity = this.rbody.velocity;
            if (updatedVelosity.y > this.maxFlapSpeed)
            {
                updatedVelosity.y = this.maxFlapSpeed;
                this.rbody.velocity = updatedVelosity;
            }
            // TODO: velosity check
        }

    }

    public void OnCollisionEnter2D(Collision2D collider)
    {

        if (collider.gameObject.CompareTag("Floor") || collider.gameObject.CompareTag("PipeCollision"))
        {
            isDead = true;
            this.animator.SetBool("BirdDead", true);
            Debug.Log("icaka");
            this.forwordSpeed = 0;

            var currentScore = PlayerPrefs.GetInt("HighScore");
            if (this.score > currentScore)
            {
                PlayerPrefs.SetInt("HighScore", this.score);
            }

            UnityEngine.SpriteRenderer renderer = startButton.GetComponent<SpriteRenderer>();
            UnityEngine.SpriteRenderer rend = gameOver.GetComponent<SpriteRenderer>();

            rend.enabled = true;
            renderer.enabled = true;

            System.Single startButtonX = Camera.main.transform.position.x;
            System.Single startButtonY = Camera.main.transform.position.y;

            UnityEngine.Vector3 startButtonPosition = this.startButton.transform.position;
            startButtonPosition.x = startButtonX;
            startButtonPosition.y = startButtonY;
            this.startButton.transform.position = startButtonPosition;

            UnityEngine.Vector3 gameOverPosition = this.gameOver.transform.position;
            var place = Camera.main.transform.position.x;
            var place1 = Camera.main.transform.position.y;
            place += 1.77f;
            place1 += 0.2f;
            gameOverPosition.x = place;
            gameOverPosition.y = place1;
            this.gameOver.transform.position = gameOverPosition;

        }
    }
    private int highscr = 0;
    //public string path = Application.persistentDataPath + "score.txt";
    //public string currentPath = Application.persistentDataPath + "Currentscore.txt";

    //public int ChekForScore()
    //{
    //    using (StreamReader read = new StreamReader(@"C:\Users\Pencho\Documents\Flappy bird game\score.txt"))
    //    {
    //        highscr = int.Parse(read.ReadLine());
    //    }

    //    return highscr;
    //}

    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Pipe"))
        {
            this.score++;

            var point = PlayerPrefs.GetInt("Score");
            PlayerPrefs.SetInt("Score", this.score);

            //using (StreamWriter writeCurrentScore = new StreamWriter(@"C:\Users\Pencho\Documents\Flappy bird game\Currentscore.txt"))
            //{
            //    writeCurrentScore.WriteLine(this.score.ToString());
            //}

            //if (this.score > ChekForScore())
            //{
            //    highscr++;
            //    using (StreamWriter write = new StreamWriter(@"C:\Users\Pencho\Documents\Flappy bird game\score.txt"))
            //    {
            //        write.WriteLine(highscr.ToString());
            //    }

            //}
            Debug.Log(this.score);
            Debug.Log(this.highScore);
            
        }
    }
    public void StopGame()
    {
        Time.timeScale = 0;
    }
}