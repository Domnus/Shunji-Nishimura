using UnityEngine;

public class Spawnpoint : MonoBehaviour
{
    private void OnEnable()
    {
        // Registra este spawnpoint com o gerenciador quando � ativado
        SpawnpointManager.RegisterSpawnpoint(transform);
    }

    private void OnDisable()
    {
        // Libera este spawnpoint quando � desativado
        SpawnpointManager.ReleaseSpawnpoint(transform);
    }
}
