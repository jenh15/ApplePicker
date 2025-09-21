using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   // This line enables use of uGUI classes like Text
using TMPro;

public class RoundCounter : MonoBehaviour
{
    public int roundNum = 1;
    private TextMeshProUGUI roundText;
    
    // Start is called before the first frame update
    void Start()
    {
        roundText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        roundText.text = "Round " + roundNum.ToString();
    }
}
