# Light

[master-build-badge]:        https://img.shields.io/badge/build-successed-brightgreen.svg?style=flat-square

![WinRT][master-build-badge]

This application is the Windows Runtime Component used for Windows IoT. This use the class GpioPin to control the General Purpose Input Output (GPIO) pins on your device. In this case, a LED light.

## How to get the resources

### GitHub

1. Clone this repository by GitHub Desktop or Download as a ZIP file.

2. (ZIP files only) Extract the ZIP file to a folder.

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

### Helpers

This wrapper class contains the requirements to check if this application will work or not.

## Use the code (C#)

### Check if machine is capable or not

      if(Helpers.IsCapable())
      {
          // This machine is capable. Do your code here.
      }
      
### Get the instance of Lights class

      ...
      Lights lights = Lights.GetLights();
      
### Get the instance of Light from a Lights class

      ...
      Lights lights = Lights.GetLights();
      Light light = lights.
