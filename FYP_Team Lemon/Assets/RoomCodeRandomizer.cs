using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomCodeRandomizer : MonoBehaviour
{
    public Text RandomCodeText;

    public int minNumber = 1;
    public int maxNumber = 4;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ChangeSceneNormalMap1.NormMap1 == true && ChangeSceneNormalMap1norm.NormMap1Norm == true)
        {
            ChangeSceneNormalMap1.NormMap1 = false;
            ChangeSceneNormalMap1norm.NormMap1Norm = false;
            int randomNumber = Random.Range(minNumber, maxNumber);
            Debug.Log(randomNumber);
            if (randomNumber == 1)
            {
                RandomCodeText.text = "Room Code: NM1N1";
            }
            else if (randomNumber == 2)
            {
                RandomCodeText.text = "Room Code: NM1N2";
            }
            else if (randomNumber == 3)
            {
                RandomCodeText.text = "Room Code: NM1N3";
            }
        }
    }
}
