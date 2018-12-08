using UnityEngine;

public class Player
{
    public int Reputation { get; set; }

    public Rigidbody2D RigidBody { get; set; }
    public Vector2 MovementVector { get; set; }

    public Player()
    {
        RigidBody = new Rigidbody2D();
        MovementVector = new Vector2();
    }
}
