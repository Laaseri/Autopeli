using UnityEngine;
public enum CarKind{Player,AI}
public class CarIdentify : MonoBehaviour
{
    public string display = "Player";
    public CarKind kind = CarKind.Player;
}
