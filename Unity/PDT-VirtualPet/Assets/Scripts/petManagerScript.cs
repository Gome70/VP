using UnityEngine;
using UnityEngine.UI;

public class petManagerScript : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public Animator faceAnimationController;
    private float Food;
    private float Happiness;
    private float Clean;
    private float Health;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        GameObject face = GameObject.Find("PetFace");
        faceAnimationController = face.GetComponent<Animator>();
        Food = 100;
        Happiness = 100;
        Clean = 100;
        Health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        // Maintenance data to UI Progressbar
        progressBar(Food,Happiness,Clean,Health);
        // Maintenance down tick 
        if (Food >= 0)
        {
            Food = Food - 1 * Time.deltaTime * 0.1f;
        }
        if (Happiness >= 0)
        {
            Happiness = Happiness - 1 * Time.deltaTime * 1.0f;
        }
        if (Clean >= 0)
        {
            Clean = Clean - 1 * Time.deltaTime * 0.1f;
        }
        if (Health >= 0)
        {
            Health = Health - 1 * Time.deltaTime * 0.1f;
        }
        happinessCheck(Happiness);
    }

    void OnMouseDown()
    {
        // Pet bounce on mouse click
        rb2D.AddForce(transform.up * -8, ForceMode2D.Impulse);
        faceAnimationController.SetTrigger("Blink");
        // Add 1 point to maintenance each mouse click
        if (Happiness <= 99)
        {
            Happiness = Happiness + 1;
        }
    }
    void progressBar(float FoodValue, float happinessValue, float CleanValue, float HealthValue)
    {
        GameObject foodProgressBar = GameObject.Find("Food_Progressbar");
        GameObject happinessProgressBar = GameObject.Find("Happiness_Progressbar");
        GameObject cleanProgressBar = GameObject.Find("Clean_Progressbar");
        GameObject healthProgressBar = GameObject.Find("Health_Progressbar");
        Slider foodProgressBarSlider = foodProgressBar.GetComponent<Slider>();
        Slider happinessProgressBarSlider = happinessProgressBar.GetComponent<Slider>();
        Slider cleanProgressBarSlider = cleanProgressBar.GetComponent<Slider>();
        Slider healthProgressBarSlider = healthProgressBar.GetComponent<Slider>();
        foodProgressBarSlider.value = FoodValue / 100;
        happinessProgressBarSlider.value = happinessValue / 100;
        cleanProgressBarSlider.value = Clean / 100;
        healthProgressBarSlider.value = Health / 100;
    }

    void happinessCheck(float Happiness)
    {
        if (Happiness >= 75)
        {
            faceAnimationController.SetTrigger("Happy");
        }
        else if (Happiness >= 35)
        {
            faceAnimationController.SetTrigger("Neutral");
        }
        else if(Happiness <=35)
        {
            faceAnimationController.SetTrigger("Sad");
        }
    }
}
