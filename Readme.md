QR Code Generator API
============

QR Code Generator is a simple tool for generating QR codes. It returns a PNG image of the QR code.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a .NET Wrapper for the [QR Code Generator API](https://apiverve.com/marketplace/api/qrcodegenerator)

---

## Installation

Using the .NET CLI:
```
dotnet add package APIVerve.API.QRCodeGenerator
```

Using the Package Manager:
```
nuget install APIVerve.API.QRCodeGenerator
```

Using the Package Manager Console:
```
Install-Package APIVerve.API.QRCodeGenerator
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on Manage NuGet Packages..
4. Click on the Browse tab and search for "APIVerve.API.QRCodeGenerator".
5. Click on the APIVerve.API.QRCodeGenerator package, click Install.


---

## Configuration

Before using the qrcodegenerator API client, you have to setup your account and obtain your API Key.  
You can get it by signing up at [https://apiverve.com](https://apiverve.com)

---

## Usage

The QR Code Generator API documentation is found here: [https://docs.apiverve.com/api/qrcodegenerator](https://docs.apiverve.com/api/qrcodegenerator).  
You can find parameters, example responses, and status codes documented here.

### Setup

###### Authentication
QR Code Generator API uses API Key-based authentication. When you create an instance of the API client, you can pass your API Key as a parameter.

```
// Create an instance of the API client
var apiClient = new QRCodeGeneratorAPIClient("[YOUR_API_KEY]", true);
```

---


### Perform Request
Using the API client, you can perform requests to the API.

###### Define Query

```
var queryOptions = new QRCodeGeneratorQueryOptions {
  value = "https://myspace.com",
  type = "url",
  format = "png",
  margin = "0"
};
```

###### Simple Request

```
var response = apiClient.Execute(queryOptions);
if(response.error != null) {
	Console.WriteLine(response.error);
} else {
    var jsonResponse = JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented);
    Console.WriteLine(jsonResponse);
}
```

###### Example Response

```
{
  "status": "ok",
  "error": null,
  "data": {
    "id": "31d88a02-4dd3-4c97-9725-995551c31512",
    "format": "png",
    "type": "url",
    "correction": "M",
    "size": 5,
    "margin": 0,
    "expires": 1740259974243,
    "downloadURL": "https://storage.googleapis.com/apiverve.appspot.com/qrcodegenerator/7277a6dc-6b1f-4af4-820a-755eb1c1a24d.png?GoogleAccessId=635500398038-compute%40developer.gserviceaccount.com&Expires=1740259974&Signature=kk80QPNRGLhIXm6%2BmKozIhoq2ZpehDsiT7%2FyHp4JxvSj5f6EdktMxJrZipxZiz%2BgQNKdr%2F30jaBk8DWT2Q6rPNdQjbJlh1ibu6FnghwMTwtJwU7Y0o2xBXm1b6p9TdqcpMK3ueJviYJ7mnsxdIud6aIQb1t%2FnaUQM%2Fu4dIB8%2By5xXIzldiKKu7zXttyQYb5qHIb89gadMfjd8SVVJVNXm97eroa82C9QL%2Bspuz9grMvyq7x7PfpXW3pZo89x9QKYQu1hT%2Bv1exID7CKv7keZcQ5v7IdSCPGKZyweGsVRQHJ4gwWHJcA2%2FGXrMUKVzXjkUsYBhEArblnh3FVI2%2FP3FQ%3D%3D"
  },
  "code": 200
}
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact).

---

## Updates
Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the APIVerve website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2025 APIVerve, and EvlarSoft LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.