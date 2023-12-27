/*
 * Echo Server API
 * Echo Server API
 *
 * The version of the OpenAPI document: 0.1.0
 * Contact: team@openapitools.org
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.api;

import org.junit.Assert;
import org.junit.jupiter.api.Assertions;
import org.openapitools.client.ApiException;
import org.junit.jupiter.api.Disabled;
import org.junit.jupiter.api.Test;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import org.openapitools.client.ApiResponse;

/**
 * API tests for AuthApi
 */
public class AuthApiTest {

    private final AuthApi api = new AuthApi();

    /**
     * To test HTTP basic authentication
     *
     * To test HTTP basic authentication
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void testAuthHttpBasicTest() throws ApiException {
        String response = api.testAuthHttpBasic();
        // TODO: test validations
    }

    /**
     * To test HTTP bearer authentication
     *
     * To test HTTP bearer authentication
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void testAuthHttpBearerTest() throws ApiException {
        String response;
        api.getApiClient().setBearerToken("fixed token");
        response = api.testAuthHttpBearer();
        Assertions.assertTrue(response.contains("Authorization: Bearer fixed token"));

        api.getApiClient().setBearerToken(() -> "dynamic token");
        response = api.testAuthHttpBearer();
        Assertions.assertTrue(response.contains("Authorization: Bearer dynamic token"));
    }

}
