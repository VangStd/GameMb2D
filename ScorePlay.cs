using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ScorePlay : MonoBehaviour
{
    public Text textt;
    int score ;
    static int i = 0;
    void Start()
    {
        score = 0;
    }
    void Update()
    {
        score = Mathf.FloorToInt(Time.time / 1);
        textt.text = "Score : " + (score + (i * 20));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Gif")
        {
            i++;
            Destroy(other.gameObject);
        }
    }
}
