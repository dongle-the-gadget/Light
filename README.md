# Light

This application is the Windows Runtime Component used for Windows IoT. This use the class GpioPin to control the General Purpose Input Output (GPIO) pins on your device. In this case, a LED light.

## How to get the resources

1. Clone this repository by GitHub Desktop or Download as a ZIP file.

2. Build this project by Visual Studio.

3. Add the already build .winmd file to your UWP application.

4. Use the already class in the namespace Microsoft.Maker.IoT.Light.Library.

## Introduction of classes in Microsoft.Maker.IoT.Light.Library

### Lights

This wrapper class contains the requirements to get the GPIO pins on your machine and get the pin you desire.

GetLights(): Get the Lights class with the number of pins included in your machine.

### Light

This wrapper class contains the variables to control your lights.

Pin property: returns the GPIO pin you want to access.

Status property: return the status of your LED.

### LightStatus

This wrapper class contains the variables to change your lights status.

isOn property: return the current status of your LED or set your LED on or off.

### IoTDevice

This Enum contains three items:

RaspberryPi: Your board is a Raspberry Pi 2 or 3.

MinnowBoardMax: Your board is a Minnowboard Max.

DragonBoard: Your board is a DragonBoard 410c.
