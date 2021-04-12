using UnityEngine;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    void Update()
    {
        float z = Math.Max(player.position.z, 0);
        scoreText.text = z.ToString("0");
    }
}
