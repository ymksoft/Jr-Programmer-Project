using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public Color TeamColor;

    private void Awake()
    {
        if (Instance != null)
        {
            // Нам нужен один менеджер для всех сцен. Если он уже создан, другие убиваем при создании.
            // This pattern is called a singleton. You use it to ensure that only a single instance of the MainManager can ever exist
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
