using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public WeatherData weatherData;
    public string currentWeather;
    public bool rain;
    public bool snow;
    public bool cloudy;
    public bool sunny;
    public bool start = true;

    void Update()
    {
        //update once when weather is displayed
        if (start==true)
            if (weatherData.isReady)
            {
                currentWeather = weatherData.Info.currently.icon;

                if (currentWeather == "rain")
                {
                    start = false;
                    Debug.LogFormat("raining");
                    return;
                }
                else if (currentWeather == "snow" || currentWeather == "sleet")
                {
                    start = false;
                    Debug.LogFormat("snowing");
                    return;

                }
                else if (currentWeather == "cloudy" || currentWeather == "partly-cloudy-day" || currentWeather == "partly-cloudy-night" || currentWeather == "fog")
                {
                    start = false;
                    Debug.LogFormat("cloudy");
                    return;
                }
                else if (currentWeather == "clear-day" || currentWeather == "clear-night" || currentWeather == "wind")
                {
                    start = false;
                    Debug.LogFormat("sunny");
                    return;
                }
                else
                {
                    start = false;
                    Debug.LogFormat("no weather");
                    return;
                }  
            }
        //keeps outputting text until weather data is ready
            else
            {
                Debug.LogFormat("weather not ready");
                return;
            }   
    }
}