using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utils
{
    public static float mapRange(float value, float fromRa, float fromRb, float toRa, float toRb)
    {// https://stackoverflow.com/questions/48802987/is-there-a-map-function-in-vanilla-javascript-like-p5-js#:~:text=function%20mapRange%20(value%2C%20a%2C%20b%2C%20c%2C%20d)%20%7B
        // first map value from (a..b) to (0..1)
        value = (value - fromRa) / (fromRb - fromRa);
        // then map it from (0..1) to (c..d) and return it
        return toRa + value * (toRb - toRa);
    }
}
