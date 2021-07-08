using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool  end;
    public int SceneNum;
    void Update()
    {
        if (timeRemaining > 0)
        {   
            timeRemaining -= Time.deltaTime;
        }else{
            SceneManager.LoadScene(SceneNum);
        }
    }
}