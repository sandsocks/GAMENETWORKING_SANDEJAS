using Fusion;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class NetworkPlayer : NetworkBehaviour
{
    [SerializeField] private MeshRenderer _meshRenderer;

    [Header("Network Properties")]
    [Networked] public Vector3 NetworkedPosition { get :set }
        
    #region Fusion Callbacks
    public override void Spawned()
    {
        
    }

    public override void Despawned(NetworkRunner runner, bool hasState)
    {
        
    }

    public override void FixedUpdateNetwork()
    {
        
    }
    public override void Render()
    {

    }
    #endregion
}
