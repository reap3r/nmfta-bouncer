/*
 * BouncerAPILib
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
package com.example.www.models;

import java.util.*;

public class Result6Builder {
    //the instance to build
    private Result6 result6;

    /**
     * Default constructor to initialize the instance
     */
    public Result6Builder() {
        result6 = new Result6();
    }

    public Result6Builder status(String status) {
        result6.setStatus(status);
        return this;
    }

    /**
     * an optional message
     */
    public Result6Builder message(String message) {
        result6.setMessage(message);
        return this;
    }

    /**
     * a unique identifier for the deleted IP Address ; opaque but likely a GUID
     */
    public Result6Builder entryID(String entryID) {
        result6.setEntryID(entryID);
        return this;
    }
    /**
     * Build the instance with the given values
     */
    public Result6 build() {
        return result6;
    }
}