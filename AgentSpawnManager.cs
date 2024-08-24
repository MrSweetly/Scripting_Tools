using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class AgentSpawnManager : MonoBehaviour
{
   public GameObject[] agentPrefabs;

   private float spawnRangeX = 8f;
   private float spawnPosZ = 20f;

   private float startDelay = 2f;
   private float spawnInterval = 1.5f;
   

   void Start()
   {
      // Spawn Agents at a set interval
      InvokeRepeating("AgentSpawnRandom", startDelay, spawnInterval);
   }

   void AgentSpawnRandom()
   {
      // Agent spawn position
      Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
      // Select Agents in index to spawn at random
      int agentIndex = Random.Range(0, agentPrefabs.Length);
      // Spawn random Agents from index at a positon in the correct rotation
      Instantiate(agentPrefabs[agentIndex], spawnPos, ufoPrefabs[agentIndex].transform.rotation);
   }
}
