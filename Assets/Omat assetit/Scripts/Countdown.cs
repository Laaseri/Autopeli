using UnityEngine;
using TMPro;
using System.Collections;
public class Countdown : MonoBehaviour
{   
    public TMP_Text uiText;
    public int countdownFrom =3;
    public float stepSeconds = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    IEnumerator Start()
    {
        for(int i = countdownFrom; i > 0; i--)
        {
            uiText.text = i.ToString();
            yield return new WaitForSecondsRealtime(stepSeconds);


        }
        
        uiText.text = "Go";
        yield return new WaitForSecondsRealtime(0.5f);
        uiText.text = "";
        GameManager.Instance.Phase = RacePhase.Racing;
    }

}
