# DigitalFemsa .NET API Library
[![nuget](https://img.shields.io/nuget/v/DigitalFemsa.net.svg)](https://www.nuget.org/packages/DigitalFemsa.net/) [![nuget](https://img.shields.io/nuget/dt/DigitalFemsa.net.svg)](https://www.nuget.org/packages/DigitalFemsa.net/)[![dotnet CI](https://github.com/digitalfemsa/digitalfemsa-.net/actions/workflows/dotnet.yml/badge.svg)](https://github.com/digitalfemsa/digitalfemsa-.net/actions/workflows/dotnet.yml) 

This is the officially supported .NET library for using DigitalFemsa's APIs.
## Supported API versions
The library supports all APIs under the following services:

| API                                                                  | Description | Service Name | Supported version |
|----------------------------------------------------------------------| ----------- |-------|-------------------|
| [Payments API](https://developers.digitalfemsa.io/reference) | Our classic integration for online payments. Current supported version | Payments API | **v2.1.0**        |

For more information, refer to our [documentation](https://developers.digitalfemsa.io/docs).

## Prerequisites
- [DigitalFemsa account](https://panel.digitalfemsa.io/)
- [API key](https://developers.digitalfemsa.io/docs/como-obtener-tus-api-keys).  your API credential .
- DigitalFemsa dotnet API Library supports .net standard 2.0 and above

## Installation
Simply download and restore nuget packages https://www.nuget.org/packages/DigitalFemsa.net/
or install it from package manager
```
PM> Install-Package DigitalFemsa.net -Version x.x.x
```
## Using the library

In order to submit http request to DigitalFemsa API you need to initialize the client. The following example makes a order request:
```c#

// Create a OrderRequest
using System;
using System.Collections.Generic;
using DigitalFemsa.net.Client;
using DigitalFemsa.net.Api;
using DigitalFemsa.net.Model;

// create the http client

string acceptLanguage = "en";
Configuration configuration = new()
{
    AccessToken = "Your merchant XAPI key"
};
var ordersApi = new OrdersApi(configuration);
var customerApi = new CustomersApi(config);

// create customer
var customer = new Customer(
    name: "test dot",
    phone: "+573143159063",
    email: "test@digitalfemsa.com"
);
CustomerResponse customerResponse = customerApi.CreateCustomer(customer);
// Create OrderRequest

var lineItems = new List<LineItems>{new (
        name: "toshiba",
        quantity: 1,
        unitPrice: 1555
    )};
var charges = new List<ChargeRequest>{new (
    amount: 1555,
    paymentMethod: new ChargeRequestPaymentMethod("cash")
)};
var customerInfo = new OrderRequestCustomerInfo(new CustomerInfoJustCustomerId(customerResponse.Id));
OrderRequest orderRequest = new OrderRequest(
    currency: "MXN",
    customerInfo: customerInfo,
    lineItems: lineItems,
    charges: charges
);
            
//Make the call to the service. This example code makes a call to /orders
OrderResponse response = ordersApi.CreateOrder(orderRequest, acceptLanguage);
```


## Running the tests
Navigate to digitalfemsa-.net folder and run the following commands.
```
dotnet build
dotnet test
```

## Contributing
We encourage you to contribute to this repository, so everyone can benefit from new features, bug fixes, and any other improvements.
Have a look at our [contributing guidelines](https://github.com/digitalfemsa/digitalfemsa-.net/blob/main/CONTRIBUTING.md) to find out how to raise a pull request.

## Support
If you have a feature request, or spotted a bug or a technical problem, [create an issue here](https://github.com/digitalfemsa/digitalfemsa-.net/issues/choose).

For other questions, [contact our Support Team](https://developers.digitalfemsa.io/discuss).

## Licence
This repository is available under the [MIT license](https://github.com/digitalfemsa/digitalfemsa-.net/blob/master/LICENSE).

## See also
* [DigitalFemsa docs](https://developers.digitalfemsa.io/docs)
