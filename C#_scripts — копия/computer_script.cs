using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class computer_script : MonoBehaviour
{
    public int i = 0;

    public InputField password;
    public Button this_computer;
    public Image img;
    public Button off;

    public Image _5343_window;
    public Image _2993_window;
    public Image window_1;

    public Image _2993;
    public Image _5343;

    public Image for_documents;
    public Image for_images;

    public Button close_img;
    public Button close_document;

    public Button on_off_window_2993;

    public Button _2993_document_1;
    public Button _2993_document_2;
    public Button _2993_image_1;

    public Image _2993_document_1_img;
    public Image _2993_document_2_img;
    public Image _2993_image_1_img;

    public Sprite _2993_document_1_spr;
    public Sprite _2993_document_2_spr;

    public InputField password_for_2993_folder;



    public Image for_documents_5343;
    public Image for_images_5343;

    public Button close_img_5343;
    public Button close_document_5343;

    public Button on_off_window_5343;

    public Button _5343_document_1;
    public Button _5343_document_2;
    public Button _5343_image_1;

    public Image _5343_document_1_img;
    public Image _5343_document_2_img;
    public Image _5343_image_1_img;

    public Sprite _5343_document_1_spr;
    public Sprite _5343_document_2_spr;

    public InputField password_for_5343_folder;

    public GameObject where_need_to_put_images_from_cam_1;
    

    public Button cameras_open_button_;
    public Button cameras_close_button;
    

    public void Start()
    {
        HideFilesButton();

    }

    // Вызывается, когда пользователь завершает ввод текста
    public void SubmitInput(string input_)
    {
        if (input_ == "memory")
        {
            this_computer.gameObject.SetActive(true);
            cameras_open_button_.gameObject.SetActive(true);

            password.gameObject.SetActive(false);
        }
        else
        {
            HideFilesButton();
        }
    }

    public void HideFilesButton()
    {
        this_computer.gameObject.SetActive(false);
        cameras_open_button_.gameObject.SetActive(false);
        // Подписываемся на событие изменения текста в InputField
        password.onEndEdit.AddListener(SubmitInput);
    }

    public void Hide_2993_window()
    {
        password_for_2993_folder.onEndEdit.AddListener(SubmitInput_for_2993);
    }

    public void Enter_a_pass_for_2993()
    {
        password_for_2993_folder.gameObject.SetActive(true);

        Hide_2993_window();
    }

    public void SubmitInput_for_2993(string input_)
    {
        if (input_ == "peacemakE1")
        {
            _2993_window_open();

            password_for_2993_folder.gameObject.SetActive(false);
        }
        else
        {
            Hide_2993_window();
        }
    }

    public void ComputerOn()
    {
        img.gameObject.SetActive(true);
        password.gameObject.SetActive(true);
        off.gameObject.SetActive(true);
    }

    public void ComputerOff()
    {
        img.gameObject.SetActive(false);
        password.gameObject.SetActive(false);
        password.text = "";
        this_computer.gameObject.SetActive(false);
        window_1.gameObject.SetActive(false);
        password_for_2993_folder.text = "";
        cameras_open_button_.gameObject.SetActive(false);
        where_need_to_put_images_from_cam_1.gameObject.SetActive(false);
    }

    public void Window_1_Open()
    {
        
        window_1.gameObject.SetActive(true);
        password_for_2993_folder.gameObject.SetActive(false);
        _2993_window.gameObject.SetActive(false);
    }

    public void Window_1_Close()
    {
        
        window_1.gameObject.SetActive(false);
        password_for_2993_folder.text = "";
    }

    public void _2993_window_open()
    {
        _2993_window.gameObject.SetActive(true);
        _2993_document_1.gameObject.SetActive(true);
        _2993_document_2.gameObject.SetActive(true);
        _2993_image_1.gameObject.SetActive(true);
        _2993_document_1_img.gameObject.SetActive(true);
        _2993_document_1_img.gameObject.SetActive(true);
        _2993_document_2_img.gameObject.SetActive(true);

        for_documents.gameObject.SetActive(false);
        for_images.gameObject.SetActive(false);
        close_img.gameObject.SetActive(false);
        close_document.gameObject.SetActive(false);

    }

    public void _2993_document_1_open()
    {
        for_documents.gameObject.SetActive(true);
        for_documents.sprite = _2993_document_1_spr;
        close_document.gameObject.SetActive(true);
    }

    public void _2993_document_close()
    {
        for_documents.gameObject.SetActive(false);
        for_documents.sprite = null;
        close_document.gameObject.SetActive(false);
    }

    public void _2993_document_2_open()
    {
        for_documents.gameObject.SetActive(true);
        for_documents.sprite = _2993_document_2_spr;
        close_document.gameObject.SetActive(true);
    }

    public void _2993_image_open()
    {
        for_images.gameObject.SetActive(true);
        close_img.gameObject.SetActive(true);
    }

    public void _2993_image_close()
    {
        for_images.gameObject.SetActive(false);
        close_img.gameObject.SetActive(false);
    }


    
    ////////////////////////////////////////////////////////////////////////////
    


    public void Hide_5343_window()
    {
        password_for_5343_folder.onEndEdit.AddListener(SubmitInput_for_5343);
    }

    public void Enter_a_pass_for_5343()
    {
        password_for_5343_folder.gameObject.SetActive(true);

        Hide_5343_window();
    }

    public void SubmitInput_for_5343(string input_5343)
    {
        if (input_5343 == "pr0t0p@gen")
        {
            _5343_window_open();

            password_for_5343_folder.gameObject.SetActive(false);
        }
        else
        {
            Hide_5343_window();
        }
    }




    public void _5343_window_open()
    {
        _5343_window.gameObject.SetActive(true);
        _5343_document_1.gameObject.SetActive(true);
        _5343_document_2.gameObject.SetActive(true);
        _5343_image_1.gameObject.SetActive(true);
        _5343_document_1_img.gameObject.SetActive(true);
        _5343_document_1_img.gameObject.SetActive(true);
        _5343_document_2_img.gameObject.SetActive(true);

        for_documents_5343.gameObject.SetActive(false);
        for_images_5343.gameObject.SetActive(false);
        close_img_5343.gameObject.SetActive(false);
        close_document_5343.gameObject.SetActive(false);

    }

    public void _5343_document_1_open()
    {
        for_documents_5343.gameObject.SetActive(true);
        for_documents_5343.sprite = _5343_document_1_spr;
        close_document_5343.gameObject.SetActive(true);
    }

    public void _5343_document_close()
    {
        for_documents_5343.gameObject.SetActive(false);
        for_documents_5343.sprite = null;
        close_document_5343.gameObject.SetActive(false);
    }

    public void _5343_document_2_open()
    {
        for_documents_5343.gameObject.SetActive(true);
        for_documents_5343.sprite = _5343_document_2_spr;
        close_document_5343.gameObject.SetActive(true);
    }

    public void _5343_image_open()
    {
        for_images_5343.gameObject.SetActive(true);
        close_img_5343.gameObject.SetActive(true);
    }

    public void _5343_image_close()
    {
        for_images_5343.gameObject.SetActive(false);
        close_img_5343.gameObject.SetActive(false);
    }

    ///////////////////////////////////////////////

    public void cameras_open()
    {
        
        

        
        where_need_to_put_images_from_cam_1.SetActive(true);
        
    }

    
    

    public void close_cameras()
    {
        where_need_to_put_images_from_cam_1.gameObject.SetActive(false);
        
    }

    
}
