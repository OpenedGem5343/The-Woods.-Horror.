using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ONinBasement_script : MonoBehaviour
{
    public GameObject door_1;

    public GameObject flashlight;

    public bool is_open = true;
    public bool flashlight_is_true = false;

    public float current_energy = 100f;
    public float current_time = 0f;

    public Text txt_;
    public Text energy;

    public Transform monster;

    public float time = 0f;
    public float randomTime;

    public List<Vector3> positions = new List<Vector3>();

    public int i = 0;

    public Image img;
    public Sprite[] spr;
    public Button button;

    [SerializeField] private GameObject loadingScreen;
    [SerializeField] private Slider slider;

    void Start()
    {
        // Инициализация randomTime здесь
        randomTime = UnityEngine.Random.Range(8f, 14f);

        img.gameObject.SetActive(false);
        button.gameObject.SetActive(false);
    }

    

    public void OnMouseDown()
    {
        if (is_open && current_energy > 0f)
        {
            door_1.transform.position = new Vector3(-1.15f, 1.41f, -4.21f);
            is_open = false;
        }
        else
        {
            door_1.transform.position = new Vector3(-1.15f, 4.94f, -4.21f);
            is_open = true;
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl) && flashlight_is_true == false)
        {
            flashlight.SetActive(true);
            flashlight_is_true = true;
        }
        else if (Input.GetKeyDown(KeyCode.LeftControl) && flashlight_is_true == true)
        {
            flashlight.SetActive(false);
            flashlight_is_true = false;
        }
        if (current_energy > 0f)
        {
            current_energy -= 0.001f;
        }
        if (is_open == false && current_energy > 0f)
        {
            current_energy -= 0.01f;
        }

        if (current_energy <= 0f)
        {
            door_1.transform.position = new Vector3(-1.15f, 4.94f, -4.21f);
        }

        energy.text = current_energy + "%";

        current_time += Time.deltaTime;

        if (current_time >= 0f && current_time <= 60f)
        {
            txt_.text = "12 P.M.";
        }
        else if (current_time >= 61f && current_time <= 120f)
        {
            txt_.text = "1 A.M.";
        }
        else if (current_time >= 121f && current_time <= 180f)
        {
            txt_.text = "2 A.M.";
        }
        else if (current_time >= 181f && current_time <= 240f)
        {
            txt_.text = "3 A.M.";
        }
        else if (current_time >= 241f && current_time <= 300f)
        {
            txt_.text = "4 A.M.";
        }
        else if (current_time >= 301f && current_time <= 360f)
        {
            txt_.text = "5 A.M.";
        }
        else if (current_time >= 361f)
        {
            img.sprite = spr[2];

            StartCoroutine(wait_());

            LoadLevel(1);
        }

        if (current_time <= 360)
        {
            time += Time.deltaTime;

            if (time >= randomTime)
            {
                monsterTeleport();

                time = 0f;
            }
        }

    }

    public void monsterTeleport()
    {
        
        i++;
        
        if (i == positions.Count)
        {
            i = 0;

            StartCoroutine(die_or_live());
        }

        monster.transform.position = positions[i];
    }

    public IEnumerator die_or_live()
    {
        yield return new WaitForSeconds(5f);

        if (is_open == true)
        {
            img.gameObject.SetActive(true);
            img.sprite = spr[0];

            yield return new WaitForSeconds(3f);

            img.sprite = spr[1];
            button.gameObject.SetActive(true);
        }

        yield return null;
    }


    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }

    private IEnumerator LoadAsynchronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        loadingScreen.SetActive(true);
        while (operation.isDone == false)
        {
            float progress = operation.progress;
            slider.value = progress;
            yield return null;
        }
    }

    public IEnumerator wait_()
    {
        yield return new WaitForSeconds(3f);
        yield return null;
    }
}
