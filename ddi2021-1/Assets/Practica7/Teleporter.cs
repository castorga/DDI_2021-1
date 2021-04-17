using UnityEngine;

public class Teleporter : Initiative
{
    public Vector3 offset;
    public override void doInitiative() {
        Transform player = GameObject.FindGameObjectWithTag("Player").transform;
        if (player != null)
        {
            player.position = this.transform.position + offset;
        }
    }
}
