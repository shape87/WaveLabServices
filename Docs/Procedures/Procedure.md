### Procedure Resource
Returns the selected procedure and any configuration options required to compute the post method. 

There are currently twenty one different configuration objects required for various resources.
The configuration body is used, instead of url parameters, in order to submit large lists of configuration options for the request.  

#### Request Example
The REST URL section below displays the example url and can be queried by selecting the blue "Load response" Button after the required parameters are populated. Table 1 lists an example parameter that can be used to simulate a request.
Table 1. Example of Site Resource services parameter names and values.

| Parameter     | Description   | Value |
| ------------- |:-------------:| -----:|
| CodeOrID    | unique resource code or ID from [Available Parameter Resource](./#/Procedures/GET/AvailableProcedures) | 3  |

Resulting in a response result that includes a list of configuration objects that (if required, is intended to be populated and returned to the [Compute Procedure](./#/Procedure/POST/ComputeProcedure) URL.
