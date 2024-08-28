# QR Code Generator

This C# program generates a QR code from a URL and saves it as a PNG image file in a specified directory. The program uses the `QRCoder.Core` library for generating the QR code.

![Code screen shot](/image.jpg)

## Prerequisites

-   `.NET 8` SDK
-   `QRCoder.Core` NuGet package
-   `System.Drawing.Common` library



## Installation

1.  Clone the repository or download the source code.
2.  Open the project in your preferred C# development environment.
3.  Restore the required NuGet packages.

## Usage

1.  Update the URL in the code :

    `Url generator = new Url("https://github.com/marhamatabadi");`

2.  Run the program. 
     The QR code will be generated from the specified URL and saved as a PNG image in the `OUTPUT` folder    		within the project directory.
    
3.  The output image file will have a filename in the format:
    `<timestamp>_QRCode.png` 
    

## Output

The generated QR code image will be saved inside an `OUTPUT` folder at the root of your project. 
If the folder doesn't exist, it will be created automatically.

## Libraries Used

-   **QRCoder.Core**: A popular library for generating QR codes.
-   **System.Drawing.Common**: Provides access to GDI+ graphics functionality.

## Contributing

Feel free to fork this project, make enhancements, or report issues.

## License

This project is licensed under the MIT License.