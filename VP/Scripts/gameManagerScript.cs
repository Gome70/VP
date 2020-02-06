using UnityEngine;
using UnityEngine.UI;

public class gameManagerScript : MonoBehaviour
{
    public Text text_points;
    
    public float pointCounter;
    // Start is called before the first frame update
    void Start()
    {
        pointCounter = 0f;
        text_points.text = "" + pointCounter + " Points";
    }

    // Update is called once per frame
    void Update()
    {
        pointCounter = pointCounter + 0.1f * Time.deltaTime;
        text_points.text = "" + pointCounter.ToString("F1") + " Points";
    }
}
