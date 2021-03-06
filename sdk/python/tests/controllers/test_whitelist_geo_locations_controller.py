# -*- coding: utf-8 -*-

"""
    bouncerapi

    This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
"""

import jsonpickle
import dateutil.parser
from .controller_test_base import ControllerTestBase
from ..test_helper import TestHelper
from bouncerapi.api_helper import APIHelper


class WhitelistGeoLocationsControllerTests(ControllerTestBase):

    @classmethod
    def setUpClass(cls):
        super(WhitelistGeoLocationsControllerTests, cls).setUpClass()
        cls.controller = cls.api_client.whitelist_geo_locations

    # Get Details of a Geo Location Entry in the Whitelist
    def test_get_details_1(self):
        # Parameters for the API call
        entry_id = '884d9804999fc47a3c2694e49ad2536a'

        # Perform the API call through the SDK function
        result = self.controller.get_details(entry_id)

        # Test response code
        self.assertEquals(self.response_catcher.response.status_code, 200)

        # Test headers
        expected_headers = {}
        expected_headers['content-type'] = None

        self.assertTrue(TestHelper.match_headers(expected_headers, self.response_catcher.response.headers))

        
        # Test whether the captured response is as we expected
        self.assertIsNotNone(result)
        self.assertEqual('{  "Result": {    "Status": "Success",    "Message": ""  },  "Entry": {    "Country Code": "CA",    "Start_Date": "2019-04-05T02:04:16Z",    "End_Date": "2019-04-05T02:04:16Z",    "Comments": "noteworthy note",    "Active": true  }}', self.response_catcher.response.raw_body)


    # List all Geo Locations in the Whitelist
    def test_list_1(self):

        # Perform the API call through the SDK function
        result = self.controller.list()

        # Test response code
        self.assertEquals(self.response_catcher.response.status_code, 200)

        # Test headers
        expected_headers = {}
        expected_headers['content-type'] = None

        self.assertTrue(TestHelper.match_headers(expected_headers, self.response_catcher.response.headers))

        
        # Test whether the captured response is as we expected
        self.assertIsNotNone(result)
        self.assertEqual('{  "Result": {    "Status": "Success",    "Message": ""  },  "GeoLocations": [    "884d9804999fc47a3c2694e49ad2536a#CA"  ]}', self.response_catcher.response.raw_body)


