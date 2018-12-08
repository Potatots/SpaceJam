﻿using UnityEngine;

public enum eAction
{
    Empty,
    Shoot,
    StartMove,
    StopMove
}

public class ActionController : MonoBehaviour
{
    public eAction CurrentAction { get; set; }

    public eAction NextAction { get; set; }

    public Transform Rocket;
    public Transform Radar;

    private Rigidbody2D _rigidbody;

    public int Speed;

    void Start()
    {
        Random rnd = new Random();
        CurrentAction = (eAction)Random.Range(1, 3);
        NextAction = (eAction)Random.Range(1, 3);
        _rigidbody = GetComponent<Rigidbody2D>();
        Speed = 10;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Action();
        }
    }

    void Action()
    {
        if(CurrentAction == eAction.Shoot)
        {
            Instantiate(Rocket, transform.position, Radar.rotation);

            CurrentAction = NextAction;
            NextAction = (eAction)Random.Range(1, 3);
        }
        else if(CurrentAction == eAction.StartMove)
        {
            StartMove(Radar.rotation);
            CurrentAction = eAction.StopMove;
        }
        else if(CurrentAction == eAction.StopMove)
        {
            StopMove();
            
            CurrentAction = NextAction;
            NextAction = (eAction)Random.Range(1, 3);
        }
        else if(CurrentAction == eAction.Empty)
        {
            Debug.Log("Coś kurwa poszło nie tak, eAction.Empty");
        }
        Debug.Log("Aktualna akcja: " + System.Enum.GetName(typeof(eAction), CurrentAction) + "Nastepna akcja: " + System.Enum.GetName(typeof(eAction), NextAction));
    }

    public void StartMove(Quaternion qtMove)
    {
        _rigidbody.velocity = Radar.transform.right * Speed;
    }
    public void StopMove()
    {
        _rigidbody.velocity = Vector3.zero;
    }
}
