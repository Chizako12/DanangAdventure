using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject WinText;
    public Player PlayerScore;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerScore.score == 3){
            WinText.gameObject.SetActive(true);
        }
    }
}
