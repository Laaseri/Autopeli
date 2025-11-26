using UnityEngine;
using TMPro;
using System.Collections;
public class Countdown : MonoBehaviour
{   
    public TMP_Text uiText;
    public int countdownFrom =3;
    public float stepSeconds = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    IEnumerator Start()
    {
        for(int i = countdownFrom; i < 0; i--)
        {
            uiText.text = countdownFrom.ToString();
            yield return new WaitForSecondsRealtime(stepSeconds);


        }
        
        uiText.text = "Go";
        GameManager.Instance.Phase = RacePhase.Racing;
    }

}
