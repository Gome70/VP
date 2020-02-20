using UnityEngine;
using UnityEngine.UI;

public class navigationManager : MonoBehaviour
{
    private Animator consoleAnimator;
    private GameObject socket;
    void Start() 
    {
        socket = gameObject;
        GameObject consoleSocket = GameObject.Find("Concole_Socket");
        consoleAnimator = consoleSocket.GetComponent<Animator>();
    }
    void OnMouseDown()
    {
        consoleAnimator.SetTrigger(""+ socket.transform.name);
    }
}
