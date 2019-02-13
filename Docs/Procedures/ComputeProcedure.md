### Compute Procedure
Returns a series of files either streamed to the client or as a .zip file.

#### Request Example
The REST URL section below displays the example url and an example configuration body that has be used to simulate a request.

The Procedure response provides the user configuration options for Compute Procedure method. These options are selected from the Procedure Resource response and submitted in the requesting HTTP body payload. The HTTP REST Request can be made by using an HTTP POST, similar to the following request:
```
POST /procedures HTTP/1.1
Host: stn.wim.usgs.gov
Content-Type: multipart/form-data; boundary=----WebKitFormBoundary7MA4YWxkTrZu0gW
cache-control: no-cache

Content-Disposition: form-data; name="file"; filename="..\NCCAR00007_1511451_sea.csv

Content-Disposition: form-data; name="entity"

{
   "id":1,
   "code":"Read",
   "name":"Read file",
   "description":"Ingests csv file and returns a time series used for selecting a date range for barometric and water-level scripts. [good_start_date, good_end_date],  This is run before processing barometric files and water-level files.",
   "configuration":[
      {
         "id":1,
         "name":"Input File Name",
         "value":"NCCAR00007_1511451_sea.csv"
      },
      {
         "id":2,
         "name":"Output file Name",
         "value":"Test_outputName"
      },
      {
         "id":3,
         "name":"Instrument Type",
         "required":true,
         "value":"Measurement Specialties"
      },
      {
         "id":7,
         "name":"Time Zone",
         "value":"US/Central"
      },
      {
         "id":8,
         "name":"Day Light Savings?",
         "value":false
      },
      {
         "id":11,
         "name":"Datum",
         "value":"NAVD88"
      },
      {
         "id":15,
         "name":"Pressure Type",
         "value":"Sea Pressure"
      }
   ]
}
------WebKitFormBoundary7MA4YWxkTrZu0gW--
```

The previous request response returns a multipart/biterange with 2 items;
1) a timeseries json file containing the processed result
2) and a status csv file. Identifying any issues, if any during the processing of the procedure.