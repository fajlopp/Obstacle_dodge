using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    Vector3 playerPosition;
    [SerializeField] float projectileSpeed = 1f;

    void Start()
    {
        playerPosition = player.transform.position;

    }


    void Update()
    {
        MoveTowardsPlayer();
        DestroyWhenReached();
    }

    void MoveTowardsPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, projectileSpeed * Time.deltaTime);        
    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }

    }
}
