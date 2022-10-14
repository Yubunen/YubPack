using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YubPack.Mahjong;

public class MahTest : MonoBehaviour
{
    Hai hai;

    // Start is called before the first frame update
    void Start()
    {
        hai = new Hai(4, 2);
        Debug.Log(hai.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
