/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package com.mycompany.calculator;


/**
 * REST Web Service
 *
 * @author user
 */

public class ItemResource {
    private String name;
    /** Creates a new instance of ItemResource */
    private ItemResource(String name) {
        this.name=name;
    }

    /** Get instance of the ItemResource */
    public static ItemResource getInstance(String name) {
        // The user may use some kind of persistence mechanism
        // to store and restore instances of ItemResource class.
        return new ItemResource(name);
    }
}
