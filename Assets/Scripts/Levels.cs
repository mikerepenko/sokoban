using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour
{
    /*
     * bl bush-light
     * bd bush-dark
     * bu bush-usal
     * 
     * p0 player
     * b0 box
     * bg background
     * t0 target
     * s0 stone
     * tb target-box
     * tr tree
     * 
     * gl grass-light
     * gd grass-dark
     *
     * pl plant-light
     * pd plant-dark
     */
    static string[,] level1 = {
        { "bl", "bl", "bu", "bu", "bg", "bg", "bg", "bg", "bg" },
        { "bl", "gl", "gl", "bl", "bg", "bg", "bg", "bg", "bg" },
        { "bl", "gl", "gl", "bl", "bl", "bl", "bl", "bl", "bu" },
        { "bl", "gl", "gl", "gl", "gl", "gl", "gl", "bl", "bu" },
        { "bu", "bl", "p0", "t0", "bl", "b0", "gl", "bl", "bu" },
        { "pl", "gl", "gl", "gl", "bl", "gl", "gl", "bl", "bu" },
        { "bl", "gl", "gl", "gl", "bl", "bl", "bl", "bl", "bu" },
        { "bl", "bl", "bl", "pd", "bd", "bg", "bg", "bg", "bg" },
        { "bd", "bd", "bd", "bd", "bg", "bg", "bg", "bg", "bg" }
    };
    static string[,] level2 = {
        { "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg" },
        { "bg", "bg", "bl", "bl", "bl", "bl", "bl", "bl", "bg" },
        { "bg", "bg", "bl", "gl", "gl", "gl", "gl", "bl", "bg" },
        { "bg", "bl", "bl", "b0", "gl", "t0", "gl", "bl", "bg" },
        { "bg", "bl", "gl", "gl", "p0", "gl", "gl", "bl", "bg" },
        { "bg", "bl", "gl", "b0", "bl", "t0", "gl", "bl", "bg" },
        { "bg", "bl", "gl", "gl", "bl", "bl", "bl", "bl", "bg" },
        { "bg", "bl", "bl", "bl", "bd", "bg", "bg", "bg", "bg" },
        { "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg" }
    };
     static string[,] level3 = {
        { "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg" },
        { "bg", "bl", "bl", "bl", "bl", "gl", "gl", "gl", "bg" },
        { "bg", "bl", "t0", "gl", "bl", "gl", "gl", "gl", "bg" },
        { "bg", "bl", "t0", "gl", "bl", "bl", "bl", "bl", "bg" },
        { "bg", "bl", "p0", "b0", "gl", "gl", "bl", "bl", "bg" },
        { "bg", "bl", "gl", "b0", "gl", "gl", "bl", "bl", "bg" },
        { "bg", "bl", "gl", "gl", "bl", "bl", "bl", "bl", "bg" },
        { "bg", "bl", "bl", "bl", "bl", "gl", "gl", "gl", "bg" },
        { "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg" }
    };
    static string[,] level4 = {
        { "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg" },
        { "bg", "bl", "bl", "bl", "bl", "bl", "bl", "bl", "bg" },
        { "bg", "bl", "t0", "gl", "p0", "gl", "gl", "bl", "bg" },
        { "bg", "bl", "gl", "gl", "b0", "b0", "gl", "bl", "bg" },
        { "bg", "bl", "bl", "bl", "gl", "t0", "bl", "bl", "bg" },
        { "bg", "gl", "gl", "bl", "gl", "gl", "bl", "gl", "bg" },
        { "bg", "gl", "gl", "bl", "bl", "bl", "bl", "gl", "bg" },
        { "bg", "gl", "gl", "bl", "bl", "bl", "bl", "gl", "bg" },
        { "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg" }
    };
    static string[,] level5 = {
        { "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg" },
        { "bg", "gl", "gl", "gl", "gl", "gl", "gl", "gl", "bg" },
        { "bg", "gl", "gl", "gl", "gl", "gl", "gl", "gl", "bg" },
        { "bg", "gl", "gl", "gl", "gl", "gl", "gl", "gl", "bg" },
        { "bg", "gl", "gl", "gl", "gl", "gl", "gl", "gl", "bg" },
        { "bg", "gl", "gl", "gl", "gl", "gl", "gl", "gl", "bg" },
        { "bg", "gl", "gl", "gl", "gl", "gl", "gl", "gl", "bg" },
        { "bg", "gl", "gl", "gl", "gl", "gl", "gl", "gl", "bg" },
        { "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg" }
    };
    //  static string[,] base = {
    //     { "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg" },
    //     { "bg", "gl", "gl", "gl", "gl", "gl", "gl", "gl", "bg" },
    //     { "bg", "gl", "gl", "gl", "gl", "gl", "gl", "gl", "bg" },
    //     { "bg", "gl", "gl", "gl", "gl", "gl", "gl", "gl", "bg" },
    //     { "bg", "gl", "gl", "gl", "gl", "gl", "gl", "gl", "bg" },
    //     { "bg", "gl", "gl", "gl", "gl", "gl", "gl", "gl", "bg" },
    //     { "bg", "gl", "gl", "gl", "gl", "gl", "gl", "gl", "bg" },
    //     { "bg", "gl", "gl", "gl", "gl", "gl", "gl", "gl", "bg" },
    //     { "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg" }
    // };
     
    // static string[,] level1 = {
    //     { "bg", "bg", "bu", "bu", "pl", "bg", "bg", "bg", "bg" },
    //     { "bg", "bg", "pl", "t0", "bl", "bg", "to", "bg", "bg" },
    //     { "bg", "tg", "bl", "gl", "bl", "bl", "bl", "bl", "bu" },
    //     { "bl", "bl", "bl", "b0", "gl", "b0", "gl", "t0", "bu" },
    //     { "bu", "t0", "gl", "b0", "p0", "s0", "bl", "bl", "pl" },
    //     { "pl", "bu", "bu", "s0", "b0", "bl", "bg", "bg", "bg" },
    //     { "bg", "bg", "bg", "bd", "t0", "bl", "bg", "bg", "bg" },
    //     { "bg", "bg", "bg", "pd", "bd", "bd", "bg", "bg", "bg" },
    //     { "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg" }
    // };

    // static string[,] level2 = {
    //     { "pl", "bu", "bl", "bl", "bd", "bg", "bg", "bg", "bg" },
    //     { "bu", "gd", "gd", "gd", "pd", "bg", "bg", "to", "bg" },
    //     { "bu", "gd", "b0", "gd", "bl", "bg", "bl", "bl", "bl" },
    //     { "bu", "gd", "b0", "gd", "bl", "bg", "bl", "t0", "pl" },
    //     { "pl", "bl", "s0", "p0", "bl", "bl", "bl", "t0", "bl" },
    //     { "bg", "bl", "s0", "b0", "gd", "gd", "gd", "t0", "bl" },
    //     { "bg", "bl", "gl", "gl", "gl", "s0", "gl", "gl", "bl" },
    //     { "bg", "bl", "gl", "gl", "gl", "bd", "bd", "pd", "bd" },
    //     { "bg", "bd", "bd", "pd", "bd", "bd", "bg", "bg", "bg" }
    // };

    // static string[,] level3 = {
    //     { "bg", "tg", "bl", "pl", "bu", "bg", "bg", "to", "bg" },
    //     { "pd", "bd", "gd", "gd", "bu", "bg", "bd", "bd", "ts" },
    //     { "bd", "gd", "p0", "b0", "bu", "bg", "pd", "bl", "bl" },
    //     { "bl", "s0", "b0", "gd", "bu", "bl", "bl", "s0", "pl" },
    //     { "bl", "s0", "gd", "b0", "gl", "gl", "gl", "gl", "bu" },
    //     { "bl", "t0", "b0", "gd", "gl", "gl", "gl", "s0", "bu" },
    //     { "bl", "t0", "t0", "tb", "t0", "s0", "gd", "gd", "pd" },
    //     { "pd", "bd", "bd", "bd", "bd", "bd", "pd", "bd", "bd" },
    //     { "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg" }
    // };

    // static string[,] level4 = {
    //     { "bg", "tg", "bu", "bu", "pl", "bg", "bg", "bg", "bg" },
    //     { "bg", "bl", "gl", "gl", "bl", "bd", "pd", "bg", "bg" },
    //     { "bg", "pl", "gl", "gl", "p0", "gd", "bd", "to", "bg" },
    //     { "ts", "bu", "bu", "b0", "s0", "gd", "bl", "bl", "pd" },
    //     { "bl", "t0", "s0", "gd", "pl", "gl", "gl", "s0", "bd" },
    //     { "pd", "t0", "b0", "gd", "gd", "s0", "gl", "gl", "bl" },
    //     { "bd", "t0", "gd", "gd", "gd", "b0", "gl", "gd", "bl" },
    //     { "bd", "bd", "bd", "pd", "bd", "bd", "bd", "bd", "pd" },
    //     { "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg" }
    // };

    // static string[,] level5 = {
    //     { "bg", "to", "bd", "bl", "pl", "bl", "bl", "pd", "bd" },
    //     { "bg", "bl", "pd", "gd", "gd", "gd", "gl", "gl", "bu" },
    //     { "bu", "bu", "s0", "b0", "b0", "b0", "gl", "gl", "bu" },
    //     { "bu", "gl", "gl", "b0", "t0", "t0", "gl", "s0", "bu" },
    //     { "bl", "p0", "b0", "t0", "t0", "t0", "bd", "bd", "pd" },
    //     { "pd", "bd", "bd", "s0", "gd", "gd", "pd", "bg", "bg" },
    //     { "bg", "bg", "bd", "pd", "bd", "bd", "bd", "bg", "bg" },
    //     { "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg" },
    //     { "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg" }
    // };

    // static string[,] level6 = {
    //  { "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg" },
    //     { "bg", "ts", "pl", "bl", "bl", "bd", "pd", "to", "bg" },
    //     { "bu", "bu", "bu", "gd", "gd", "p0", "bd", "bu", "bu" },
    //     { "pl", "gl", "gl", "b0", "t0", "gl", "s0", "gl", "bu" },
    //     { "bl", "gl", "gl", "t0", "b0", "t0", "gl", "gl", "pl" },
    //     { "bd", "pd", "s0", "gd", "tb", "b0", "gd", "gd", "bl" },
    //     { "bg", "bd", "bd", "gd", "gd", "gd", "s0", "gd", "bd" },
    //     { "bg", "bg", "bd", "pd", "bd", "bd", "bd", "bd", "pd" },
    //     { "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg" }
    // };

    // static string[,] level7 = {
    //     { "bg", "bg", "bd", "pd", "bl", "bl", "bg", "bg", "bg" },
    //     { "bg", "tg", "bd", "t0", "t0", "bu", "bg", "bg", "bg" },
    //     { "bg", "bl", "bd", "gd", "t0", "bu", "bu", "to", "bg" },
    //     { "bg", "pl", "gd", "gd", "b0", "t0", "bl", "pl", "bg" },
    //     { "bl", "bl", "gl", "b0", "gd", "gd", "s0", "bu", "bu" },
    //     { "bu", "gl", "gl", "s0", "b0", "b0", "gd", "gd", "bu" },
    //     { "bu", "gl", "gl", "p0", "gl", "gl", "gl", "s0", "bd" },
    //     { "bd", "pd", "bd", "bd", "bd", "bd", "bd", "bd", "pd" },
    //     { "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg" }
    // };

    // static string[,] level8 = {
    //     { "bg", "ts", "bg", "bg", "bg", "bg", "to", "bg", "bg" },
    //     { "pl", "bl", "bu", "bu", "bl", "bl", "bl", "pd", "bd" },
    //     { "bl", "gd", "gd", "s0", "gl", "gl", "gl", "gl", "bd" },
    //     { "bl", "p0", "b0", "t0", "t0", "b0", "gl", "s0", "bl" },
    //     { "bu", "gd", "b0", "t0", "tb", "gl", "s0", "pl", "bl" },
    //     { "bu", "gd", "b0", "t0", "t0", "b0", "gl", "gl", "bl" },
    //     { "bu", "gd", "gd", "s0", "gl", "gl", "gl", "gl", "bd" },
    //     { "pd", "bd", "bd", "bd", "bd", "bd", "pd", "bd", "bd" },
    //     { "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg" }
    // };

    // static string[,] level9 = {
    //     { "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg" },
    //     { "bu", "bu", "pl", "bl", "bl", "pd", "bg", "bg", "bg" },
    //     { "bu", "gl", "gl", "gl", "gl", "bd", "bg", "to", "bg" },
    //     { "bu", "gl", "b0", "b0", "b0", "bd", "bu", "bu", "bg" },
    //     { "bu", "gl", "gl", "s0", "t0", "t0", "s0", "bl", "bl" },
    //     { "pl", "s0", "gl", "gl", "t0", "t0", "b0", "gd", "bl" },
    //     { "bd", "bd", "gl", "p0", "gd", "gd", "gd", "gd", "bd" },
    //     { "bg", "bd", "pd", "bd", "bd", "bd", "bd", "bd", "pd" },
    //     { "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg" }
    // };

    // static string[,] level10 = {
    //     { "bg", "bu", "pl", "bl", "bl", "bl", "pd", "bd", "bg" },
    //     { "bg", "bu", "t0", "t0", "b0", "t0", "t0", "bd", "bg" },
    //     { "bg", "bu", "t0", "t0", "s0", "t0", "t0", "bd", "bg" },
    //     { "bg", "bl", "gd", "b0", "b0", "b0", "gd", "bl", "bg" },
    //     { "bg", "pl", "gl", "gl", "b0", "gl", "gl", "bl", "bg" },
    //     { "bg", "bl", "gl", "b0", "b0", "b0", "gl", "bl", "bg" },
    //     { "bg", "bl", "gl", "gl", "s0", "p0", "gl", "bd", "bg" },
    //     { "bg", "bd", "pd", "bd", "bd", "bd", "bd", "pd", "bg" },
    //     { "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg" }
    // };

    // static string[,] level11 = {
    //     { "bg", "bg", "bg", "bg", "bg", "bg", "bg", "to", "bg" },
    //     { "bg", "pl", "bl", "bu", "bu", "bu", "bu", "bd", "bd" },
    //     { "ts", "bl", "gl", "p0", "gl", "s0", "gl", "s0", "bd" },
    //     { "bu", "bu", "gl", "s0", "b0", "gl", "gl", "gl", "pl" },
    //     { "bl", "gd", "tb", "t0", "gd", "t0", "gl", "gl", "bl" },
    //     { "bl", "gd", "gd", "b0", "b0", "gd", "bu", "bu", "bu" },
    //     { "pd", "bd", "bd", "gd", "s0", "t0", "bd", "bg", "bg" },
    //     { "bg", "bg", "bd", "gd", "gd", "gd", "pd", "bg", "bg" },
    //     { "bg", "bg", "pd", "bd", "bd", "bd", "bd", "bg", "bg" }
    // };

    // static string[,] level12 = {
    //     { "bg", "pd", "bd", "bl", "bl", "bl", "pl", "bu", "bg" },
    //     { "bg", "bd", "gd", "gd", "gd", "gd", "s0", "bu", "bg" },
    //     { "bg", "bl", "gd", "b0", "gd", "p0", "gd", "bu", "bg" },
    //     { "bg", "bl", "s0", "tb", "gd", "gd", "gd", "tg", "bg" },
    //     { "bg", "bl", "gl", "tb", "gl", "pl", "bl", "bu", "bg" },
    //     { "bg", "bl", "gl", "tb", "gl", "bl", "bg", "bg", "bg" },
    //     { "bg", "bl", "gl", "tb", "gl", "bl", "bg", "bg", "bg" },
    //     { "bg", "pl", "gl", "t0", "gl", "bd", "bg", "bg", "bg" },
    //     { "bg", "bd", "bd", "bd", "bd", "pd", "bg", "bg", "bg" }
    // };

    // static string[,] level13 = {
    //     { "bg", "bg", "bg", "bd", "bl", "pl", "bu", "bg", "bg" },
    //     { "bg", "to", "pd", "bd", "gd", "gd", "bu", "ts", "bg" },
    //     { "bg", "bd", "bd", "s0", "b0", "gd", "bu", "bu", "bg" },
    //     { "bg", "bl", "gd", "gd", "tb", "gd", "p0", "bu", "bg" },
    //     { "bg", "pl", "gd", "gd", "tb", "gl", "gl", "bl", "bg" },
    //     { "bg", "bl", "gl", "gl", "tb", "gl", "s0", "bl", "bg" },
    //     { "bg", "bl", "bl", "bl", "tb", "gl", "bd", "bd", "bg" },
    //     { "bg", "bg", "bg", "bd", "t0", "bd", "pd", "bg", "bg" },
    //     { "bg", "bg", "bg", "pd", "bd", "bd", "bg", "bg", "bg" }
    // };

    // static string[,] level14 = {
    //     { "bl", "pl", "bl", "bd", "bd", "bg", "bg", "to", "bg" },
    //     { "bu", "gl", "gl", "gl", "bd", "bd", "bl", "pl", "bu" },
    //     { "bu", "gl", "s0", "gl", "s0", "gl", "gl", "gl", "bu" },
    //     { "bu", "gl", "b0", "gl", "gl", "gl", "b0", "gl", "bu" },
    //     { "bu", "t0", "t0", "s0", "b0", "s0", "b0", "bl", "bu" },
    //     { "bl", "t0", "p0", "b0", "gd", "gd", "gd", "bl", "bg" },
    //     { "bl", "t0", "t0", "gd", "gd", "bd", "bd", "bd", "bg" },
    //     { "pd", "bd", "bd", "bd", "bd", "pd", "bg", "bg", "bg" },
    //     { "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg" }
    // };

    // static string[,] level15 = {
    //     { "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg" },
    //     { "bg", "bu", "bu", "bu", "bu", "pl", "bl", "bd", "ts" },
    //     { "ts", "bu", "gl", "gl", "gl", "gl", "s0", "bd", "bd" },
    //     { "pl", "bl", "t0", "s0", "s0", "b0", "gl", "gl", "pl" },
    //     { "bl", "gd", "t0", "t0", "b0", "gl", "gl", "gl", "bl" },
    //     { "bl", "gd", "gd", "s0", "b0", "gl", "gl", "gl", "bl" },
    //     { "pd", "gd", "gd", "p0", "gd", "bd", "bd", "bd", "bl" },
    //     { "bd", "bd", "bd", "bd", "pd", "bd", "bg", "bg", "bg" },
    //     { "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg", "bg" }
    // };

    public string[][,] number = {
        level1,
        level2,
        level3,
        level4,
        level5,
        level1,
        level2,
        level3,
        level4,
        level1,
        level2,
        level3,
        level4,
        level1,
        level2,
        level3,
        level4,
        // level6,
        // level7,
        // level8,
        // level9,
        // level10,
        // level11,
        // level12,
        // level13,
        // level14,
        // level15,
    };
}
