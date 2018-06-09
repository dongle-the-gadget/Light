# Light

[master-build-badge]:        https://img.shields.io/badge/build-successed-brightgreen.svg?style=flat-square

![WinRT][master-build-badge]

This application is the Windows Runtime Component used for Windows IoT. This use the class GpioPin to control the General Purpose Input Output (GPIO) pins on your device. In this case, a LED light.

## How to get the resources

### GitHub

1. Get the source code <a href="https://github.com/superkid200/Light/releases/tag/2.0.0">here</a>

2. Get the code by extract the downloaded code.

3. Build this project by Visual Studio.

4. Add the already build .winmd file to your UWP application.

5. Use the already class in the namespace Microsoft.Maker.IoT.Light.Library.

### NuGet

1. Go to NuGet Package Manager in Visual Studio.

2. Choose Browse.

3. Enter Microsoft-IoT-Maker-Light-Library

4. Install the Package.

5. Use the already class in the namespace Microsoft.Maker.IoT.Light.Library.

## Introduction of classes in Microsoft.Maker.IoT.Light.Library

### Lights

This wrapper class contains the requirements to get the GPIO pins on your machine and get the pin you desire.

GetLights(IoTDevice): Get the Lights class with the number of pins included in your machine.

GetLightByGpio(int): Get the Light class with the GPIO pin number. Note your device need to have GPIO number you desired.

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

### Helpers

This wrapper class contains the requirements to check if this application will work or not.

## Use the code (C#)

### Check if machine is capable or not

      ...
      if(Helpers.IsCapable())
      {
          // This machine is capable. Do your code here.
      }
      
### Get the instance of Lights class

      ...
      // Example: You have a Raspberry Pi
      Lights lights = Lights.GetLights(IoTDevice.RaspberryPi);
      
### Get the instance of Light from a Lights class

      ...
      // Example: You have a Raspberry Pi
      Lights lights = Lights.GetLights(IoTDevice.RaspberryPi);
      // Example: You want to use GPIO 5
      Light light = lights.GetLightByGpio(5);
      
### Turn light on or off with current Light instance

      ...
      Lights lights = Lights.GetLights(IoTDevice.RaspberryPi);
      // Example: You want to use GPIO 5
      Light light = lights.GetLightByGpio(5);
      // Turn the light on
      light.Status.isOn = true;
      // Turn the light off
      light.Status.isOn = false;
