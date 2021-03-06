/*
 * BouncerAPILib
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
package com.example.www.controllers;

import static org.junit.Assert.*;

import java.io.*;
import java.util.*;

import org.junit.AfterClass;
import org.junit.BeforeClass;
import org.junit.Test;

import com.example.www.models.*;
import com.example.www.exceptions.*;
import com.example.www.APIHelper;
import com.example.www.Configuration;
import com.example.www.testing.TestHelper;
import com.example.www.controllers.WhitelistController;

import com.fasterxml.jackson.core.type.TypeReference;

public class WhitelistControllerTest extends ControllerTestBase {
    
    /**
     * Controller instance (for all tests)
     */
    private static WhitelistController controller;
    
    /**
     * Setup test class
     */
    @BeforeClass
    public static void setUpClass() {
        controller = getClient().getWhitelist();
    }

    /**
     * Tear down test class
     * @throws IOException
     */
    @AfterClass
    public static void tearDownClass() throws IOException {
        controller = null;
    }

    /**
     * This will list the entire contents of the Whitelist including both IP Addresses and Geo Locations.
     * @throws Throwable
     */
    @Test
    public void testAllContents1() throws Throwable {

        // Set callback and perform API call
        AllContentsResponse result = null;
        controller.setHttpCallBack(httpResponse);
        try {
            result = controller.allContents();
        } catch(APIException e) {};

       // Test whether the response is null
        assertNotNull("Response is null", 
                httpResponse.getResponse());
        // Test response code
        assertEquals("Status is not 200", 
                200, httpResponse.getResponse().getStatusCode());

        // Test headers
        Map<String, String> headers = new LinkedHashMap<String, String>();
        headers.put("Content-Type", TestHelper.nullString);
        
        assertTrue("Headers do not match", TestHelper.areHeadersProperSubsetOf(
                headers, httpResponse.getResponse().getHeaders(), true));

        // Test whether the captured response is as we expected
        assertNotNull("Result does not exist", 
                result);
        assertEquals("Response body does not match exactly",
                "{  \"Result\": {    \"Status\": \"Success\",    \"Message\": \"\"  },  \"IPAddresses\": [    [      \"884d9804999fc47a3c2694e49ad2536a\",      \"192.168.100.14/24\"    ]  ],  \"GeoLocations\": [    \"884d9804999fc47a3c2694e49ad2536a#CA\"  ]}", 
                TestHelper.convertStreamToString(httpResponse.getResponse().getRawBody()));
    }

}
