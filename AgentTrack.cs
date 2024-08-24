using UnityEngine;

public class AgentTrack : MonoBehaviour
{
    public float speed;
    private Rigidbody agentRb;
    private GameObject player;
    
    void Start()
    {
        agentRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }
    
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        agentRb.AddForce(lookDirection * speed);
    }
}
