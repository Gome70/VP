using UnityEngine;

public class pointTextShakeScript : MonoBehaviour{

    public Transform text;
    Vector3 startPosition;
    private float power = 0;
    private float points;
    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.transform;
        startPosition = text.localPosition;
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // shakes text
        text.localPosition = startPosition + Random.insideUnitSphere * power;
        // Adjusts shake power depending on point value
        GameObject gameManager = GameObject.Find("GameManager");
        gameManagerScript gameManager_script = gameManager.GetComponent<gameManagerScript>();
        points = gameManager_script.pointCounter;
        power = points * 0.01f;
    }
}

