using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using System.Linq;
using Random = System.Random;

public class BackGroundColaidControler : MonoBehaviour
{

    private int numberOfBackgrounds = 0;
    private float distanceBettweanBackground = 100;

    private int numberOfGrounds = 0;
    private float distanceBetteanGrounds = 100;

    private int numberOfPipes = 0;
    private float distanceBettweanPipes = 100;

    private System.Single randomY;

    public void Start()
    {

        GameObject[] backgrounds = GameObject.FindGameObjectsWithTag("Background");
        GameObject[] grounds = GameObject.FindGameObjectsWithTag("Ground");
        GameObject[] pipeObj = GameObject.FindGameObjectsWithTag("Pipe");

        RandomizePipes(pipeObj);

        this.numberOfBackgrounds = backgrounds.Length;
        this.numberOfGrounds = grounds.Length;
        this.numberOfPipes = pipeObj.Length;

        // max up pipe = 1, min down pipe = 0.3

        if (this.numberOfBackgrounds < 2 || this.numberOfGrounds < 2 || this.numberOfPipes < 2)
        {
            throw new InvalidOperationExeption("You must have more than two backgrounds, grounds or pipes in your scene");
        }

        this.distanceBettweanBackground = Distance(backgrounds);

        this.distanceBetteanGrounds = Distance(grounds);

        this.distanceBettweanPipes = Distance(pipeObj); //Mathf.Abs(pipeObj[1].transform.position.x - pipeObj[0].transform.position.x);
    }
    private float Distance(GameObject[] gameObj)
    {
        float minDist = float.MaxValue;
        for (int i = 1; i < gameObj.Length; i++)
        {
            var currentObj = Mathf.Abs(gameObj[i - 1].transform.position.x - gameObj[i].transform.position.x);

            if (currentObj < minDist)
            {
                minDist = currentObj;
            }
        }
        return minDist;
    }

    private void RandomizePipes(GameObject[] pipes)
    {
        int countPipes = 0;
        for (int i = 0; i < pipes.Length; i++)
        {
            countPipes++;

           // this.randomY = UnityEngine.Random.Range(0.1f, 0.9f);

            if (countPipes % 2 == 0)
            {
                this.randomY = UnityEngine.Random.Range(0.1f, 0.6f);
            }
            else
            {
                this.randomY = UnityEngine.Random.Range(0.5f, 1f);
            }
            GameObject currentPipe = pipes[i];
            Vector3 pipePosition = currentPipe.transform.position;
            pipePosition.y = this.randomY;
            currentPipe.transform.position = pipePosition;
        }
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.CompareTag("Background"))
        {
            Debug.Log("Background");
            GameObject gameObj = collider.gameObject;
            Vector3 Position = gameObj.transform.position;
            Position.x += this.numberOfBackgrounds * this.distanceBettweanBackground;
            gameObj.transform.position = Position;

        }

        if (collider.CompareTag("Ground"))
        {
            Debug.Log("Ground");
            GameObject ground = collider.gameObject;
            Vector3 groundPosition = ground.transform.position;
            groundPosition.x += this.numberOfGrounds * this.distanceBetteanGrounds;
            ground.transform.position = groundPosition;

        }

        if (collider.CompareTag("Pipe"))
        {

            Debug.Log("Pipes");
            GameObject pipe = collider.gameObject;
            Vector3 pipePosition = pipe.transform.position;
            pipePosition.x += this.numberOfPipes * 1f;//this.distanceBettweanPipes;
            pipe.transform.position = pipePosition;
        }
    }
}

[Serializable]
internal class InvalidOperationExeption : Exception
{
    public InvalidOperationExeption()
    {
    }

    public InvalidOperationExeption(string message) : base(message)
    {
    }

    public InvalidOperationExeption(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected InvalidOperationExeption(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}