using UnityEngine;

public class Spawnpoint : MonoBehaviour
{
    private void OnEnable()
    {
        // Registra este spawnpoint com o gerenciador quando é ativado
        SpawnpointManager.RegisterSpawnpoint(transform);
    }

    private void OnDisable()
    {
        // Libera este spawnpoint quando é desativado
        SpawnpointManager.ReleaseSpawnpoint(transform);
    }
}
