using UnityEngine;

public class ExitScript : MonoBehaviour
{
    //Player calls this function when all coins are collected!
    public void Open()
    {
        Destroy(gameObject);
    }
}
