using UnityEngine;
using UnityEngine.AI;

public class EnemyStopIfClose : MonoBehaviour
{
    Transform target;
    NavMeshAgent agent;

    [SerializeField] private float stoppingDis;
    void Start()
    {
        target = PlayerManager.instace.player.transform;
        agent = GetComponent<NavMeshAgent>(); }
    
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance < stoppingDis) {
            FaceTarget();
            StopAgent(); }
        else {
            agent.isStopped = false; }
    }

    void StopAgent()
    {
        agent.isStopped = true;
    }
    
    void FaceTarget()
    {
        var turnSpeed = Time.deltaTime * 5f;
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, turnSpeed);
    }
}
