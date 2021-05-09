using UnityEngine;


[RequireComponent(typeof(BoxCollider2D))]
public class ScoreCounter : MonoBehaviour
{
    [SerializeField]
    CountVariable score;

    [SerializeField]
    Direction direction;

    private bool active = true;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (!collider.CompareTag("Projectile") || !active)
            return;

        if (collider.GetComponent<Projectile>().Direction == direction) {
            score.Value += 1;
        }
    }

    public void Stop()
    {
        active = false;
    }
}
