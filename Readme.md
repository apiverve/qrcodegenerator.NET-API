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
3. Click on Manage NuGet Packages...
4. Click on the Browse tab and search for "APIVerve.API.QRCodeGenerator".
5. Click on the APIVerve.API.QRCodeGenerator package, select the appropriate version in the right-tab and click Install.


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
var queryOptions = new qrcodegeneratorQueryOptions{
  value: "https://myspace.com",
  format: "png",
  margin: "0"
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
    "type": "png",
    "correction": "M",
    "size": 5,
    "margin": 0,
    "base64Image": "iVBORw0KGgoAAAANSUhEUgAAAH0AAAB9CAAAAACq6zP5AAABIElEQVR42u3aQQ7DIAxE0dz/0nQdJMyMSTfMZ9WKkkelJNiG59m38W5Tx/STqeO8od+qj1Vb9tZIPXYehh6s11dQ73RhgujoB3r92kRH/6++NNHRS11dxoWvn0cX6BfqQq7R/PRRJoV+lz7EVo9QM5h5GHqm7geKjRy5vh56nK4GgNYU5F70dF3NgtVqobLwo2fq6t6HGmT6+yvo8brwHPgJ9WaC6Jm6WnYREhU/8UYP1YVKspBQC5sn63+Mnqn7e7rLEdb00ZN1P2S0NjvWyTh6nO7XqK364ubGR8/UjzfNjt+Y6KG6evZADS2tCaIn69Y5K/9JapTJ0dGN0wVqHICO3jtT2nwto6Pv13dht1itFqKjOytzM8n56EQr+i36D9bq7I+6Id+AAAAAAElFTkSuQmCC"
  }
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

Copyright (&copy;) 2024 APIVerve, and Evlar LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.