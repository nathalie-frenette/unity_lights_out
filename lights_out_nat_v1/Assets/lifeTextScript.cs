using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lifeTextScript : MonoBehaviour
{
    public static int livesInt = 3;
    Text lives;
    // Start is called before the first frame update
    void Start()
    {
        lives = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        lives.text = "" + livesInt;
    }
}
