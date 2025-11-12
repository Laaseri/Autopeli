using UnityEngine;

public class Checkpointtarkistus : MonoBehaviour
{
    public int orderIndex = 0;

    private void OnTriggerEnter(Collider other)
    {
        Pelaajankierrostarkistus validator = other.GetComponent<Pelaajankierrostarkistus>();
        if(validator != null)
        {
            validator.MarkVisited(orderIndex);
        }

    }

}
