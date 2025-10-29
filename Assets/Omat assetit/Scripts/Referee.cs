using UnityEngine;

public class Referee : MonoBehaviour
{
    private void OnTriggerEnter(Collider car)
    {
        CarIdentify id = car.GetComponent<CarIdentify>();
        string winnerName = id.display;
        Debug.Log($"WINNER: {winnerName}");
    }
}
