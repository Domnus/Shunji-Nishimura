using System.Collections.Generic;
using UnityEngine;

public class SpawnpointManager : MonoBehaviour
{
    private static List<Transform> availableSpawnpoints = new List<Transform>();

    public static void RegisterSpawnpoint(Transform spawnpoint)
    {
        if (!availableSpawnpoints.Contains(spawnpoint))
        {
            availableSpawnpoints.Add(spawnpoint);
        }
    }

    public static Transform GetAvailableSpawnpoint()
    {
        if (availableSpawnpoints.Count > 0)
        {
            Transform spawnpoint = availableSpawnpoints[0];
            availableSpawnpoints.RemoveAt(0);
            return spawnpoint;
        }
        return null;
    }

    public static void ReleaseSpawnpoint(Transform spawnpoint)
    {
        if (!availableSpawnpoints.Contains(spawnpoint))
        {
            availableSpawnpoints.Add(spawnpoint);
        }
    }
}
