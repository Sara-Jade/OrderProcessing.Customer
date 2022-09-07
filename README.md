# OrderProcessing.Customer

OrderProcessing.Customer is a microservice of a backends for frontends demo suite of apps. [BFF.Mobile](https://github.com/Sara-Jade/BFF.Mobile) is the BFF that corresponds to this service. The BFF suite includes OrderProcessing.Customer, [OrderProcessing.Product](https://github.com/Sara-Jade/OrderProcessing.Product), [BFF.Web](https://github.com/Sara-Jade/BFF.Web), and [BFF.Mobile](https://github.com/Sara-Jade/BFF.Mobile). In addition, [BFF.Monolith](https://github.com/Sara-Jade/BFF.Monolith) is all of the repos housed under one gigantic project.

<br>

## Getting Started

### You will need
- Visual Studio 2022. The [VS Community](https://visualstudio.microsoft.com/vs/community/) edition is free. This project was built with VS 2022, and I haven't tested it with older versions.
- .NET 6
- Postman or a web browser to demo

<br>

## Demoing
As a stand alone service:
1. OrderProcessing.Customer utilizes Swagger. As such, use Visual Studio to start the project, and Swagger will open in your browser.
2. You may also use Postman to demo

From its BFF:
1. [BFF.Mobile](https://github.com/Sara-Jade/BFF.Mobile) has a controller with a port number associated with OrderProcessing.Customer. *You may need to update this port number the first time you start the BFF.*
2. Use Visual Studio to start OrderProcessing.Customer.
3. Use Visual Studio to start [BFF.Mobile](https://github.com/Sara-Jade/BFF.Mobile).
5. Now you can create a URL to hit the BFF in your web browser or Postman, e.g., `http://localhost:<port number>/api/<controller name minus "controller">/<route>`

<br>

## Build
Use Visual Studio 2022 to build.

<br>

## Test
Use Postman or your web browser for manual testing/demoing. As stated in Getting Started, don't forget to update each BFF controller's port number the first time using it!
