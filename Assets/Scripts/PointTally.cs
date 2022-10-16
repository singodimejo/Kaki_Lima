using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointTally : MonoBehaviour
{
    int startTime, endTime, pointTally = 0;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0)
            pointDebugCounter();
    }

    void pointDebugCounter()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            startTime = (int)Time.time;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            endTime = (int)Time.time;
            Debug.Log(endTime - startTime);
            pointTally = pointTally + (endTime - startTime);
            scoreText.text = pointTally.ToString();

        }
    }
}
