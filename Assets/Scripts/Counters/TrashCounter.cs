using System;
using Unity.Netcode;
using UnityEngine;

public class TrashCounter : BaseCounter
{

    public static event EventHandler OnAnyObjectTrash;

    new public static void ResetStaticData()
    {
        OnAnyObjectTrash = null;
    }

    public override void Interact(Player player)
    {
        if (player.HasKitchenObject())
        {
            KitchenObject.DestroyKitchenObject(player.GetKitchenObject());

            InteractLogicServerRPC();
        }
    }

    [ServerRpc(RequireOwnership = false)]
    private void InteractLogicServerRPC()
    {
        InteractLogicClientRPC();
    }

    [ClientRpc]
    private void InteractLogicClientRPC()
    {
        OnAnyObjectTrash?.Invoke(this, EventArgs.Empty);
    }
}
