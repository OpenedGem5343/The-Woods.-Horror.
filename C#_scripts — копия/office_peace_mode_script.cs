using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class office_peace_mode_script : MonoBehaviour
{
    // note
    public GameObject note;

    // computer
    public Image computer;
    public InputField passcode;
    public Button This_computer;
    public Button close_computer;
    public Image window_1;
    public Image _5343_window;

    // cat
    public Text meow;

    // corridor
    public Image corridor;
    public Button go_left;
    public Button go_right;
    public Button exit_corridor;
    public Sprite[] corridor_sprites;

    // closet
    public Image closet;
    public Image _5343_list;

    // note
    public void Open_note()
    {
        note.gameObject.SetActive(true);
    }

    public void Close_note()
    {
        note.gameObject.SetActive(false);
    }

    // computer
    public void Open_computer()
    {
        computer.gameObject.SetActive(true);
        passcode.gameObject.SetActive(true);
        close_computer.gameObject.SetActive(true);
        This_computer.gameObject.SetActive(false);
    }

    public void Close_computer()
    {
        passcode.text = "";
        computer.gameObject.SetActive(false);
        This_computer.gameObject.SetActive(false);
        window_1.gameObject.SetActive(false);
    }

    public void SubmitInput(string input_)
    {
        if (input_ == "L?mb0")
        {
            This_computer.gameObject.SetActive(true);
            window_1.gameObject.SetActive(false);

            passcode.gameObject.SetActive(false);
        }
        else
        {
            HideButtons();
        }
    }

    public void HideButtons()
    {
        This_computer.gameObject.SetActive(false);
        // Подписываемся на событие изменения текста в InputField
        passcode.onEndEdit.AddListener(SubmitInput);
    }

    public void Window_1_open()
    {
        window_1.gameObject.SetActive(true);
    }

    public void Window_1_close()
    {
        window_1.gameObject.SetActive(false);
    }

    public void _5343_window_open()
    {
        _5343_window.gameObject.SetActive(true);
    }

    public void _5343_window_close()
    {
        _5343_window.gameObject.SetActive(false);
    }

    // cat
    public void Pat_cat()
    {
        StartCoroutine(Pat_());
    }

    public IEnumerator Pat_()
    {
        meow.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        meow.gameObject.SetActive(false);
    }

    // corridor
    public void Enter_corridor()
    {
        corridor.gameObject.SetActive(true);
        exit_corridor.gameObject.SetActive(true);
        go_left.gameObject.SetActive(true);
        corridor.sprite = corridor_sprites[0];
    }

    public void Exit_corridor()
    {
        corridor.gameObject.SetActive(false);
        exit_corridor.gameObject.SetActive(false);
        go_left.gameObject.SetActive(false);
    }

    public void Go_left()
    {
        go_left.gameObject.SetActive(false);
        go_right.gameObject.SetActive(true);
        exit_corridor.gameObject.SetActive(false);
        corridor.sprite = corridor_sprites[1];
    }

    public void Go_right()
    {
        go_left.gameObject.SetActive(true);
        go_right.gameObject.SetActive(false);
        exit_corridor.gameObject.SetActive(true);
        corridor.sprite = corridor_sprites[0];
    }

    // closet
    public void open_closet()
    {
        closet.gameObject.SetActive(true);
    }

    public void close_closet()
    {
        closet.gameObject.SetActive(false);
    }

    public void open_5343_list()
    {
        _5343_list.gameObject.SetActive(true);
    }

    public void close_5343_list()
    {
        _5343_list.gameObject.SetActive(false);
    }
}
