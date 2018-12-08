using UnityEngine;

public enum eAction
{
    Empty,
    Shoot,
    Move
}

public class ActionController : MonoBehaviour
{
    public eAction CurrentAction { get; set; }

    public Transform Rocket;
    public Transform Radar;

    void Start()
    {
        CurrentAction = eAction.Shoot;
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
            Instantiate(Rocket, GetComponent<Transform>().position, Radar.rotation);
        }
        else if(CurrentAction == eAction.Move)
        {

        }
        else if(CurrentAction == eAction.Empty)
        {

        }
    }
}
