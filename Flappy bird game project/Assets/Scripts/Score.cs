using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Score : MonoBehaviour
{

    private int scoreI;
    private Transform player;
    public Text scoreText;

    void Start()
    {
        PlayerPrefs.SetInt("Score", 0);

        //using (StreamWriter readScore = new StreamWriter(@"C:\Users\Pencho\Documents\Flappy bird game\Currentscore.txt"))
        //{
        //    string y = "0";
        //    readScore.WriteLine(y);
        //}
    }
    //public string HighScores()
    //{
    //    int highscr = 0;
    //    using (StreamReader read = new StreamReader(@"C:\Users\Pencho\Documents\Flappy bird game\score.txt"))
    //    {
    //        highscr = int.Parse(read.ReadLine());
    //    }
    //    return highscr.ToString();
    //}
    void Update()
    {
        var text = PlayerPrefs.GetInt("HighScore").ToString();
        var poin = PlayerPrefs.GetInt("Score").ToString();
        string stats = $"points: {poin}\nBest Score:{text}";
        scoreText.text = stats;

        //using (StreamReader readScore = new StreamReader(@"C:\Users\Pencho\Documents\Flappy bird game\Currentscore.txt"))
        //{
        //    string x = readScore.ReadLine();
        //}

    }
}