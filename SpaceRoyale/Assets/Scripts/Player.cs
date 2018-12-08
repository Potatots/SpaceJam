using UnityEngine;

public class Player
{
    public int Reputation { get; set; }

<<<<<<< HEAD
    public Player()
    {
=======
    public Rigidbody2D RigidBody { get; set; }
    public Vector2 MovementVector { get; set; }

    public Player()
    {
        RigidBody = new Rigidbody2D();
        MovementVector = new Vector2();
>>>>>>> parent of b52af0b... costam
    }
}
