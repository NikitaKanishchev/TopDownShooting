using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;

    public int positionofPatrol;
    public Transform point;
    private bool _moovingRight;

    //The logic of patrolling the enemy at a certain point
    private Transform player;
    public float stoppingDistance;

    public bool chill = false;
    public bool angry = false;

    public bool goBack = false;

    public void Update() //The logic in which the enemy starts moving towards the player
    {
        if (Vector2.Distance(transform.position, point.position) < positionofPatrol && !angry)
        {
            chill = true;
        }


        if (Vector2.Distance(transform.position, player.position) < stoppingDistance)
        {
            chill = false;
            angry = true;
            goBack = false;
        }

        if (Vector2.Distance(transform.position, player.position) > stoppingDistance)
        {
            goBack = true;
            angry = false;
        }
       
        if (chill)
            Chill();

        else if (angry)
            Angry();
        
        else if (goBack)
            GoBack();
    }

    private void Start() => player = GameObject.FindGameObjectWithTag("Player").transform;

    private void Chill() //patrolling
    {
        if (transform.position.x > point.position.x + positionofPatrol)
            _moovingRight = false;
        else if (transform.position.x < point.position.x - positionofPatrol) 
            _moovingRight = true;

        if (_moovingRight)
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        else 
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
    }

    void Angry() => transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    //starts moving behind the player
    
    void GoBack() => transform.position = Vector2.MoveTowards(transform.position, point.position, speed * Time.deltaTime);
    //Finishes the movement behind the player
}
