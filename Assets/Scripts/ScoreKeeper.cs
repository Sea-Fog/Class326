using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public Text leftScoreText;
    public Text rightScoreText;
    private int leftScore = 0;
    private int rightScore = 0;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            rightScoreText.text = string.Format("right score = {0}", rightScore++);
            if (rightScore > 5) rightScoreText.color = Color.blue;
            
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            leftScoreText.text = string.Format("{0}", leftScore++);
            if (leftScore > 5) leftScoreText.color = Color.red;
        }
    }
}
