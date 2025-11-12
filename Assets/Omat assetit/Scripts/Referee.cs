using UnityEditor.Rendering.BuiltIn.ShaderGraph;
using UnityEngine;

public class Referee : MonoBehaviour

{
    private bool winnerDeclared = false;
    private void OnTriggerEnter(Collider car)
    {
        CarIdentify id = car.GetComponent<CarIdentify>();

        string winnerName = id.display;
        if(id.kind == CarKind.Player)
        {
            var validator = car.GetComponent<Pelaajankierrostarkistus>();
            if (validator == null)
            {
                Debug.LogError("Puuttuu Pelaajankierrostarkistus scripti");
                return;
            }
            if (!validator.AllVisitedThisLap)
            {
                Debug.Log("Pelaaja ylitti maaliviivan, mutta kaikki checkpointit eivät ole kunnossa -> ei voittoa");
                return;
            }
        }
        if(winnerDeclared == false)
        {
            winnerDeclared = true;
            Debug.Log($"WINNER: {winnerName}");    
        }
        
    }
}
